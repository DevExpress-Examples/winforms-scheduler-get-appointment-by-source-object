using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using System.Collections.Generic;

namespace SchedulerFindAptByRow {
    public partial class Form1 : Form {
        Dictionary<object, Appointment> appointmentRowDictionary = new Dictionary<object, Appointment>();
        Dictionary<Appointment, object> rowAppointmentDictionary = new Dictionary<Appointment, object>();

        public Form1() {
            InitializeComponent();
        }

        protected Dictionary<object, Appointment> AppointmentRowDictionary { get { return appointmentRowDictionary; } }
        protected Dictionary<Appointment, object> RowAppointmentDictionary { get { return rowAppointmentDictionary; } }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
            // TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);

            schedulerStorage1.Resources.DataSource = carsDBDataSet.Cars;
            schedulerStorage1.Appointments.DataSource = carsDBDataSet.CarScheduling;

            dataGridView1.DataSource = carsDBDataSet.CarScheduling;

            if (schedulerStorage1.Appointments.Count > 0)
                schedulerControl1.Start = schedulerStorage1.Appointments[0].Start;
        }

        private void schedulerStorage1_AppointmentCollectionLoaded(object sender, EventArgs e) {
            foreach (Appointment apt in schedulerStorage1.Appointments.Items) {
                AppointmentBaseCollection apts = new AppointmentBaseCollection();
                apts.Add(apt);
                RegisterAppointmentRows(apts);
                if (apt.Type == AppointmentType.Pattern) {
                    RegisterAppointmentRows(apt.GetExceptions());
                }
            }
        }

        private void schedulerStorage1_AppointmentCollectionCleared(object sender, EventArgs e) {
            AppointmentRowDictionary.Clear();
            RowAppointmentDictionary.Clear();
        }

        private void schedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e) {
            AppointmentBaseCollection apts = (AppointmentBaseCollection)e.Objects;
            foreach (Appointment apt in apts) {
                DataRow row = GetAppointmentRow(apt);
                RegisterAppointmentRow(row, apt);
            }
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e) {
            AppointmentBaseCollection apts = (AppointmentBaseCollection)e.Objects;
            foreach (Appointment apt in apts) {
                DataRow row = (DataRow)RowAppointmentDictionary[apt];
                AppointmentRowDictionary.Remove(row);
                RowAppointmentDictionary.Remove(apt);
            }
        }

        private void RegisterAppointmentRows(AppointmentBaseCollection apts) {
            foreach (Appointment apt in apts) {
                DataRow row = GetAppointmentRow(apt);
                RegisterAppointmentRow(row, apt);
            }
        }

        private void RegisterAppointmentRow(DataRow row, Appointment apt) {
            if (!AppointmentRowDictionary.ContainsKey(row)) {
                AppointmentRowDictionary.Add(row, apt);
            }
            if (!RowAppointmentDictionary.ContainsKey(apt)) {
                RowAppointmentDictionary.Add(apt, row);
            }
        }

        private DataRow GetAppointmentRow(Appointment apt) {
            return ((DataRowView)schedulerStorage1.GetObjectRow(apt)).Row;
        }

        protected Appointment FindAppointmentByRow(DataRow row) {
            if (AppointmentRowDictionary.ContainsKey(row))
                return AppointmentRowDictionary[row];
            else
                return null;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
            UpdateLabelVisible(false);
            if (dataGridView1.SelectedRows.Count != 0) {
                int rowIndex = dataGridView1.Rows.IndexOf(dataGridView1.SelectedRows[0]);
                DataRow row = this.carsDBDataSet.CarScheduling.Rows[rowIndex];
                Appointment apt = FindAppointmentByRow(row);

                schedulerControl1.Services.AppointmentSelection.ClearSelection();
                if (apt != null) {
                    if (apt.Type == AppointmentType.Pattern || apt.Type == AppointmentType.DeletedOccurrence) {
                        UpdateLabelVisible(true);
                        return;
                    }
                    schedulerControl1.ActiveView.SelectAppointment(apt);
                }
            }
        }

        private void schedulerControl1_Click(object sender, EventArgs e) {
            UpdateLabelVisible(false);
        }

        private void UpdateLabelVisible(bool visible) {
            lbNoAppointment.Visible = visible;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "EventType")
                e.Value = ((AppointmentType)Convert.ToInt32(e.Value)).ToString();
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e) {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Number")
                e.Value = e.RowIndex;
        }
    }
}
Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports System.Collections.Generic

Namespace SchedulerFindAptByRow
	Partial Public Class Form1
		Inherits Form
		Private appointmentRowDictionary_Renamed As New Dictionary(Of Object, Appointment)()
		Private rowAppointmentDictionary_Renamed As New Dictionary(Of Appointment, Object)()

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected ReadOnly Property AppointmentRowDictionary() As Dictionary(Of Object, Appointment)
			Get
				Return appointmentRowDictionary_Renamed
			End Get
		End Property
		Protected ReadOnly Property RowAppointmentDictionary() As Dictionary(Of Appointment, Object)
			Get
				Return rowAppointmentDictionary_Renamed
			End Get
		End Property

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBDataSet.Cars)
			' TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
			Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet.CarScheduling)

			schedulerStorage1.Resources.DataSource = carsDBDataSet.Cars
			schedulerStorage1.Appointments.DataSource = carsDBDataSet.CarScheduling

			dataGridView1.DataSource = carsDBDataSet.CarScheduling

			If schedulerStorage1.Appointments.Count > 0 Then
				schedulerControl1.Start = schedulerStorage1.Appointments(0).Start
			End If
		End Sub

		Private Sub schedulerStorage1_AppointmentCollectionLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerStorage1.AppointmentCollectionLoaded
			For Each apt As Appointment In schedulerStorage1.Appointments.Items
				Dim apts As New AppointmentBaseCollection()
				apts.Add(apt)
				RegisterAppointmentRows(apts)
				If apt.Type = AppointmentType.Pattern Then
					RegisterAppointmentRows(apt.GetExceptions())
				End If
			Next apt
		End Sub

		Private Sub schedulerStorage1_AppointmentCollectionCleared(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerStorage1.AppointmentCollectionCleared
			AppointmentRowDictionary.Clear()
			RowAppointmentDictionary.Clear()
		End Sub

		Private Sub schedulerStorage1_AppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsInserted
			Dim apts As AppointmentBaseCollection = CType(e.Objects, AppointmentBaseCollection)
			For Each apt As Appointment In apts
				Dim row As DataRow = GetAppointmentRow(apt)
				RegisterAppointmentRow(row, apt)
			Next apt
		End Sub

		Private Sub schedulerStorage1_AppointmentsDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsDeleted
			Dim apts As AppointmentBaseCollection = CType(e.Objects, AppointmentBaseCollection)
			For Each apt As Appointment In apts
				Dim row As DataRow = CType(RowAppointmentDictionary(apt), DataRow)
				AppointmentRowDictionary.Remove(row)
				RowAppointmentDictionary.Remove(apt)
			Next apt
		End Sub

		Private Sub RegisterAppointmentRows(ByVal apts As AppointmentBaseCollection)
			For Each apt As Appointment In apts
				Dim row As DataRow = GetAppointmentRow(apt)
				RegisterAppointmentRow(row, apt)
			Next apt
		End Sub

		Private Sub RegisterAppointmentRow(ByVal row As DataRow, ByVal apt As Appointment)
			If (Not AppointmentRowDictionary.ContainsKey(row)) Then
				AppointmentRowDictionary.Add(row, apt)
			End If
			If (Not RowAppointmentDictionary.ContainsKey(apt)) Then
				RowAppointmentDictionary.Add(apt, row)
			End If
		End Sub

		Private Function GetAppointmentRow(ByVal apt As Appointment) As DataRow
			Return (CType(schedulerStorage1.GetObjectRow(apt), DataRowView)).Row
		End Function

		Protected Function FindAppointmentByRow(ByVal row As DataRow) As Appointment
			If AppointmentRowDictionary.ContainsKey(row) Then
				Return AppointmentRowDictionary(row)
			Else
				Return Nothing
			End If
		End Function

		Private Sub dataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dataGridView1.SelectionChanged
			UpdateLabelVisible(False)
			If dataGridView1.SelectedRows.Count <> 0 Then
				Dim rowIndex As Integer = dataGridView1.Rows.IndexOf(dataGridView1.SelectedRows(0))
				Dim row As DataRow = Me.carsDBDataSet.CarScheduling.Rows(rowIndex)
				Dim apt As Appointment = FindAppointmentByRow(row)

				schedulerControl1.Services.AppointmentSelection.ClearSelection()
				If apt IsNot Nothing Then
					If apt.Type = AppointmentType.Pattern OrElse apt.Type = AppointmentType.DeletedOccurrence Then
						UpdateLabelVisible(True)
						Return
					End If
					schedulerControl1.ActiveView.SelectAppointment(apt)
				End If
			End If
		End Sub

		Private Sub schedulerControl1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.Click, lbNoAppointment.Click
			UpdateLabelVisible(False)
		End Sub

		Private Sub UpdateLabelVisible(ByVal visible As Boolean)
			lbNoAppointment.Visible = visible
		End Sub

		Private Sub dataGridView1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dataGridView1.CellFormatting
			If dataGridView1.Columns(e.ColumnIndex).DataPropertyName = "EventType" Then
				e.Value = (CType(Convert.ToInt32(e.Value), AppointmentType)).ToString()
			End If
		End Sub

		Private Sub dataGridView1_CellValueNeeded(ByVal sender As Object, ByVal e As DataGridViewCellValueEventArgs) Handles dataGridView1.CellValueNeeded
			If dataGridView1.Columns(e.ColumnIndex).Name = "Number" Then
				e.Value = e.RowIndex
			End If
		End Sub
	End Class
End Namespace
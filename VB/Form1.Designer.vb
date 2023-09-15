Namespace SchedulerFindAptByRow

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.carsDBDataSet = New SchedulerFindAptByRow.CarsDBDataSet()
            Me.carSchedulingTableAdapter = New SchedulerFindAptByRow.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
            Me.carsTableAdapter = New SchedulerFindAptByRow.CarsDBDataSetTableAdapters.CarsTableAdapter()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.lbNoAppointment = New System.Windows.Forms.Label()
            Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.iDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.subjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.startTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.endTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.eventTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.recurrenceInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.carsDBDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Week
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.OptionsView.ResourceHeaders.Height = 100
            Me.schedulerControl1.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top
            Me.schedulerControl1.OptionsView.ResourceHeaders.ImageSize = New System.Drawing.Size(100, 100)
            Me.schedulerControl1.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.ZoomImage
            Me.schedulerControl1.Size = New System.Drawing.Size(607, 695)
            Me.schedulerControl1.Start = New System.DateTime(2008, 10, 20, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            AddHandler Me.schedulerControl1.Click, New System.EventHandler(AddressOf Me.schedulerControl1_Click)
            ' 
            ' schedulerStorage1
            ' 
            Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage1.Appointments.Mappings.[End] = "EndTime"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerStorage1.Appointments.Mappings.ResourceId = "CarId"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
            Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage1.Appointments.Mappings.Type = "EventType"
            Me.schedulerStorage1.Resources.Mappings.Caption = "Model"
            Me.schedulerStorage1.Resources.Mappings.Id = "ID"
            Me.schedulerStorage1.Resources.Mappings.Image = "Picture"
            AddHandler Me.schedulerStorage1.AppointmentsInserted, New DevExpress.XtraScheduler.PersistentObjectsEventHandler(AddressOf Me.schedulerStorage1_AppointmentsInserted)
            AddHandler Me.schedulerStorage1.AppointmentCollectionLoaded, New System.EventHandler(AddressOf Me.schedulerStorage1_AppointmentCollectionLoaded)
            AddHandler Me.schedulerStorage1.AppointmentCollectionCleared, New System.EventHandler(AddressOf Me.schedulerStorage1_AppointmentCollectionCleared)
            AddHandler Me.schedulerStorage1.AppointmentsDeleted, New DevExpress.XtraScheduler.PersistentObjectsEventHandler(AddressOf Me.schedulerStorage1_AppointmentsDeleted)
            ' 
            ' carsDBDataSet
            ' 
            Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
            Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' carSchedulingTableAdapter
            ' 
            Me.carSchedulingTableAdapter.ClearBeforeFill = True
            ' 
            ' carsTableAdapter
            ' 
            Me.carsTableAdapter.ClearBeforeFill = True
            ' 
            ' dataGridView1
            ' 
            Me.dataGridView1.AllowUserToAddRows = False
            Me.dataGridView1.AllowUserToDeleteRows = False
            Me.dataGridView1.AutoGenerateColumns = False
            Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.iDDataGridViewTextBoxColumn, Me.subjectDataGridViewTextBoxColumn, Me.startTimeDataGridViewTextBoxColumn, Me.endTimeDataGridViewTextBoxColumn, Me.eventTypeDataGridViewTextBoxColumn, Me.recurrenceInfoDataGridViewTextBoxColumn})
            Me.dataGridView1.DataMember = "CarScheduling"
            Me.dataGridView1.DataSource = Me.carsDBDataSet
            Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.dataGridView1.MultiSelect = False
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.[ReadOnly] = True
            Me.dataGridView1.RowTemplate.Height = 24
            Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dataGridView1.Size = New System.Drawing.Size(839, 695)
            Me.dataGridView1.TabIndex = 4
            Me.dataGridView1.VirtualMode = True
            AddHandler Me.dataGridView1.CellValueNeeded, New System.Windows.Forms.DataGridViewCellValueEventHandler(AddressOf Me.dataGridView1_CellValueNeeded)
            AddHandler Me.dataGridView1.CellFormatting, New System.Windows.Forms.DataGridViewCellFormattingEventHandler(AddressOf Me.dataGridView1_CellFormatting)
            AddHandler Me.dataGridView1.SelectionChanged, New System.EventHandler(AddressOf Me.dataGridView1_SelectionChanged)
            ' 
            ' splitContainer1
            ' 
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.splitContainer1.Name = "splitContainer1"
            ' 
            ' splitContainer1.Panel1
            ' 
            Me.splitContainer1.Panel1.Controls.Add(Me.dataGridView1)
            Me.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
            ' 
            ' splitContainer1.Panel2
            ' 
            Me.splitContainer1.Panel2.Controls.Add(Me.lbNoAppointment)
            Me.splitContainer1.Panel2.Controls.Add(Me.schedulerControl1)
            Me.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.splitContainer1.Size = New System.Drawing.Size(1450, 695)
            Me.splitContainer1.SplitterDistance = 839
            Me.splitContainer1.TabIndex = 5
            ' 
            ' lbNoAppointment
            ' 
            Me.lbNoAppointment.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.lbNoAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.lbNoAppointment.Location = New System.Drawing.Point(172, 205)
            Me.lbNoAppointment.Name = "lbNoAppointment"
            Me.lbNoAppointment.Size = New System.Drawing.Size(257, 271)
            Me.lbNoAppointment.TabIndex = 2
            Me.lbNoAppointment.Text = "Cannot display appointment for selected row"
            Me.lbNoAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lbNoAppointment.Visible = False
            AddHandler Me.lbNoAppointment.Click, New System.EventHandler(AddressOf Me.schedulerControl1_Click)
            ' 
            ' Number
            ' 
            Me.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.Number.HeaderText = "#"
            Me.Number.Name = "Number"
            Me.Number.[ReadOnly] = True
            Me.Number.Width = 41
            ' 
            ' iDDataGridViewTextBoxColumn
            ' 
            Me.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.iDDataGridViewTextBoxColumn.DataPropertyName = "ID"
            Me.iDDataGridViewTextBoxColumn.FillWeight = 33.50254F
            Me.iDDataGridViewTextBoxColumn.HeaderText = "ID"
            Me.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn"
            Me.iDDataGridViewTextBoxColumn.[ReadOnly] = True
            Me.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.iDDataGridViewTextBoxColumn.Width = 27
            ' 
            ' subjectDataGridViewTextBoxColumn
            ' 
            Me.subjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
            Me.subjectDataGridViewTextBoxColumn.FillWeight = 33.50254F
            Me.subjectDataGridViewTextBoxColumn.HeaderText = "Subject"
            Me.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn"
            Me.subjectDataGridViewTextBoxColumn.[ReadOnly] = True
            Me.subjectDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.subjectDataGridViewTextBoxColumn.Width = 61
            ' 
            ' startTimeDataGridViewTextBoxColumn
            ' 
            Me.startTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime"
            Me.startTimeDataGridViewTextBoxColumn.FillWeight = 33.50254F
            Me.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime"
            Me.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn"
            Me.startTimeDataGridViewTextBoxColumn.[ReadOnly] = True
            Me.startTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.startTimeDataGridViewTextBoxColumn.Width = 75
            ' 
            ' endTimeDataGridViewTextBoxColumn
            ' 
            Me.endTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime"
            Me.endTimeDataGridViewTextBoxColumn.FillWeight = 33.50254F
            Me.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime"
            Me.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn"
            Me.endTimeDataGridViewTextBoxColumn.[ReadOnly] = True
            Me.endTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.endTimeDataGridViewTextBoxColumn.Width = 70
            ' 
            ' eventTypeDataGridViewTextBoxColumn
            ' 
            Me.eventTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.eventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType"
            Me.eventTypeDataGridViewTextBoxColumn.FillWeight = 432.4873F
            Me.eventTypeDataGridViewTextBoxColumn.HeaderText = "EventType"
            Me.eventTypeDataGridViewTextBoxColumn.Name = "eventTypeDataGridViewTextBoxColumn"
            Me.eventTypeDataGridViewTextBoxColumn.[ReadOnly] = True
            Me.eventTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.eventTypeDataGridViewTextBoxColumn.Width = 82
            ' 
            ' recurrenceInfoDataGridViewTextBoxColumn
            ' 
            Me.recurrenceInfoDataGridViewTextBoxColumn.DataPropertyName = "RecurrenceInfo"
            Me.recurrenceInfoDataGridViewTextBoxColumn.FillWeight = 33.50254F
            Me.recurrenceInfoDataGridViewTextBoxColumn.HeaderText = "RecurrenceInfo"
            Me.recurrenceInfoDataGridViewTextBoxColumn.Name = "recurrenceInfoDataGridViewTextBoxColumn"
            Me.recurrenceInfoDataGridViewTextBoxColumn.[ReadOnly] = True
            Me.recurrenceInfoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1450, 695)
            Me.Controls.Add(Me.splitContainer1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Find appointment by row"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.carsDBDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private carsDBDataSet As SchedulerFindAptByRow.CarsDBDataSet

        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

        Private carSchedulingTableAdapter As SchedulerFindAptByRow.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter

        Private carsTableAdapter As SchedulerFindAptByRow.CarsDBDataSetTableAdapters.CarsTableAdapter

        Private dataGridView1 As System.Windows.Forms.DataGridView

        Private splitContainer1 As System.Windows.Forms.SplitContainer

        Private lbNoAppointment As System.Windows.Forms.Label

        Private Number As System.Windows.Forms.DataGridViewTextBoxColumn

        Private iDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

        Private subjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

        Private startTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

        Private endTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

        Private eventTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

        Private recurrenceInfoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace

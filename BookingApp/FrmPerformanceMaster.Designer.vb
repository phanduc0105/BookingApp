<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPerformanceMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Groupbox1 = New System.Windows.Forms.GroupBox()
        Me.DtpkStartTimeTo = New System.Windows.Forms.DateTimePicker()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DtpkStartTimeFrom = New System.Windows.Forms.DateTimePicker()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.DtViewData = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurationMinute = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountVip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountCouple = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountStandard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketsBooked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Choose = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Groupbox1.SuspendLayout()
        CType(Me.DtViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Groupbox1
        '
        Me.Groupbox1.Controls.Add(Me.Label3)
        Me.Groupbox1.Controls.Add(Me.DtpkStartTimeTo)
        Me.Groupbox1.Controls.Add(Me.Label2)
        Me.Groupbox1.Controls.Add(Me.BtnSearch)
        Me.Groupbox1.Controls.Add(Me.DtpkStartTimeFrom)
        Me.Groupbox1.Controls.Add(Me.TxtTitle)
        Me.Groupbox1.Controls.Add(Me.Label1)
        Me.Groupbox1.Location = New System.Drawing.Point(13, 13)
        Me.Groupbox1.Name = "Groupbox1"
        Me.Groupbox1.Size = New System.Drawing.Size(610, 101)
        Me.Groupbox1.TabIndex = 0
        Me.Groupbox1.TabStop = False
        '
        'DtpkStartTimeTo
        '
        Me.DtpkStartTimeTo.CustomFormat = "yyyy/MM/dd"
        Me.DtpkStartTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpkStartTimeTo.Location = New System.Drawing.Point(222, 53)
        Me.DtpkStartTimeTo.Name = "DtpkStartTimeTo"
        Me.DtpkStartTimeTo.Size = New System.Drawing.Size(96, 20)
        Me.DtpkStartTimeTo.TabIndex = 3
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSearch.Location = New System.Drawing.Point(514, 60)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(85, 30)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'DtpkStartTimeFrom
        '
        Me.DtpkStartTimeFrom.CustomFormat = "yyyy/MM/dd"
        Me.DtpkStartTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpkStartTimeFrom.Location = New System.Drawing.Point(93, 53)
        Me.DtpkStartTimeFrom.Name = "DtpkStartTimeFrom"
        Me.DtpkStartTimeFrom.Size = New System.Drawing.Size(96, 20)
        Me.DtpkStartTimeFrom.TabIndex = 2
        '
        'TxtTitle
        '
        Me.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTitle.Location = New System.Drawing.Point(93, 29)
        Me.TxtTitle.MaxLength = 100
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(376, 20)
        Me.TxtTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCreate.Location = New System.Drawing.Point(983, 12)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(85, 30)
        Me.BtnCreate.TabIndex = 1
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'DtViewData
        '
        Me.DtViewData.AllowUserToAddRows = False
        Me.DtViewData.AllowUserToDeleteRows = False
        Me.DtViewData.AllowUserToResizeRows = False
        Me.DtViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtViewData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Title, Me.StartTime, Me.DurationMinute, Me.AmountVip, Me.AmountCouple, Me.AmountStandard, Me.TicketsBooked, Me.CreatedDate, Me.Edit, Me.Choose})
        Me.DtViewData.Location = New System.Drawing.Point(12, 120)
        Me.DtViewData.Name = "DtViewData"
        Me.DtViewData.Size = New System.Drawing.Size(1056, 403)
        Me.DtViewData.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Start time"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "~"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Id.DefaultCellStyle = DataGridViewCellStyle28
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 50
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Title.DefaultCellStyle = DataGridViewCellStyle29
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Width = 250
        '
        'StartTime
        '
        Me.StartTime.DataPropertyName = "StartTime"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.StartTime.DefaultCellStyle = DataGridViewCellStyle30
        Me.StartTime.HeaderText = "Start Time"
        Me.StartTime.Name = "StartTime"
        Me.StartTime.ReadOnly = True
        '
        'DurationMinute
        '
        Me.DurationMinute.DataPropertyName = "DurationMinute"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "#,##0"
        Me.DurationMinute.DefaultCellStyle = DataGridViewCellStyle31
        Me.DurationMinute.HeaderText = "Duration (Minutes)"
        Me.DurationMinute.Name = "DurationMinute"
        Me.DurationMinute.ReadOnly = True
        '
        'AmountVip
        '
        Me.AmountVip.DataPropertyName = "AmountVip"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle32.Format = "#,##0"
        Me.AmountVip.DefaultCellStyle = DataGridViewCellStyle32
        Me.AmountVip.FillWeight = 120.0!
        Me.AmountVip.HeaderText = "Amount (Vip)"
        Me.AmountVip.Name = "AmountVip"
        Me.AmountVip.ReadOnly = True
        '
        'AmountCouple
        '
        Me.AmountCouple.DataPropertyName = "AmountCouple"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.Format = "#,##0"
        Me.AmountCouple.DefaultCellStyle = DataGridViewCellStyle33
        Me.AmountCouple.FillWeight = 120.0!
        Me.AmountCouple.HeaderText = "Amount (Couple)"
        Me.AmountCouple.Name = "AmountCouple"
        Me.AmountCouple.ReadOnly = True
        '
        'AmountStandard
        '
        Me.AmountStandard.DataPropertyName = "AmountStandard"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Format = "#,##0"
        Me.AmountStandard.DefaultCellStyle = DataGridViewCellStyle34
        Me.AmountStandard.FillWeight = 120.0!
        Me.AmountStandard.HeaderText = "Amount (Standard)"
        Me.AmountStandard.Name = "AmountStandard"
        Me.AmountStandard.ReadOnly = True
        '
        'TicketsBooked
        '
        Me.TicketsBooked.DataPropertyName = "TotalTicket"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TicketsBooked.DefaultCellStyle = DataGridViewCellStyle35
        Me.TicketsBooked.HeaderText = "Tickets Booked"
        Me.TicketsBooked.Name = "TicketsBooked"
        Me.TicketsBooked.ReadOnly = True
        Me.TicketsBooked.Width = 60
        '
        'CreatedDate
        '
        Me.CreatedDate.DataPropertyName = "CreatedDate"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CreatedDate.DefaultCellStyle = DataGridViewCellStyle36
        Me.CreatedDate.HeaderText = "Created Date"
        Me.CreatedDate.Name = "CreatedDate"
        Me.CreatedDate.ReadOnly = True
        '
        'Edit
        '
        Me.Edit.HeaderText = " "
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        Me.Edit.Width = 50
        '
        'Choose
        '
        Me.Choose.HeaderText = " "
        Me.Choose.Name = "Choose"
        Me.Choose.Text = "Choose"
        Me.Choose.UseColumnTextForButtonValue = True
        Me.Choose.Width = 50
        '
        'FrmPerformanceMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 535)
        Me.Controls.Add(Me.DtViewData)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.Groupbox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPerformanceMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Performance Master"
        Me.Groupbox1.ResumeLayout(False)
        Me.Groupbox1.PerformLayout()
        CType(Me.DtViewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Groupbox1 As GroupBox
    Friend WithEvents DtViewData As DataGridView
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpkStartTimeFrom As DateTimePicker
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents DtpkStartTimeTo As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents StartTime As DataGridViewTextBoxColumn
    Friend WithEvents DurationMinute As DataGridViewTextBoxColumn
    Friend WithEvents AmountVip As DataGridViewTextBoxColumn
    Friend WithEvents AmountCouple As DataGridViewTextBoxColumn
    Friend WithEvents AmountStandard As DataGridViewTextBoxColumn
    Friend WithEvents TicketsBooked As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDate As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Choose As DataGridViewButtonColumn
End Class

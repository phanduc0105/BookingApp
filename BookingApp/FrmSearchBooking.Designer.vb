<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearchBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Groupbox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtCustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPerformance = New System.Windows.Forms.Button()
        Me.NumPerformanceId = New System.Windows.Forms.NumericUpDown()
        Me.TxtPerformanceTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtViewData = New System.Windows.Forms.DataGridView()
        Me.PerformanceTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketVip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketCouple = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketStandard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Choose = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Groupbox1.SuspendLayout()
        CType(Me.NumPerformanceId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Groupbox1
        '
        Me.Groupbox1.Controls.Add(Me.BtnPerformance)
        Me.Groupbox1.Controls.Add(Me.NumPerformanceId)
        Me.Groupbox1.Controls.Add(Me.TxtPerformanceTitle)
        Me.Groupbox1.Controls.Add(Me.Label2)
        Me.Groupbox1.Controls.Add(Me.BtnSearch)
        Me.Groupbox1.Controls.Add(Me.TxtCustomer)
        Me.Groupbox1.Controls.Add(Me.Label1)
        Me.Groupbox1.Location = New System.Drawing.Point(12, 12)
        Me.Groupbox1.Name = "Groupbox1"
        Me.Groupbox1.Size = New System.Drawing.Size(610, 101)
        Me.Groupbox1.TabIndex = 1
        Me.Groupbox1.TabStop = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSearch.Location = New System.Drawing.Point(514, 60)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(85, 30)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TxtCustomer
        '
        Me.TxtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer.Location = New System.Drawing.Point(93, 48)
        Me.TxtCustomer.MaxLength = 100
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.Size = New System.Drawing.Size(376, 20)
        Me.TxtCustomer.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer"
        '
        'BtnPerformance
        '
        Me.BtnPerformance.Location = New System.Drawing.Point(167, 19)
        Me.BtnPerformance.Name = "BtnPerformance"
        Me.BtnPerformance.Size = New System.Drawing.Size(23, 23)
        Me.BtnPerformance.TabIndex = 2
        Me.BtnPerformance.TabStop = False
        Me.BtnPerformance.Text = "..."
        Me.BtnPerformance.UseVisualStyleBackColor = True
        '
        'NumPerformanceId
        '
        Me.NumPerformanceId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumPerformanceId.Location = New System.Drawing.Point(93, 19)
        Me.NumPerformanceId.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumPerformanceId.Name = "NumPerformanceId"
        Me.NumPerformanceId.Size = New System.Drawing.Size(71, 20)
        Me.NumPerformanceId.TabIndex = 1
        Me.NumPerformanceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPerformanceTitle
        '
        Me.TxtPerformanceTitle.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPerformanceTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPerformanceTitle.Location = New System.Drawing.Point(193, 19)
        Me.TxtPerformanceTitle.Name = "TxtPerformanceTitle"
        Me.TxtPerformanceTitle.Size = New System.Drawing.Size(376, 20)
        Me.TxtPerformanceTitle.TabIndex = 3
        Me.TxtPerformanceTitle.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Performance"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DtViewData
        '
        Me.DtViewData.AllowUserToAddRows = False
        Me.DtViewData.AllowUserToDeleteRows = False
        Me.DtViewData.AllowUserToResizeRows = False
        Me.DtViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtViewData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PerformanceTitle, Me.Customer, Me.TicketVip, Me.TicketCouple, Me.TicketStandard, Me.TotalTicket, Me.TicketCount, Me.Choose, Me.Id})
        Me.DtViewData.Location = New System.Drawing.Point(12, 120)
        Me.DtViewData.Name = "DtViewData"
        Me.DtViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DtViewData.Size = New System.Drawing.Size(795, 428)
        Me.DtViewData.TabIndex = 2
        '
        'PerformanceTitle
        '
        Me.PerformanceTitle.DataPropertyName = "PerformanceTitle"
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.PerformanceTitle.DefaultCellStyle = DataGridViewCellStyle43
        Me.PerformanceTitle.HeaderText = "PerformanceTitle"
        Me.PerformanceTitle.Name = "PerformanceTitle"
        Me.PerformanceTitle.ReadOnly = True
        Me.PerformanceTitle.Width = 200
        '
        'Customer
        '
        Me.Customer.DataPropertyName = "Customer"
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Customer.DefaultCellStyle = DataGridViewCellStyle44
        Me.Customer.HeaderText = "Customer"
        Me.Customer.Name = "Customer"
        Me.Customer.ReadOnly = True
        Me.Customer.Width = 200
        '
        'TicketVip
        '
        Me.TicketVip.DataPropertyName = "TicketVip"
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TicketVip.DefaultCellStyle = DataGridViewCellStyle45
        Me.TicketVip.HeaderText = "Ticket VIP"
        Me.TicketVip.Name = "TicketVip"
        Me.TicketVip.ReadOnly = True
        Me.TicketVip.Width = 60
        '
        'TicketCouple
        '
        Me.TicketCouple.DataPropertyName = "TicketCouple"
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TicketCouple.DefaultCellStyle = DataGridViewCellStyle46
        Me.TicketCouple.HeaderText = "Ticket Couple"
        Me.TicketCouple.Name = "TicketCouple"
        Me.TicketCouple.ReadOnly = True
        Me.TicketCouple.Width = 60
        '
        'TicketStandard
        '
        Me.TicketStandard.DataPropertyName = "TicketStandard"
        DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TicketStandard.DefaultCellStyle = DataGridViewCellStyle47
        Me.TicketStandard.HeaderText = "Ticket Standard"
        Me.TicketStandard.Name = "TicketStandard"
        Me.TicketStandard.ReadOnly = True
        Me.TicketStandard.Width = 60
        '
        'TotalTicket
        '
        Me.TotalTicket.DataPropertyName = "TotalTicket"
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TotalTicket.DefaultCellStyle = DataGridViewCellStyle48
        Me.TotalTicket.HeaderText = "Total Ticket"
        Me.TotalTicket.Name = "TotalTicket"
        Me.TotalTicket.ReadOnly = True
        Me.TotalTicket.Width = 60
        '
        'TicketCount
        '
        Me.TicketCount.DataPropertyName = "TicketCount"
        DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TicketCount.DefaultCellStyle = DataGridViewCellStyle49
        Me.TicketCount.HeaderText = "Ticket Assigned"
        Me.TicketCount.Name = "TicketCount"
        Me.TicketCount.ReadOnly = True
        Me.TicketCount.Width = 60
        '
        'Choose
        '
        Me.Choose.HeaderText = " "
        Me.Choose.Name = "Choose"
        Me.Choose.Text = "Choose"
        Me.Choose.UseColumnTextForButtonValue = True
        Me.Choose.Width = 50
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = ""
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'FrmSearchBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 562)
        Me.Controls.Add(Me.DtViewData)
        Me.Controls.Add(Me.Groupbox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(836, 601)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(836, 601)
        Me.Name = "FrmSearchBooking"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Booking"
        Me.Groupbox1.ResumeLayout(False)
        Me.Groupbox1.PerformLayout()
        CType(Me.NumPerformanceId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtViewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Groupbox1 As GroupBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPerformance As Button
    Friend WithEvents NumPerformanceId As NumericUpDown
    Friend WithEvents TxtPerformanceTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtViewData As DataGridView
    Friend WithEvents PerformanceTitle As DataGridViewTextBoxColumn
    Friend WithEvents Customer As DataGridViewTextBoxColumn
    Friend WithEvents TicketVip As DataGridViewTextBoxColumn
    Friend WithEvents TicketCouple As DataGridViewTextBoxColumn
    Friend WithEvents TicketStandard As DataGridViewTextBoxColumn
    Friend WithEvents TotalTicket As DataGridViewTextBoxColumn
    Friend WithEvents TicketCount As DataGridViewTextBoxColumn
    Friend WithEvents Choose As DataGridViewButtonColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBooking
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
        Me.TxtPerformanceTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumPerformanceId = New System.Windows.Forms.NumericUpDown()
        Me.BtnPerformance = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumVIPSeat = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelVipTicketPrice = New System.Windows.Forms.Label()
        Me.GroupBoxVIP = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelVipTicketAmount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelVipTicketLeft = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBoxCouple = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelCoupleTicketAmount = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelCoupleTicketLeft = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelCoupleTicketPrice = New System.Windows.Forms.Label()
        Me.NumCoupleSeat = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBoxStandard = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelStandardTicketAmount = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LabelStandardTicketLeft = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LabelStandardTicketPrice = New System.Windows.Forms.Label()
        Me.NumStandardSeat = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LabelTotalAmount = New System.Windows.Forms.Label()
        CType(Me.NumPerformanceId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumVIPSeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVIP.SuspendLayout()
        Me.GroupBoxCouple.SuspendLayout()
        CType(Me.NumCoupleSeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxStandard.SuspendLayout()
        CType(Me.NumStandardSeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPerformanceTitle
        '
        Me.TxtPerformanceTitle.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPerformanceTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPerformanceTitle.Location = New System.Drawing.Point(198, 12)
        Me.TxtPerformanceTitle.Name = "TxtPerformanceTitle"
        Me.TxtPerformanceTitle.ReadOnly = True
        Me.TxtPerformanceTitle.Size = New System.Drawing.Size(376, 20)
        Me.TxtPerformanceTitle.TabIndex = 3
        Me.TxtPerformanceTitle.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Performance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumPerformanceId
        '
        Me.NumPerformanceId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumPerformanceId.Location = New System.Drawing.Point(98, 12)
        Me.NumPerformanceId.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumPerformanceId.Name = "NumPerformanceId"
        Me.NumPerformanceId.Size = New System.Drawing.Size(71, 20)
        Me.NumPerformanceId.TabIndex = 1
        Me.NumPerformanceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnPerformance
        '
        Me.BtnPerformance.Location = New System.Drawing.Point(172, 12)
        Me.BtnPerformance.Name = "BtnPerformance"
        Me.BtnPerformance.Size = New System.Drawing.Size(23, 23)
        Me.BtnPerformance.TabIndex = 2
        Me.BtnPerformance.TabStop = False
        Me.BtnPerformance.Text = "..."
        Me.BtnPerformance.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Customer"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Location = New System.Drawing.Point(98, 41)
        Me.TxtCustomerName.MaxLength = 100
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(376, 20)
        Me.TxtCustomerName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Number of tickets"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumVIPSeat
        '
        Me.NumVIPSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumVIPSeat.Location = New System.Drawing.Point(113, 16)
        Me.NumVIPSeat.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumVIPSeat.Name = "NumVIPSeat"
        Me.NumVIPSeat.Size = New System.Drawing.Size(71, 20)
        Me.NumVIPSeat.TabIndex = 5
        Me.NumVIPSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ticket price:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVipTicketPrice
        '
        Me.LabelVipTicketPrice.Location = New System.Drawing.Point(78, 39)
        Me.LabelVipTicketPrice.Name = "LabelVipTicketPrice"
        Me.LabelVipTicketPrice.Size = New System.Drawing.Size(106, 20)
        Me.LabelVipTicketPrice.TabIndex = 11
        Me.LabelVipTicketPrice.Text = "1,000,000"
        Me.LabelVipTicketPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBoxVIP
        '
        Me.GroupBoxVIP.Controls.Add(Me.Label5)
        Me.GroupBoxVIP.Controls.Add(Me.LabelVipTicketAmount)
        Me.GroupBoxVIP.Controls.Add(Me.Label9)
        Me.GroupBoxVIP.Controls.Add(Me.LabelVipTicketLeft)
        Me.GroupBoxVIP.Controls.Add(Me.Label7)
        Me.GroupBoxVIP.Controls.Add(Me.Label3)
        Me.GroupBoxVIP.Controls.Add(Me.LabelVipTicketPrice)
        Me.GroupBoxVIP.Controls.Add(Me.NumVIPSeat)
        Me.GroupBoxVIP.Controls.Add(Me.Label4)
        Me.GroupBoxVIP.Location = New System.Drawing.Point(15, 76)
        Me.GroupBoxVIP.Name = "GroupBoxVIP"
        Me.GroupBoxVIP.Size = New System.Drawing.Size(559, 87)
        Me.GroupBoxVIP.TabIndex = 12
        Me.GroupBoxVIP.TabStop = False
        Me.GroupBoxVIP.Text = "VIP Seat"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(296, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "/20"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVipTicketAmount
        '
        Me.LabelVipTicketAmount.Location = New System.Drawing.Point(78, 59)
        Me.LabelVipTicketAmount.Name = "LabelVipTicketAmount"
        Me.LabelVipTicketAmount.Size = New System.Drawing.Size(106, 20)
        Me.LabelVipTicketAmount.TabIndex = 15
        Me.LabelVipTicketAmount.Text = "1,000,000"
        Me.LabelVipTicketAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Amount:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVipTicketLeft
        '
        Me.LabelVipTicketLeft.Location = New System.Drawing.Point(259, 16)
        Me.LabelVipTicketLeft.Name = "LabelVipTicketLeft"
        Me.LabelVipTicketLeft.Size = New System.Drawing.Size(38, 20)
        Me.LabelVipTicketLeft.TabIndex = 13
        Me.LabelVipTicketLeft.Text = "100"
        Me.LabelVipTicketLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(191, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tickets left:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxCouple
        '
        Me.GroupBoxCouple.Controls.Add(Me.Label6)
        Me.GroupBoxCouple.Controls.Add(Me.LabelCoupleTicketAmount)
        Me.GroupBoxCouple.Controls.Add(Me.Label11)
        Me.GroupBoxCouple.Controls.Add(Me.LabelCoupleTicketLeft)
        Me.GroupBoxCouple.Controls.Add(Me.Label13)
        Me.GroupBoxCouple.Controls.Add(Me.Label14)
        Me.GroupBoxCouple.Controls.Add(Me.LabelCoupleTicketPrice)
        Me.GroupBoxCouple.Controls.Add(Me.NumCoupleSeat)
        Me.GroupBoxCouple.Controls.Add(Me.Label16)
        Me.GroupBoxCouple.Location = New System.Drawing.Point(15, 169)
        Me.GroupBoxCouple.Name = "GroupBoxCouple"
        Me.GroupBoxCouple.Size = New System.Drawing.Size(559, 87)
        Me.GroupBoxCouple.TabIndex = 13
        Me.GroupBoxCouple.TabStop = False
        Me.GroupBoxCouple.Text = "Couple Seat"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(296, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "/20"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCoupleTicketAmount
        '
        Me.LabelCoupleTicketAmount.Location = New System.Drawing.Point(78, 59)
        Me.LabelCoupleTicketAmount.Name = "LabelCoupleTicketAmount"
        Me.LabelCoupleTicketAmount.Size = New System.Drawing.Size(106, 20)
        Me.LabelCoupleTicketAmount.TabIndex = 15
        Me.LabelCoupleTicketAmount.Text = "1,000,000"
        Me.LabelCoupleTicketAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Amount:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCoupleTicketLeft
        '
        Me.LabelCoupleTicketLeft.Location = New System.Drawing.Point(259, 16)
        Me.LabelCoupleTicketLeft.Name = "LabelCoupleTicketLeft"
        Me.LabelCoupleTicketLeft.Size = New System.Drawing.Size(38, 20)
        Me.LabelCoupleTicketLeft.TabIndex = 13
        Me.LabelCoupleTicketLeft.Text = "100"
        Me.LabelCoupleTicketLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(191, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Tickets left:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(6, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Number of tickets"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCoupleTicketPrice
        '
        Me.LabelCoupleTicketPrice.Location = New System.Drawing.Point(78, 39)
        Me.LabelCoupleTicketPrice.Name = "LabelCoupleTicketPrice"
        Me.LabelCoupleTicketPrice.Size = New System.Drawing.Size(106, 20)
        Me.LabelCoupleTicketPrice.TabIndex = 11
        Me.LabelCoupleTicketPrice.Text = "1,000,000"
        Me.LabelCoupleTicketPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumCoupleSeat
        '
        Me.NumCoupleSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumCoupleSeat.Location = New System.Drawing.Point(113, 16)
        Me.NumCoupleSeat.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumCoupleSeat.Name = "NumCoupleSeat"
        Me.NumCoupleSeat.Size = New System.Drawing.Size(71, 20)
        Me.NumCoupleSeat.TabIndex = 6
        Me.NumCoupleSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(6, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 20)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Ticket price:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxStandard
        '
        Me.GroupBoxStandard.Controls.Add(Me.Label8)
        Me.GroupBoxStandard.Controls.Add(Me.LabelStandardTicketAmount)
        Me.GroupBoxStandard.Controls.Add(Me.Label18)
        Me.GroupBoxStandard.Controls.Add(Me.LabelStandardTicketLeft)
        Me.GroupBoxStandard.Controls.Add(Me.Label20)
        Me.GroupBoxStandard.Controls.Add(Me.Label21)
        Me.GroupBoxStandard.Controls.Add(Me.LabelStandardTicketPrice)
        Me.GroupBoxStandard.Controls.Add(Me.NumStandardSeat)
        Me.GroupBoxStandard.Controls.Add(Me.Label23)
        Me.GroupBoxStandard.Location = New System.Drawing.Point(15, 262)
        Me.GroupBoxStandard.Name = "GroupBoxStandard"
        Me.GroupBoxStandard.Size = New System.Drawing.Size(559, 87)
        Me.GroupBoxStandard.TabIndex = 14
        Me.GroupBoxStandard.TabStop = False
        Me.GroupBoxStandard.Text = "Standard Seat"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(296, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "/60"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelStandardTicketAmount
        '
        Me.LabelStandardTicketAmount.Location = New System.Drawing.Point(78, 59)
        Me.LabelStandardTicketAmount.Name = "LabelStandardTicketAmount"
        Me.LabelStandardTicketAmount.Size = New System.Drawing.Size(106, 20)
        Me.LabelStandardTicketAmount.TabIndex = 15
        Me.LabelStandardTicketAmount.Text = "1,000,000"
        Me.LabelStandardTicketAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 20)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Amount:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelStandardTicketLeft
        '
        Me.LabelStandardTicketLeft.Location = New System.Drawing.Point(259, 16)
        Me.LabelStandardTicketLeft.Name = "LabelStandardTicketLeft"
        Me.LabelStandardTicketLeft.Size = New System.Drawing.Size(38, 20)
        Me.LabelStandardTicketLeft.TabIndex = 13
        Me.LabelStandardTicketLeft.Text = "100"
        Me.LabelStandardTicketLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(191, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 20)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Tickets left:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(6, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 20)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Number of tickets"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelStandardTicketPrice
        '
        Me.LabelStandardTicketPrice.Location = New System.Drawing.Point(78, 39)
        Me.LabelStandardTicketPrice.Name = "LabelStandardTicketPrice"
        Me.LabelStandardTicketPrice.Size = New System.Drawing.Size(106, 20)
        Me.LabelStandardTicketPrice.TabIndex = 11
        Me.LabelStandardTicketPrice.Text = "1,000,000"
        Me.LabelStandardTicketPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumStandardSeat
        '
        Me.NumStandardSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumStandardSeat.Location = New System.Drawing.Point(113, 16)
        Me.NumStandardSeat.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumStandardSeat.Name = "NumStandardSeat"
        Me.NumStandardSeat.Size = New System.Drawing.Size(71, 20)
        Me.NumStandardSeat.TabIndex = 7
        Me.NumStandardSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(6, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 20)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Ticket price:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 352)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 20)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Total Amount:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSave.Location = New System.Drawing.Point(489, 395)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 30)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "Booking"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'LabelTotalAmount
        '
        Me.LabelTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalAmount.Location = New System.Drawing.Point(128, 352)
        Me.LabelTotalAmount.Name = "LabelTotalAmount"
        Me.LabelTotalAmount.Size = New System.Drawing.Size(446, 20)
        Me.LabelTotalAmount.TabIndex = 18
        Me.LabelTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 442)
        Me.Controls.Add(Me.LabelTotalAmount)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.GroupBoxStandard)
        Me.Controls.Add(Me.GroupBoxCouple)
        Me.Controls.Add(Me.GroupBoxVIP)
        Me.Controls.Add(Me.TxtCustomerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnPerformance)
        Me.Controls.Add(Me.NumPerformanceId)
        Me.Controls.Add(Me.TxtPerformanceTitle)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        CType(Me.NumPerformanceId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumVIPSeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVIP.ResumeLayout(False)
        Me.GroupBoxCouple.ResumeLayout(False)
        CType(Me.NumCoupleSeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxStandard.ResumeLayout(False)
        CType(Me.NumStandardSeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPerformanceTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumPerformanceId As NumericUpDown
    Friend WithEvents BtnPerformance As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumVIPSeat As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelVipTicketPrice As Label
    Friend WithEvents GroupBoxVIP As GroupBox
    Friend WithEvents LabelVipTicketAmount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelVipTicketLeft As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBoxCouple As GroupBox
    Friend WithEvents LabelCoupleTicketAmount As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelCoupleTicketLeft As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LabelCoupleTicketPrice As Label
    Friend WithEvents NumCoupleSeat As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBoxStandard As GroupBox
    Friend WithEvents LabelStandardTicketAmount As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LabelStandardTicketLeft As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LabelStandardTicketPrice As Label
    Friend WithEvents NumStandardSeat As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents LabelTotalAmount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class

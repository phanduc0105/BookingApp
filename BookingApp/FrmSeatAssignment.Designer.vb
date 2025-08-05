<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSeatAssignment
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
        Me.BtnBooking = New System.Windows.Forms.Button()
        Me.NumBookingId = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelDuration = New System.Windows.Forms.Label()
        Me.LabelStartTime = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelCustomer = New System.Windows.Forms.Label()
        Me.LabelTicketStandard = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelTicketCouple = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelTicketVip = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBoxStandard = New System.Windows.Forms.GroupBox()
        Me.PanelStandard = New System.Windows.Forms.Panel()
        Me.GroupBoxVip = New System.Windows.Forms.GroupBox()
        Me.PanelVip = New System.Windows.Forms.Panel()
        Me.GroupBoxCouple = New System.Windows.Forms.GroupBox()
        Me.PanelCouple = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.NumPerformanceId = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumBookingId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxStandard.SuspendLayout()
        Me.GroupBoxVip.SuspendLayout()
        Me.GroupBoxCouple.SuspendLayout()
        CType(Me.NumPerformanceId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBooking
        '
        Me.BtnBooking.Location = New System.Drawing.Point(169, 12)
        Me.BtnBooking.Name = "BtnBooking"
        Me.BtnBooking.Size = New System.Drawing.Size(23, 23)
        Me.BtnBooking.TabIndex = 2
        Me.BtnBooking.TabStop = False
        Me.BtnBooking.Text = "..."
        Me.BtnBooking.UseVisualStyleBackColor = True
        '
        'NumBookingId
        '
        Me.NumBookingId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumBookingId.Location = New System.Drawing.Point(95, 12)
        Me.NumBookingId.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumBookingId.Name = "NumBookingId"
        Me.NumBookingId.Size = New System.Drawing.Size(71, 20)
        Me.NumBookingId.TabIndex = 1
        Me.NumBookingId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Booking"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelDuration)
        Me.GroupBox1.Controls.Add(Me.LabelStartTime)
        Me.GroupBox1.Controls.Add(Me.LabelTitle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 85)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Performance information"
        '
        'LabelDuration
        '
        Me.LabelDuration.Location = New System.Drawing.Point(83, 56)
        Me.LabelDuration.Name = "LabelDuration"
        Me.LabelDuration.Size = New System.Drawing.Size(411, 20)
        Me.LabelDuration.TabIndex = 17
        Me.LabelDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelStartTime
        '
        Me.LabelStartTime.Location = New System.Drawing.Point(83, 36)
        Me.LabelStartTime.Name = "LabelStartTime"
        Me.LabelStartTime.Size = New System.Drawing.Size(411, 20)
        Me.LabelStartTime.TabIndex = 16
        Me.LabelStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTitle
        '
        Me.LabelTitle.Location = New System.Drawing.Point(83, 16)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(411, 20)
        Me.LabelTitle.TabIndex = 15
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Duration:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Start time:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Title:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelCustomer)
        Me.GroupBox2.Controls.Add(Me.LabelTicketStandard)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LabelTicketCouple)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LabelTicketVip)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(532, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 85)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booked ticket information"
        '
        'LabelCustomer
        '
        Me.LabelCustomer.Location = New System.Drawing.Point(83, 16)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.Size = New System.Drawing.Size(306, 20)
        Me.LabelCustomer.TabIndex = 20
        Me.LabelCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTicketStandard
        '
        Me.LabelTicketStandard.Location = New System.Drawing.Point(311, 36)
        Me.LabelTicketStandard.Name = "LabelTicketStandard"
        Me.LabelTicketStandard.Size = New System.Drawing.Size(40, 20)
        Me.LabelTicketStandard.TabIndex = 19
        Me.LabelTicketStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(239, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "- Standard:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTicketCouple
        '
        Me.LabelTicketCouple.Location = New System.Drawing.Point(193, 36)
        Me.LabelTicketCouple.Name = "LabelTicketCouple"
        Me.LabelTicketCouple.Size = New System.Drawing.Size(40, 20)
        Me.LabelTicketCouple.TabIndex = 17
        Me.LabelTicketCouple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(129, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "- Couple:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTicketVip
        '
        Me.LabelTicketVip.Location = New System.Drawing.Point(83, 36)
        Me.LabelTicketVip.Name = "LabelTicketVip"
        Me.LabelTicketVip.Size = New System.Drawing.Size(40, 20)
        Me.LabelTicketVip.TabIndex = 15
        Me.LabelTicketVip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ticket Vip:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Customer:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Seat map"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxStandard
        '
        Me.GroupBoxStandard.Controls.Add(Me.PanelStandard)
        Me.GroupBoxStandard.Location = New System.Drawing.Point(12, 380)
        Me.GroupBoxStandard.Name = "GroupBoxStandard"
        Me.GroupBoxStandard.Size = New System.Drawing.Size(915, 240)
        Me.GroupBoxStandard.TabIndex = 18
        Me.GroupBoxStandard.TabStop = False
        Me.GroupBoxStandard.Text = "Standard (0/60)"
        '
        'PanelStandard
        '
        Me.PanelStandard.Location = New System.Drawing.Point(9, 20)
        Me.PanelStandard.Name = "PanelStandard"
        Me.PanelStandard.Size = New System.Drawing.Size(900, 205)
        Me.PanelStandard.TabIndex = 0
        Me.PanelStandard.Tag = "Standard"
        '
        'GroupBoxVip
        '
        Me.GroupBoxVip.Controls.Add(Me.PanelVip)
        Me.GroupBoxVip.Location = New System.Drawing.Point(12, 162)
        Me.GroupBoxVip.Name = "GroupBoxVip"
        Me.GroupBoxVip.Size = New System.Drawing.Size(915, 103)
        Me.GroupBoxVip.TabIndex = 16
        Me.GroupBoxVip.TabStop = False
        Me.GroupBoxVip.Text = "Vip (0/20)"
        '
        'PanelVip
        '
        Me.PanelVip.Location = New System.Drawing.Point(9, 20)
        Me.PanelVip.Name = "PanelVip"
        Me.PanelVip.Size = New System.Drawing.Size(900, 77)
        Me.PanelVip.TabIndex = 0
        Me.PanelVip.Tag = "Vip"
        '
        'GroupBoxCouple
        '
        Me.GroupBoxCouple.Controls.Add(Me.PanelCouple)
        Me.GroupBoxCouple.Location = New System.Drawing.Point(12, 271)
        Me.GroupBoxCouple.Name = "GroupBoxCouple"
        Me.GroupBoxCouple.Size = New System.Drawing.Size(915, 103)
        Me.GroupBoxCouple.TabIndex = 17
        Me.GroupBoxCouple.TabStop = False
        Me.GroupBoxCouple.Text = "Couple (0/20)"
        '
        'PanelCouple
        '
        Me.PanelCouple.Location = New System.Drawing.Point(9, 20)
        Me.PanelCouple.Name = "PanelCouple"
        Me.PanelCouple.Size = New System.Drawing.Size(900, 77)
        Me.PanelCouple.TabIndex = 0
        Me.PanelCouple.Tag = "Couple"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSave.Location = New System.Drawing.Point(843, 626)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 30)
        Me.BtnSave.TabIndex = 19
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'NumPerformanceId
        '
        Me.NumPerformanceId.Location = New System.Drawing.Point(198, 12)
        Me.NumPerformanceId.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumPerformanceId.Name = "NumPerformanceId"
        Me.NumPerformanceId.Size = New System.Drawing.Size(71, 20)
        Me.NumPerformanceId.TabIndex = 20
        Me.NumPerformanceId.Visible = False
        '
        'FrmSeatAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 671)
        Me.Controls.Add(Me.NumPerformanceId)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBoxStandard)
        Me.Controls.Add(Me.GroupBoxVip)
        Me.Controls.Add(Me.GroupBoxCouple)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBooking)
        Me.Controls.Add(Me.NumBookingId)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(956, 710)
        Me.MinimumSize = New System.Drawing.Size(956, 710)
        Me.Name = "FrmSeatAssignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seat Assignment"
        CType(Me.NumBookingId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBoxStandard.ResumeLayout(False)
        Me.GroupBoxVip.ResumeLayout(False)
        Me.GroupBoxCouple.ResumeLayout(False)
        CType(Me.NumPerformanceId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBooking As Button
    Friend WithEvents NumBookingId As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBoxStandard As GroupBox
    Friend WithEvents PanelStandard As Panel
    Friend WithEvents GroupBoxVip As GroupBox
    Friend WithEvents PanelVip As Panel
    Friend WithEvents GroupBoxCouple As GroupBox
    Friend WithEvents PanelCouple As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents NumPerformanceId As NumericUpDown
    Friend WithEvents LabelDuration As Label
    Friend WithEvents LabelStartTime As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelTicketStandard As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelTicketCouple As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelTicketVip As Label
    Friend WithEvents LabelCustomer As Label
End Class

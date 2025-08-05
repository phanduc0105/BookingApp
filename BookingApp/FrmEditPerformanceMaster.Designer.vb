<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditPerformanceMaster
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
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpkStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumAmountVip = New System.Windows.Forms.NumericUpDown()
        Me.NumDuration = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumAmountCouple = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumAmountStandard = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.NumAmountVip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAmountCouple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAmountStandard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTitle
        '
        Me.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTitle.Location = New System.Drawing.Point(124, 12)
        Me.TxtTitle.MaxLength = 100
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(376, 20)
        Me.TxtTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Start time"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DtpkStartDate
        '
        Me.DtpkStartDate.CustomFormat = "yyyy/MM/dd - HH:mm"
        Me.DtpkStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpkStartDate.Location = New System.Drawing.Point(124, 38)
        Me.DtpkStartDate.Name = "DtpkStartDate"
        Me.DtpkStartDate.Size = New System.Drawing.Size(135, 20)
        Me.DtpkStartDate.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Amount (Vip)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumAmountVip
        '
        Me.NumAmountVip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumAmountVip.Location = New System.Drawing.Point(124, 90)
        Me.NumAmountVip.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NumAmountVip.Name = "NumAmountVip"
        Me.NumAmountVip.Size = New System.Drawing.Size(135, 20)
        Me.NumAmountVip.TabIndex = 4
        Me.NumAmountVip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumDuration
        '
        Me.NumDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumDuration.Location = New System.Drawing.Point(124, 64)
        Me.NumDuration.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumDuration.Name = "NumDuration"
        Me.NumDuration.Size = New System.Drawing.Size(71, 20)
        Me.NumDuration.TabIndex = 3
        Me.NumDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Duration"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumAmountCouple
        '
        Me.NumAmountCouple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumAmountCouple.Location = New System.Drawing.Point(124, 117)
        Me.NumAmountCouple.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NumAmountCouple.Name = "NumAmountCouple"
        Me.NumAmountCouple.Size = New System.Drawing.Size(135, 20)
        Me.NumAmountCouple.TabIndex = 5
        Me.NumAmountCouple.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Amount (Couple)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumAmountStandard
        '
        Me.NumAmountStandard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumAmountStandard.Location = New System.Drawing.Point(124, 143)
        Me.NumAmountStandard.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NumAmountStandard.Name = "NumAmountStandard"
        Me.NumAmountStandard.Size = New System.Drawing.Size(135, 20)
        Me.NumAmountStandard.TabIndex = 6
        Me.NumAmountStandard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Amount (Standard)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSave.Location = New System.Drawing.Point(415, 190)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 30)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnDel
        '
        Me.BtnDel.BackColor = System.Drawing.Color.Salmon
        Me.BtnDel.Location = New System.Drawing.Point(324, 190)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(85, 30)
        Me.BtnDel.TabIndex = 7
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(201, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Minutes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmEditPerformanceMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 232)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.NumAmountStandard)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumAmountCouple)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumDuration)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumAmountVip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpkStartDate)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(503, 271)
        Me.Name = "FrmEditPerformanceMaster"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Permance Master"
        CType(Me.NumAmountVip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAmountCouple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAmountStandard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpkStartDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents NumAmountVip As NumericUpDown
    Friend WithEvents NumDuration As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumAmountCouple As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumAmountStandard As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents Label7 As Label
End Class

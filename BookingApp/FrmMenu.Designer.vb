<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.BtnPerformanceMaster = New System.Windows.Forms.Button()
        Me.BtnBooking = New System.Windows.Forms.Button()
        Me.BtnSeatAssignment = New System.Windows.Forms.Button()
        Me.BtnViewSeatAssignment = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPerformanceMaster
        '
        Me.BtnPerformanceMaster.Location = New System.Drawing.Point(36, 39)
        Me.BtnPerformanceMaster.Name = "BtnPerformanceMaster"
        Me.BtnPerformanceMaster.Size = New System.Drawing.Size(98, 68)
        Me.BtnPerformanceMaster.TabIndex = 0
        Me.BtnPerformanceMaster.Text = "Performance Master"
        Me.BtnPerformanceMaster.UseVisualStyleBackColor = True
        '
        'BtnBooking
        '
        Me.BtnBooking.Location = New System.Drawing.Point(140, 39)
        Me.BtnBooking.Name = "BtnBooking"
        Me.BtnBooking.Size = New System.Drawing.Size(98, 68)
        Me.BtnBooking.TabIndex = 1
        Me.BtnBooking.Text = "Booking"
        Me.BtnBooking.UseVisualStyleBackColor = True
        '
        'BtnSeatAssignment
        '
        Me.BtnSeatAssignment.Location = New System.Drawing.Point(241, 39)
        Me.BtnSeatAssignment.Name = "BtnSeatAssignment"
        Me.BtnSeatAssignment.Size = New System.Drawing.Size(98, 68)
        Me.BtnSeatAssignment.TabIndex = 2
        Me.BtnSeatAssignment.Text = "Seat Assignment"
        Me.BtnSeatAssignment.UseVisualStyleBackColor = True
        '
        'BtnViewSeatAssignment
        '
        Me.BtnViewSeatAssignment.Location = New System.Drawing.Point(345, 39)
        Me.BtnViewSeatAssignment.Name = "BtnViewSeatAssignment"
        Me.BtnViewSeatAssignment.Size = New System.Drawing.Size(98, 68)
        Me.BtnViewSeatAssignment.TabIndex = 3
        Me.BtnViewSeatAssignment.Text = "View Seat Assignment By Performance"
        Me.BtnViewSeatAssignment.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 155)
        Me.Controls.Add(Me.BtnViewSeatAssignment)
        Me.Controls.Add(Me.BtnSeatAssignment)
        Me.Controls.Add(Me.BtnBooking)
        Me.Controls.Add(Me.BtnPerformanceMaster)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPerformanceMaster As Button
    Friend WithEvents BtnBooking As Button
    Friend WithEvents BtnSeatAssignment As Button
    Friend WithEvents BtnViewSeatAssignment As Button
End Class

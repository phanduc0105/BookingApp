Imports BookingApp.Constant

Public Class FrmMenu
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnPerformanceMaster_Click(sender As Object, e As EventArgs) Handles BtnPerformanceMaster.Click
        Dim frm As New FrmPerformanceMaster(ScreenMode.Normal)
        frm.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnBooking_Click(sender As Object, e As EventArgs) Handles BtnBooking.Click
        Dim frm As New FrmBooking
        frm.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSeatAssignment_Click(sender As Object, e As EventArgs) Handles BtnSeatAssignment.Click
        Dim frm As New FrmSeatAssignment
        frm.Show()
    End Sub

    Private Sub BtnViewSeatAssignment_Click(sender As Object, e As EventArgs) Handles BtnViewSeatAssignment.Click
        Dim frm As New FrmViewSeatAssignment
        frm.Show()
    End Sub
End Class
Imports System.Text
Imports BookingApp.Constant

Public Class FrmSearchBooking

    Public BookingId As Integer

    ''' <summary>
    ''' Form load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmSearchBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericHelper.ProtectEmptyValue(NumPerformanceId)

        GetData()
    End Sub

    ''' <summary>
    ''' Button search Performance click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnPerformance_Click(sender As Object, e As EventArgs) Handles BtnPerformance.Click
        Dim frm As New FrmPerformanceMaster(ScreenMode.Search)
        If frm.ShowDialog = DialogResult.OK Then
            NumPerformanceId.Value = frm.PerformanceId
        End If
    End Sub

    ''' <summary>
    ''' Performance ValueChanged event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NumPerformanceId_ValueChanged(sender As Object, e As EventArgs) Handles NumPerformanceId.ValueChanged
        GetPerformanceTitle()
    End Sub

    ''' <summary>
    ''' Get title for Performance
    ''' </summary>
    Private Sub GetPerformanceTitle()
        Dim db As New DbContext()

        Dim query As String = "
            SELECT 
                title
            FROM performances 
            WHERE performance_id = @performance_id
        "

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", NumPerformanceId.Value}
        }

        Dim dt As DataTable = db.ExecuteQuery(query, parameters)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            TxtPerformanceTitle.Text = dt.Rows(0).Item("title")
        Else
            TxtPerformanceTitle.Text = String.Empty
        End If
    End Sub

    ''' <summary>
    ''' Button Search Click Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        GetData()
    End Sub

    ''' <summary>
    ''' Get data Bookings
    ''' </summary>
    Private Sub GetData()
        Dim db As New DbContext()
        Dim query As New StringBuilder

        query.Append(" SELECT")
        query.Append("     PF.title as PerformanceTitle")
        query.Append("    ,BK.customer_name as Customer")
        query.Append("    ,BK.vip_seat_ticket as TicketVip")
        query.Append("    ,BK.couple_seat_ticket as TicketCouple")
        query.Append("    ,BK.standart_seat_ticket as TicketStandard")
        query.Append("    ,BK.vip_seat_ticket + BK.couple_seat_ticket + BK.standart_seat_ticket AS TotalTicket")
        query.Append("    ,COALESCE(SA.TicketCount,0) AS TicketCount")
        query.Append("    ,BK.booking_id as Id")
        query.Append(" FROM")
        query.Append("     bookings BK")
        query.Append(" INNER JOIN performances PF")
        query.Append(" ON  BK.performance_id = PF.performance_id")
        query.Append(" LEFT JOIN (")
        query.Append("     SELECT")
        query.Append("         COUNT(*) AS TicketCount")
        query.Append("        ,booking_id AS BookingId")
        query.Append("     FROM")
        query.Append("         seat_assignments")
        query.Append("     GROUP BY")
        query.Append("         booking_id")
        query.Append(" ) SA")
        query.Append(" ON BK.booking_id = SA.BookingId")
        query.Append(" WHERE")
        query.Append("     1 = 1")

        If NumPerformanceId.Value > 0 Then
            query.Append(" AND BK.performance_id = @performance_id")
        End If

        If Not String.IsNullOrEmpty(TxtCustomer.Text.Trim) Then
            query.Append(" AND UPPER(BK.customer_name) LIKE @customer_name")
        End If

        Dim parameters As New Dictionary(Of String, Object)

        If NumPerformanceId.Value > 0 Then
            parameters.Add("@performance_id", NumPerformanceId.Value)
        End If

        If Not String.IsNullOrEmpty(TxtCustomer.Text.Trim) Then
            parameters.Add("@customer_name", "%" & TxtCustomer.Text.Trim.ToUpper & "%")
        End If

        query.Append(" ORDER BY")
        query.Append("    PF.created_date DESC")

        DtViewData.DataSource = db.ExecuteQuery(query.ToString, parameters)
    End Sub

    ''' <summary>
    ''' DataGridView CellClick event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtViewData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtViewData.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim dgv As DataGridView = CType(sender, DataGridView)
            If dgv.Columns(e.ColumnIndex).Name = "Choose" Then
                DialogResult = DialogResult.OK
                BookingId = dgv.Rows(e.RowIndex).Cells("Id").Value
                Close()
            End If
        End If
    End Sub
End Class
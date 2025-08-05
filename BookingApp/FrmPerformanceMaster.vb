Imports System.Text
Imports BookingApp.Constant

Public Class FrmPerformanceMaster
    Public PerformanceId As Integer = 0
    Private _screenMode As ScreenMode

    Public Sub New(mode As ScreenMode)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _screenMode = mode

        If _screenMode = ScreenMode.Normal Then
            Text = "Performance Master"
            StartPosition = FormStartPosition.CenterScreen
            MinimizeBox = True
            ShowInTaskbar = True
        Else
            Text = "Search Performance"
            StartPosition = FormStartPosition.CenterParent
            MinimizeBox = False
            ShowInTaskbar = False
        End If
    End Sub

    ''' <summary>
    ''' Form load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmPerformanceMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpkStartTimeFrom.Value = New DateTime(Now.Year, Now.Month, 1)
        DtpkStartTimeTo.Value = New DateTime(Now.Year, Now.Month, 1).AddMonths(1).AddDays(-1)

        If _screenMode = ScreenMode.Normal Then
            BtnCreate.Visible = True
            DtViewData.Columns("Edit").Visible = True
            DtViewData.Columns("choose").Visible = False
        Else
            BtnCreate.Visible = False
            DtViewData.Columns("Edit").Visible = False
            DtViewData.Columns("choose").Visible = True
        End If

        GetData()
    End Sub

    ''' <summary>
    ''' Button Create click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim frm As New FrmEditPerformanceMaster
        If frm.ShowDialog() = DialogResult.OK Then
            GetData()
        End If
    End Sub

    ''' <summary>
    ''' Button Ssearch click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If DtpkStartTimeTo.Value < DtpkStartTimeFrom.Value Then
            MessageBox.Show("The start date must be earlier than the end date.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DtpkStartTimeFrom.Focus()
            Exit Sub
        End If

        GetData()
    End Sub

    ''' <summary>
    ''' DataGridView cell click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtViewData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtViewData.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim dgv As DataGridView = CType(sender, DataGridView)
            If dgv.Columns(e.ColumnIndex).Name = "Edit" Then
                Dim frm As New FrmEditPerformanceMaster(dgv.Rows(e.RowIndex).Cells("Id").Value)
                If frm.ShowDialog() = DialogResult.OK Then
                    GetData()
                End If
            ElseIf dgv.Columns(e.ColumnIndex).Name = "Choose" Then
                DialogResult = DialogResult.OK
                PerformanceId = dgv.Rows(e.RowIndex).Cells("Id").Value
                Close()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Get data to DataGridView
    ''' </summary>
    Private Sub GetData()
        Dim db As New DbContext()
        Dim query As New StringBuilder

        query.Append(" SELECT")
        query.Append("     PF.performance_id AS Id")
        query.Append("    ,PF.title AS Title")
        query.Append("    ,TO_CHAR(PF.start_time, 'YYYY/MM/DD HH24:MI') AS StartTime")
        query.Append("    ,PF.duration_minutes AS DurationMinute")
        query.Append("    ,PF.amount_vip AS AmountVip")
        query.Append("    ,PF.amount_couple AS AmountCouple")
        query.Append("    ,PF.amount_standard AS AmountStandard")
        query.Append("    ,COALESCE(BK.TotalTicket,0) AS TotalTicket")
        query.Append("    ,TO_CHAR(PF.created_date, 'YYYY/MM/DD HH24:MI') AS CreatedDate")
        query.Append(" FROM")
        query.Append("     performances PF")
        query.Append(" LEFT JOIN (")
        query.Append("     SELECT")
        query.Append("         SUM(vip_seat_ticket) + SUM(couple_seat_ticket) + SUM(standart_seat_ticket) AS TotalTicket")
        query.Append("        ,performance_id")
        query.Append("     FROM")
        query.Append("         bookings")
        query.Append("     GROUP BY")
        query.Append("         performance_id")
        query.Append(" ) BK")
        query.Append(" ON  PF.performance_id = BK.performance_id")
        query.Append(" WHERE")
        query.Append("     PF.start_time::DATE >= @start_time_from::DATE")
        query.Append(" AND PF.start_time::DATE <= @start_time_to::DATE")

        If TxtTitle.Text.Trim <> "" Then
            query.Append(" AND UPPER(PF.title) LIKE @title")
        End If

        query.Append(" ORDER BY PF.created_date DESC")

        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("@start_time_from", DtpkStartTimeFrom.Value)
        parameters.Add("@start_time_to", DtpkStartTimeTo.Value)

        If TxtTitle.Text.Trim <> "" Then
            parameters.Add("@title", "%" & TxtTitle.Text.Trim.ToUpper & "%")
        End If

        DtViewData.DataSource = db.ExecuteQuery(query.ToString, parameters)

    End Sub
End Class

Imports System.Text
Imports BookingApp.Constant

Public Class FrmViewSeatAssignment

    Private Const INIT_LEFT_BUTTON_SEAT As Integer = 25
    Private Const INIT_COLUMN_SEAT_MAP As Integer = 10

    Private SeatChoose As New Dictionary(Of String, String)

    ''' <summary>
    ''' Form load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmSeatAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericHelper.ProtectEmptyValue(NumPerformanceId)

        AddButtonSeatMap()
    End Sub

    ''' <summary>
    ''' PerformanceId ValueChanged Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NumPerformanceId_ValueChanged(sender As Object, e As EventArgs) Handles NumPerformanceId.ValueChanged
        GetPerformance()
        ClearButtonSeatMap()
        AddButtonSeatMap()
        SetSeatAssignmentInfo()
        CountTicketBooking()
    End Sub

    ''' <summary>
    ''' Create a button in the seat map
    ''' </summary>
    ''' <param name="rows"></param>
    ''' <param name="control"></param>
    ''' <param name="seatType"></param>
    Private Sub CreateButtonToSeatMap(rows As Integer, control As Panel, seatType As SeatType)
        Dim cols As Integer = 10
        Dim btnWidth As Integer = 80
        Dim btnHeight As Integer = 30
        Dim spacing As Integer = 5
        control.SuspendLayout()

        For row As Integer = 0 To rows - 1
            For col As Integer = 1 To cols
                Dim btn As New Button()

                Dim seatName As String
                Select Case seatType
                    Case SeatType.VIP
                        seatName = Chr(Asc("A"c) + row) & col.ToString()
                    Case SeatType.Couple
                        seatName = Chr(Asc("A"c) + row + 2) & col.ToString()
                    Case Else
                        seatName = Chr(Asc("A"c) + row + 4) & col.ToString()
                End Select

                btn.Name = seatName
                btn.Text = seatName
                btn.Width = btnWidth
                btn.Height = btnHeight

                If col = 1 Then
                    btn.Left = INIT_LEFT_BUTTON_SEAT
                Else
                    btn.Left = (col * (btnWidth + spacing)) - (btnWidth + spacing - INIT_LEFT_BUTTON_SEAT)
                End If

                btn.Top = row * (btnHeight + spacing)

                control.Controls.Add(btn)
            Next
        Next

        control.ResumeLayout()
    End Sub

    ''' <summary>
    ''' Get data performances
    ''' </summary>
    Private Sub GetPerformance()
        Dim db As New DbContext()

        Dim query As String = "
            SELECT 
                PF.performance_id, 
                COALESCE(BK.vip_seat_ticket,0) AS vip_seat_ticket, 
                COALESCE(BK.couple_seat_ticket,0) AS couple_seat_ticket, 
                COALESCE(BK.standart_seat_ticket,0) AS standart_seat_ticket, 
                PF.title, 
                PF.start_time, 
                PF.duration_minutes
            FROM performances PF
            LEFT JOIN (
                    SELECT
                        SUM(vip_seat_ticket) AS vip_seat_ticket
                       ,SUM(couple_seat_ticket) AS couple_seat_ticket 
                       ,SUM(standart_seat_ticket) AS standart_seat_ticket
                       ,performance_id
                    FROM
                        bookings
                    GROUP BY
                        performance_id
                    ) BK
            ON  PF.performance_id = BK.performance_id
            WHERE PF.performance_id = @performance_id
        "

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", NumPerformanceId.Value}
        }

        Dim dt = db.ExecuteQuery(query, parameters)

        If dt.Rows.Count > 0 Then
            NumPerformanceId.Value = dt.Rows(0).Item("performance_id")
            LabelTitle.Text = dt.Rows(0).Item("title")
            LabelStartTime.Text = CDate(dt.Rows(0).Item("start_time")).ToString("yyyy/MM/dd - HH:mm")
            LabelDuration.Text = dt.Rows(0).Item("duration_minutes") & " Minutes"
            LabelTicketVip.Text = dt.Rows(0).Item("vip_seat_ticket")
            LabelTicketCouple.Text = dt.Rows(0).Item("couple_seat_ticket")
            LabelTicketStandard.Text = dt.Rows(0).Item("standart_seat_ticket")
        Else
            LabelTitle.Text = String.Empty
            LabelStartTime.Text = String.Empty
            LabelDuration.Text = String.Empty
            LabelTicketVip.Text = String.Empty
            LabelTicketCouple.Text = String.Empty
            LabelTicketStandard.Text = String.Empty
            If NumPerformanceId.Value > 0 Then
                MessageBox.Show("Performance does not exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        SeatChoose = New Dictionary(Of String, String)
    End Sub

    ''' <summary>
    ''' Get data bookings by performance
    ''' </summary>
    ''' <returns></returns>
    Private Function GetBookingByPerformance() As DataTable
        Dim db As New DbContext()

        Dim query As String = "
        SELECT 
            booking_id
        FROM bookings 
        WHERE performance_id = @performance_id
        "

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", NumPerformanceId.Value}
        }

        Return db.ExecuteQuery(query, parameters)
    End Function

    ''' <summary>
    '''  Get data seat_assignments
    ''' </summary>
    ''' <returns></returns>
    Private Function GetSeatAssignmentInfo() As DataTable
        Dim db As New DbContext()
        Dim dtBooking As DataTable = GetBookingByPerformance()

        If dtBooking.Rows.Count > 0 Then
            Dim sql As New StringBuilder
            sql.Append(" SELECT")
            sql.Append("    booking_id")
            sql.Append("   ,seat")
            sql.Append(" FROM")
            sql.Append("    seat_assignments")
            sql.Append(" WHERE")
            sql.Append("    booking_id IN (")
            Dim tempBookingId As String = ""
            For Each row As DataRow In dtBooking.Rows
                If tempBookingId = "" Then
                    tempBookingId = row("booking_id")
                Else
                    tempBookingId = tempBookingId & "," & row("booking_id")
                End If
            Next
            sql.Append(tempBookingId)
            sql.Append(")")

            Return db.ExecuteQuery(sql.ToString)
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Set Seat Map
    ''' </summary>
    Private Sub SetSeatAssignmentInfo()
        Dim dt As DataTable = GetSeatAssignmentInfo()

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                SetStatusButtonSeatMap(row("seat"))
            Next
        End If
    End Sub

    ''' <summary>
    ''' Change status seat 
    ''' </summary>
    ''' <param name="control"></param>
    ''' <param name="buttonName"></param>
    ''' <returns></returns>
    Private Function ChangeStatusButtonSeatMap(control As Panel, buttonName As String) As Boolean
        Dim btn As Button = control.Controls.OfType(Of Button)().
                    FirstOrDefault(Function(b) b.Name = buttonName)

        If btn IsNot Nothing Then
            btn.BackColor = Color.IndianRed
            btn.ForeColor = Color.White
            SeatChoose.Add(btn.Name, btn.Parent.Tag)
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Insert data seat_assignments
    ''' </summary>
    ''' <returns></returns>
    Private Function InsertData() As Boolean
        Dim db As New DbContext()

        Using conn = db.OpenConnection()
            Using trans = conn.BeginTransaction()
                Try
                    'Delete seat_assignments by booking_id
                    Dim sqlDel As String = "DELETE FROM seat_assignments WHERE booking_id = @booking_id"
                    Dim parametersDel As New Dictionary(Of String, Object) From {
                        {"@booking_id", NumPerformanceId.Value}
                    }
                    db.ExecuteNonQuery(sqlDel, parametersDel, conn, trans)

                    'Insert seat_assignments
                    Dim sqlIns As String = "INSERT INTO seat_assignments(booking_id, seat) VALUES (@booking_id, @seat)"
                    For Each seat As KeyValuePair(Of String, String) In SeatChoose
                        Dim parameters As New Dictionary(Of String, Object) From {
                            {"@booking_id", NumPerformanceId.Value},
                            {"@seat", seat.Key}
                        }
                        db.ExecuteNonQuery(sqlIns, parameters, conn, trans)
                    Next

                    trans.Commit()
                    MessageBox.Show(MSG_SAVE_SUCCESS, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return True
    End Function

    ''' <summary>
    ''' Clear seat map
    ''' </summary>
    Private Sub ClearButtonSeatMap()
        Me.SuspendLayout()
        PanelVip.Controls.Clear()
        PanelCouple.Controls.Clear()
        PanelStandard.Controls.Clear()
        Me.ResumeLayout()
    End Sub

    ''' <summary>
    ''' Add button to seat map
    ''' </summary>
    Private Sub AddButtonSeatMap()
        Me.SuspendLayout()
        CreateButtonToSeatMap(2, PanelVip, SeatType.VIP)
        CreateButtonToSeatMap(2, PanelCouple, SeatType.Couple)
        CreateButtonToSeatMap(6, PanelStandard, SeatType.Standard)

        If NumPerformanceId.Value > 0 Then
            PanelVip.Enabled = True
            PanelCouple.Enabled = True
            PanelStandard.Enabled = True
        Else
            PanelVip.Enabled = False
            PanelCouple.Enabled = False
            PanelStandard.Enabled = False
        End If
        Me.ResumeLayout()
    End Sub

    ''' <summary>
    ''' Set status seat
    ''' </summary>
    ''' <param name="buttonName"></param>
    Private Sub SetStatusButtonSeatMap(buttonName As String)
        Dim stt As Boolean = False
        stt = ChangeStatusButtonSeatMap(PanelVip, buttonName)

        If Not stt Then
            stt = ChangeStatusButtonSeatMap(PanelCouple, buttonName)
        End If

        If Not stt Then
            stt = ChangeStatusButtonSeatMap(PanelStandard, buttonName)
        End If
    End Sub

    ''' <summary>
    ''' Button search Booking click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnBooking_Click(sender As Object, e As EventArgs) Handles BtnPerformance.Click
        Dim frm As New FrmPerformanceMaster(ScreenMode.Search)
        If frm.ShowDialog = DialogResult.OK Then
            NumPerformanceId.Value = frm.PerformanceId
        End If
    End Sub

    ''' <summary>
    ''' Count Ticket Booking
    ''' </summary>
    Private Sub CountTicketBooking()
        Dim countVip As Integer = SeatChoose.AsEnumerable().Count(Function(x) x.Value = PanelVip.Tag)
        GroupBoxVip.Text = String.Format("Vip ({0}/{1})", countVip, CInt(LabelTicketVip.Text))

        Dim countCouple As Integer = SeatChoose.AsEnumerable().Count(Function(x) x.Value = PanelCouple.Tag)
        GroupBoxCouple.Text = String.Format("Couple ({0}/{1})", countCouple, CInt(LabelTicketCouple.Text))

        Dim countStandard As Integer = SeatChoose.AsEnumerable().Count(Function(x) x.Value = PanelStandard.Tag)
        GroupBoxStandard.Text = String.Format("Standard ({0}/{1})", countStandard, CInt(LabelTicketStandard.Text))
    End Sub
End Class
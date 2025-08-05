Imports System.Text
Imports BookingApp.Constant

Public Class FrmSeatAssignment

    Private Const INIT_LEFT_BUTTON_SEAT As Integer = 25
    Private Const INIT_COLUMN_SEAT_MAP As Integer = 10
    Private Const NOT_CHOOSE As String = NameOf(NOT_CHOOSE)
    Private Const CHOOSE As String = NameOf(CHOOSE)

    Private SeatChoose As New Dictionary(Of String, String)

    ''' <summary>
    ''' Form load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmSeatAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericHelper.ProtectEmptyValue(NumBookingId)

        AddButtonSeatMap()
        BtnSave.Enabled = False
    End Sub

    ''' <summary>
    ''' Button seat click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Seat_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)

        If btn.Tag = CHOOSE Then
            btn.BackColor = SystemColors.Window
            btn.ForeColor = Color.Black
            btn.Tag = NOT_CHOOSE
            SeatChoose.Remove(btn.Name)
            CountTicketBooking()
            Return
        End If

        'Seat selection exceeds purchased ticket count.
        Dim count As Integer = SeatChoose.AsEnumerable().Count(Function(x) x.Value = btn.Parent.Tag)
        Select Case btn.Parent.Tag
            Case "Vip"
                If count = CInt(LabelTicketVip.Text) Then
                    MessageBox.Show("The number of VIP tickets selected has reached the limit.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Case "Couple"
                If count = CInt(LabelTicketCouple.Text) Then
                    MessageBox.Show("The number of Couple tickets selected has reached the limit.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Case "Standard"
                If count = CInt(LabelTicketStandard.Text) Then
                    MessageBox.Show("The number of Standard tickets selected has reached the limit.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
        End Select

        'Check for duplicate selected seats
        If Not CheckDuplicateSeat(btn.Name) Then
            btn.BackColor = Color.IndianRed
            btn.ForeColor = Color.White
            btn.Tag = ""
            btn.Enabled = False
            Return
        End If

        btn.BackColor = Color.DodgerBlue
        btn.ForeColor = Color.White
        btn.Tag = CHOOSE
        SeatChoose.Add(btn.Name, btn.Parent.Tag)
        CountTicketBooking()
    End Sub

    ''' <summary>
    ''' BookingId ValueChanged Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NumBookingId_ValueChanged(sender As Object, e As EventArgs) Handles NumBookingId.ValueChanged
        GetBooking()
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
                btn.Tag = NOT_CHOOSE
                btn.Width = btnWidth
                btn.Height = btnHeight

                If col = 1 Then
                    btn.Left = INIT_LEFT_BUTTON_SEAT
                Else
                    btn.Left = (col * (btnWidth + spacing)) - (btnWidth + spacing - INIT_LEFT_BUTTON_SEAT)
                End If

                btn.Top = row * (btnHeight + spacing)
                AddHandler btn.Click, AddressOf Seat_Click

                control.Controls.Add(btn)
            Next
        Next

        control.ResumeLayout()
    End Sub

    ''' <summary>
    ''' Get data bookings
    ''' </summary>
    Private Sub GetBooking()
        Dim db As New DbContext()

        Dim query As String = "
            SELECT 
                BK.performance_id, 
                BK.vip_seat_ticket, 
                BK.couple_seat_ticket, 
                BK.standart_seat_ticket, 
                BK.customer_name, 
                PF.title, 
                PF.start_time, 
                PF.duration_minutes
            FROM bookings BK
            INNER JOIN performances PF
            ON  BK.performance_id = PF.performance_id
            WHERE BK.booking_id = @booking_id
        "

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@booking_id", NumBookingId.Value}
        }

        Dim dt = db.ExecuteQuery(query, parameters)

        If dt.Rows.Count > 0 Then
            NumPerformanceId.Value = dt.Rows(0).Item("performance_id")
            LabelTitle.Text = dt.Rows(0).Item("title")
            LabelStartTime.Text = CDate(dt.Rows(0).Item("start_time")).ToString("yyyy/MM/dd - HH:mm")
            LabelDuration.Text = dt.Rows(0).Item("duration_minutes") & " Minutes"
            LabelCustomer.Text = dt.Rows(0).Item("customer_name")
            LabelTicketVip.Text = dt.Rows(0).Item("vip_seat_ticket")
            LabelTicketCouple.Text = dt.Rows(0).Item("couple_seat_ticket")
            LabelTicketStandard.Text = dt.Rows(0).Item("standart_seat_ticket")
            BtnSave.Enabled = True
        Else
            NumPerformanceId.Value = 0
            LabelTitle.Text = String.Empty
            LabelStartTime.Text = String.Empty
            LabelDuration.Text = String.Empty
            LabelCustomer.Text = String.Empty
            LabelTicketVip.Text = String.Empty
            LabelTicketCouple.Text = String.Empty
            LabelTicketStandard.Text = String.Empty
            BtnSave.Enabled = False
            If NumBookingId.Value > 0 Then
                MessageBox.Show("Booking does not exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            For Each row As DataRow In dt.Select(String.Format("booking_id = {0}", NumBookingId.Value))
                SetStatusButtonSeatMap(row("seat"), False)
            Next

            For Each row As DataRow In dt.Select(String.Format("booking_id <> {0}", NumBookingId.Value))
                SetStatusButtonSeatMap(row("seat"), True)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Change status seat 
    ''' </summary>
    ''' <param name="control"></param>
    ''' <param name="buttonName"></param>
    ''' <param name="isAnotherBooking"></param>
    ''' <returns></returns>
    Private Function ChangeStatusButtonSeatMap(control As Panel, buttonName As String, isAnotherBooking As Boolean) As Boolean
        Dim btn As Button = control.Controls.OfType(Of Button)().
                    FirstOrDefault(Function(b) b.Name = buttonName)

        If btn IsNot Nothing Then
            If isAnotherBooking Then
                btn.BackColor = Color.IndianRed
                btn.ForeColor = Color.White
                btn.Tag = ""
                btn.Enabled = False
                SeatChoose.Remove(btn.Name)
            Else
                btn.BackColor = Color.DodgerBlue
                btn.ForeColor = Color.White
                btn.Enabled = True
                btn.Tag = CHOOSE
                SeatChoose.Add(btn.Name, btn.Parent.Tag)
            End If

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
                        {"@booking_id", NumBookingId.Value}
                    }
                    db.ExecuteNonQuery(sqlDel, parametersDel, conn, trans)

                    'Insert seat_assignments
                    Dim sqlIns As String = "INSERT INTO seat_assignments(booking_id, seat) VALUES (@booking_id, @seat)"
                    For Each seat As KeyValuePair(Of String, String) In SeatChoose
                        Dim parameters As New Dictionary(Of String, Object) From {
                            {"@booking_id", NumBookingId.Value},
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
    ''' Button Save click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CheckDuplicateAllSeat() Then
            Return
        End If

        If MessageBox.Show(MSG_CONFIRM_SAVE_DATA, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) <> DialogResult.OK Then
            Return
        End If

        If InsertData() Then
            NumBookingId_ValueChanged(Nothing, Nothing)
        End If
    End Sub

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
    ''' Check Duplicate Seat
    ''' </summary>
    ''' <param name="seat"></param>
    ''' <returns></returns>
    Private Function CheckDuplicateSeat(seat As String) As Boolean
        Dim db As New DbContext()

        Dim query As String = "
        SELECT 
            SA.booking_id
           ,SA.seat
        FROM 
            seat_assignments SA 
        INNER JOIN bookings BK
        ON  SA.booking_id = BK.booking_id
        AND BK.performance_id = @performance_id
        WHERE
            SA.booking_id <> @booking_id
        AND SA.seat = @seat
        "

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", NumPerformanceId.Value},
            {"booking_id", NumBookingId.Value},
            {"@seat", seat}
        }

        Dim dt As DataTable = db.ExecuteQuery(query, parameters)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Seat [" & seat & "] has already been booked." & vbNewLine & "Please choose another seat.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Check Duplicate Seat
    ''' </summary>
    ''' <returns></returns>
    Private Function CheckDuplicateAllSeat() As Boolean
        Dim db As New DbContext()

        Dim query As New StringBuilder

        query.Append(" SELECT")
        query.Append("    SA.booking_id")
        query.Append("   ,SA.seat")
        query.Append(" FROM")
        query.Append("    seat_assignments SA")
        query.Append(" INNER JOIN bookings BK")
        query.Append(" ON  SA.booking_id = BK.booking_id")
        query.Append(" AND BK.performance_id = @performance_id")
        query.Append(" WHERE")
        query.Append("     SA.booking_id <> @booking_id")
        query.Append(" AND SA.seat IN (")

        Dim tempSeat As String = String.Empty
        For Each seat As KeyValuePair(Of String, String) In SeatChoose
            If tempSeat = String.Empty Then
                tempSeat = "'" & seat.Key & "'"
            Else
                tempSeat = tempSeat & ",'" & seat.Key & "'"
            End If
        Next
        query.Append(tempSeat)
        query.Append(")")

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", NumPerformanceId.Value},
            {"booking_id", NumBookingId.Value}
        }

        Dim dt As DataTable = db.ExecuteQuery(query.ToString, parameters)
        If dt.Rows.Count > 0 Then
            Dim seat As String = ""
            For Each row As DataRow In dt.Rows

                SetStatusButtonSeatMap(row("seat"), True)

                If seat = String.Empty Then
                    seat = row("seat")
                Else
                    seat = seat & "," & row("seat")
                End If
            Next

            MessageBox.Show("Seat [" & seat & "] has already been booked." & vbNewLine & "Please choose another seat.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Set status seat
    ''' </summary>
    ''' <param name="buttonName"></param>
    ''' <param name="isAnotherBooking"></param>
    Private Sub SetStatusButtonSeatMap(buttonName As String, isAnotherBooking As Boolean)
        Dim stt As Boolean = False
        stt = ChangeStatusButtonSeatMap(PanelVip, buttonName, isAnotherBooking)

        If Not stt Then
            stt = ChangeStatusButtonSeatMap(PanelCouple, buttonName, isAnotherBooking)
        End If

        If Not stt Then
            stt = ChangeStatusButtonSeatMap(PanelStandard, buttonName, isAnotherBooking)
        End If
    End Sub

    ''' <summary>
    ''' Button search Booking click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnBooking_Click(sender As Object, e As EventArgs) Handles BtnBooking.Click
        Dim frm As New FrmSearchBooking
        If frm.ShowDialog() = DialogResult.OK Then
            NumBookingId.Value = frm.BookingId
        End If
    End Sub

    ''' <summary>
    ''' Count Ticket Booking
    ''' </summary>
    Private Sub CountTicketBooking()
        If SeatChoose.Count > 0 Then
            Dim countVip As Integer = SeatChoose.AsEnumerable().Count(Function(x) x.Value = PanelVip.Tag)
            GroupBoxVip.Text = String.Format("Vip ({0}/{1})", countVip, CInt(LabelTicketVip.Text))

            Dim countCouple As Integer = SeatChoose.AsEnumerable().Count(Function(x) x.Value = PanelCouple.Tag)
            GroupBoxCouple.Text = String.Format("Couple ({0}/{1})", countCouple, CInt(LabelTicketCouple.Text))

            Dim countStandard As Integer = SeatChoose.AsEnumerable().Count(Function(x) x.Value = PanelStandard.Tag)
            GroupBoxStandard.Text = String.Format("Standard ({0}/{1})", countStandard, CInt(LabelTicketStandard.Text))
        End If
    End Sub
End Class
Imports BookingApp.Constant

Public Class FrmBooking

    ''' <summary>
    ''' From load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericHelper.ProtectEmptyValue(NumPerformanceId)
        NumericHelper.ProtectEmptyValue(NumVIPSeat)
        NumericHelper.ProtectEmptyValue(NumCoupleSeat)
        NumericHelper.ProtectEmptyValue(NumStandardSeat)

        EnableItem(False)
        BtnSave.Enabled = False
    End Sub

    ''' <summary>
    ''' Button Search Performance Click Event
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
        Dim dt As DataTable = GetData()
        If dt.Rows.Count > 0 Then
            EnableItem(True)

            With dt.Rows(0)
                TxtPerformanceTitle.Text = .Item("title")
                LabelVipTicketPrice.Text = Decimal.Parse(.Item("amount_vip")).ToString("#,##0")
                LabelCoupleTicketPrice.Text = Decimal.Parse(.Item("amount_couple")).ToString("#,##0")
                LabelStandardTicketPrice.Text = Decimal.Parse(.Item("amount_standard")).ToString("#,##0")

                Dim dtTicketLeft As DataTable = GetTicketLeft()
                LabelVipTicketLeft.Text = MAX_VIP_SEAT - Integer.Parse(dtTicketLeft.Rows(0).Item("VIP_SEAT_TICKET"))
                LabelCoupleTicketLeft.Text = MAX_COUPLE_SEAT - Integer.Parse(dtTicketLeft.Rows(0).Item("COUPLE_SEAT_TICKET"))
                LabelStandardTicketLeft.Text = MAX_STANDARD_SEAT - Integer.Parse(dtTicketLeft.Rows(0).Item("STANDART_SEAT_TICKET"))
            End With
            BtnSave.Enabled = True
        Else
            EnableItem(False)
            TxtPerformanceTitle.Text = String.Empty
            BtnSave.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' VIP Seat ValueChanged Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NumVIPSeat_ValueChanged(sender As Object, e As EventArgs) Handles NumVIPSeat.ValueChanged
        LabelVipTicketAmount.Text = (Decimal.Parse(LabelVipTicketPrice.Text) * NumVIPSeat.Value).ToString("#,##0")
        SumTotalAmount()
    End Sub

    ''' <summary>
    ''' Couple Seat ValueChanged Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NumCoupleSeat_ValueChanged(sender As Object, e As EventArgs) Handles NumCoupleSeat.ValueChanged
        LabelCoupleTicketAmount.Text = (Decimal.Parse(LabelCoupleTicketPrice.Text) * NumCoupleSeat.Value).ToString("#,##0")
        SumTotalAmount()
    End Sub

    ''' <summary>
    ''' Standard Seat ValueChanged Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NumStandardSeat_ValueChanged(sender As Object, e As EventArgs) Handles NumStandardSeat.ValueChanged
        LabelStandardTicketAmount.Text = (Decimal.Parse(LabelStandardTicketPrice.Text) * NumStandardSeat.Value).ToString("#,##0")
        SumTotalAmount()
    End Sub

    ''' <summary>
    ''' Button Save Click Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If CheckError() = False Then
            Exit Sub
        End If

        If MessageBox.Show(MSG_CONFIRM_SAVE_DATA, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) <> DialogResult.OK Then
            Return
        End If

        If InsertBooking() Then
            MessageBox.Show(MSG_SAVE_SUCCESS, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NumPerformanceId.Value = 0
        End If

    End Sub

    ''' <summary>
    ''' Get data performances
    ''' </summary>
    ''' <returns></returns>
    Private Function GetData() As DataTable
        Dim db As New DbContext()

        Dim query As String = "
            SELECT 
                title, 
                start_time, 
                duration_minutes, 
                amount_vip, 
                amount_couple, 
                amount_standard 
            FROM performances 
            WHERE performance_id = @performance_id
        "

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", NumPerformanceId.Value}
        }

        Return db.ExecuteQuery(query, parameters)
    End Function

    ''' <summary>
    ''' Enable/Disable Item
    ''' </summary>
    ''' <param name="val"></param>
    Private Sub EnableItem(val As Boolean)
        TxtCustomerName.Enabled = val
        NumVIPSeat.Enabled = val
        NumCoupleSeat.Enabled = val
        NumStandardSeat.Enabled = val

        If val = False Then
            TxtCustomerName.Text = String.Empty

            LabelVipTicketLeft.Text = "0"
            LabelCoupleTicketLeft.Text = "0"
            LabelStandardTicketLeft.Text = "0"

            LabelVipTicketPrice.Text = "0"
            LabelCoupleTicketPrice.Text = "0"
            LabelStandardTicketPrice.Text = "0"

            LabelVipTicketAmount.Text = "0"
            LabelCoupleTicketAmount.Text = "0"
            LabelStandardTicketAmount.Text = "0"

            NumVIPSeat.Value = 0
            NumCoupleSeat.Value = 0
            NumStandardSeat.Value = 0
        End If
    End Sub

    ''' <summary>
    ''' Insert data bookings
    ''' </summary>
    ''' <returns></returns>
    Private Function InsertBooking() As Boolean
        Dim query As String = "
            INSERT INTO bookings (
                performance_id,
                customer_name,
                vip_seat_ticket,
                couple_seat_ticket,
                standart_seat_ticket,
                created_date,
                updated_date
            )
            VALUES (
                @performance_id,
                @customer_name,
                @vip_seat_ticket,
                @couple_seat_ticket,
                @standart_seat_ticket,
                @created_date,
                @updated_date
            );"

        Dim db As New DbContext()

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", NumPerformanceId.Value},
            {"@customer_name", TxtCustomerName.Text},
            {"@vip_seat_ticket", NumVIPSeat.Value},
            {"@couple_seat_ticket", NumCoupleSeat.Value},
            {"@standart_seat_ticket", NumStandardSeat.Value},
            {"@created_date", Now},
            {"@updated_date", Now}
        }

        Dim rowsAffected = db.ExecuteNonQuery(query, parameters)
        Return rowsAffected > 0
    End Function

    ''' <summary>
    ''' Check error
    ''' </summary>
    ''' <returns></returns>
    Private Function CheckError() As Boolean
        If NumPerformanceId.Value = 0 Then
            MessageBox.Show("Please select a performance", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumPerformanceId.Focus()
            Return False
        Else
            If String.IsNullOrEmpty(TxtCustomerName.Text.Trim) Then
                MessageBox.Show(String.Format(MSG_REQUIRED_TEXT, "Customer"), "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtCustomerName.Focus()
                Return False
            End If

            'There are no tickets chosen for this transaction.
            If NumVIPSeat.Value = 0 AndAlso NumCoupleSeat.Value = 0 AndAlso NumStandardSeat.Value = 0 Then
                MessageBox.Show("Please enter the number of seats to book.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NumVIPSeat.Focus()
                Return False
            End If

            'The number of tickets booked exceeds the remaining available tickets.
            Dim dtTicketLeft As DataTable = GetTicketLeft()
            If NumVIPSeat.Value + dtTicketLeft.Rows(0).Item("VIP_SEAT_TICKET") > MAX_VIP_SEAT Then
                MessageBox.Show("Fewer VIP tickets remain than you requested." & vbNewLine & "Kindly verify and update your order to proceed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NumVIPSeat.Focus()
                GetTicketLeft(dtTicketLeft)
                Return False
            End If

            If NumCoupleSeat.Value + dtTicketLeft.Rows(0).Item("COUPLE_SEAT_TICKET") > MAX_COUPLE_SEAT Then
                MessageBox.Show("Fewer Couple tickets remain than you requested." & vbNewLine & "Kindly verify and update your order to proceed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NumCoupleSeat.Focus()
                GetTicketLeft(dtTicketLeft)
                Return False
            End If

            If NumStandardSeat.Value + dtTicketLeft.Rows(0).Item("STANDART_SEAT_TICKET") > MAX_STANDARD_SEAT Then
                MessageBox.Show("Fewer Standard tickets remain than you requested." & vbNewLine & "Kindly verify and update your order to proceed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NumStandardSeat.Focus()
                GetTicketLeft(dtTicketLeft)
                Return False
            End If

            'If there is a change in the ticket price.
            Dim dtCheckPrice As DataTable = GetData()
            If Decimal.Parse(dtCheckPrice.Rows(0).Item("amount_vip")) <> Decimal.Parse(LabelVipTicketPrice.Text) OrElse
                Decimal.Parse(dtCheckPrice.Rows(0).Item("amount_couple")) <> Decimal.Parse(LabelCoupleTicketPrice.Text) OrElse
                Decimal.Parse(dtCheckPrice.Rows(0).Item("amount_standard")) <> Decimal.Parse(LabelStandardTicketPrice.Text) Then
                MessageBox.Show("Ticket pricing has been updated. Kindly review and confirm before booking.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                LabelVipTicketPrice.Text = CDec(dtCheckPrice.Rows(0).Item("amount_vip")).ToString("#,##0")
                LabelVipTicketAmount.Text = (Decimal.Parse(dtCheckPrice.Rows(0).Item("amount_vip")) * NumVIPSeat.Value).ToString("#,##0")

                LabelCoupleTicketPrice.Text = CDec(dtCheckPrice.Rows(0).Item("amount_couple")).ToString("#,##0")
                LabelCoupleTicketAmount.Text = (Decimal.Parse(dtCheckPrice.Rows(0).Item("amount_couple")) * NumCoupleSeat.Value).ToString("#,##0")

                LabelStandardTicketPrice.Text = CDec(dtCheckPrice.Rows(0).Item("amount_standard")).ToString("#,##0")
                LabelStandardTicketAmount.Text = (Decimal.Parse(dtCheckPrice.Rows(0).Item("amount_standard")) * NumStandardSeat.Value).ToString("#,##0")

                SumTotalAmount()

                Return False
            End If
        End If

        Return True
    End Function

    ''' <summary>
    ''' Get the number of tickets left for the performance
    ''' </summary>
    ''' <returns></returns>
    Private Function GetTicketLeft() As DataTable
        Dim db As New DbContext()

        Dim query As String = "
            SELECT 
                COALESCE(SUM(vip_seat_ticket),0) AS VIP_SEAT_TICKET, 
                COALESCE(SUM(couple_seat_ticket),0) AS COUPLE_SEAT_TICKET, 
                COALESCE(SUM(standart_seat_ticket),0)AS STANDART_SEAT_TICKET
            FROM bookings 
            WHERE performance_id = @performance_id
        "

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", NumPerformanceId.Value}
        }

        Return db.ExecuteQuery(query, parameters)
    End Function

    ''' <summary>
    ''' Sum Amount
    ''' </summary>
    Private Sub SumTotalAmount()
        LabelTotalAmount.Text = (Decimal.Parse(LabelVipTicketAmount.Text) + Decimal.Parse(LabelCoupleTicketAmount.Text) + Decimal.Parse(LabelStandardTicketAmount.Text)).ToString("#,##0")
    End Sub

    ''' <summary>
    ''' Get Ticket Left
    ''' </summary>
    ''' <param name="dtTicketLeft"></param>
    Private Sub GetTicketLeft(dtTicketLeft As DataTable)
        LabelVipTicketLeft.Text = MAX_VIP_SEAT - dtTicketLeft.Rows(0).Item("VIP_SEAT_TICKET")
        LabelCoupleTicketLeft.Text = MAX_COUPLE_SEAT - dtTicketLeft.Rows(0).Item("COUPLE_SEAT_TICKET")
        LabelStandardTicketLeft.Text = MAX_STANDARD_SEAT - dtTicketLeft.Rows(0).Item("STANDART_SEAT_TICKET")
    End Sub
End Class
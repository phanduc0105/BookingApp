Imports BookingApp.Constant

Public Class FrmEditPerformanceMaster
    Private _currentId As Integer = 0

    Public Sub New(Optional id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If id = 0 Then
            Text = "Create Performance"
            BtnDel.Visible = False
        Else
            Text = "Edit Performance"
            BtnDel.Visible = True
        End If
        _currentId = id
    End Sub

    ''' <summary>
    ''' Form load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmEditPermanceMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericHelper.ProtectEmptyValue(NumDuration)
        NumericHelper.ProtectEmptyValue(NumAmountVip)
        NumericHelper.ProtectEmptyValue(NumAmountCouple)
        NumericHelper.ProtectEmptyValue(NumAmountStandard)

        If _currentId > 0 Then
            Dim dt As DataTable = GetData()
            With dt.Rows(0)
                TxtTitle.Text = .Item("title")
                DtpkStartDate.Value = .Item("start_time")
                NumDuration.Value = .Item("duration_minutes")
                NumAmountVip.Value = .Item("amount_vip")
                NumAmountCouple.Value = .Item("amount_couple")
                NumAmountStandard.Value = .Item("amount_standard")
            End With

            'If the performance has already taken place, it cannot be updated.
            Dim trimmedInput As DateTime = New DateTime(DtpkStartDate.Value.Year, DtpkStartDate.Value.Month, DtpkStartDate.Value.Day, DtpkStartDate.Value.Hour, DtpkStartDate.Value.Minute, 0)
            Dim trimmedNow As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, 0)
            If trimmedNow > trimmedInput Then
                TxtTitle.Enabled = False
                DtpkStartDate.Enabled = False
                NumDuration.Enabled = False
                NumAmountVip.Enabled = False
                NumAmountCouple.Enabled = False
                NumAmountStandard.Enabled = False
                BtnSave.Enabled = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Button Save click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CheckError() Then
            Return
        End If

        If MessageBox.Show(MSG_CONFIRM_SAVE_DATA, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) <> DialogResult.OK Then
            Return
        End If

        If _currentId = 0 Then
            If InsertData() > 0 Then
                MessageBox.Show(MSG_SAVE_SUCCESS, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If UpdateData() > 0 Then
                MessageBox.Show(MSG_SAVE_SUCCESS, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        DialogResult = DialogResult.OK
        Close()
    End Sub

    ''' <summary>
    ''' Get data mode update
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
            {"@performance_id", _currentId}
        }

        Return db.ExecuteQuery(query, parameters)
    End Function

    ''' <summary>
    ''' Insert data Rerformances
    ''' </summary>
    Private Function InsertData() As Integer
        Dim db As New DbContext()

        Dim query As String = "
        INSERT INTO performances 
        (title, start_time, duration_minutes, amount_vip, amount_couple, amount_standard, created_date, updated_date)
        VALUES 
        (@title, @start_time, @duration_minutes, @amount_vip, @amount_couple, @amount_standard, @created_date, @updated_date)
    "

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@title", TxtTitle.Text},
            {"@start_time", DtpkStartDate.Value},
            {"@duration_minutes", NumDuration.Value},
            {"@amount_vip", NumAmountVip.Value},
            {"@amount_couple", NumAmountCouple.Value},
            {"@amount_standard", NumAmountStandard.Value},
            {"@created_date", Now},
            {"@updated_date", Now}
        }

        Return db.ExecuteNonQuery(query, parameters)
    End Function

    ''' <summary>
    ''' Update data Rerformances
    ''' </summary>
    Private Function UpdateData() As Integer
        Dim db As New DbContext()

        Dim query As String = "
        UPDATE performances SET 
            title = @title,
            start_time = @start_time,
            duration_minutes = @duration_minutes,
            amount_vip = @amount_vip,
            amount_couple = @amount_couple,
            amount_standard = @amount_standard,
            updated_date = @updated_date
        WHERE performance_id = @performance_id
    "

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", _currentId},
            {"@title", TxtTitle.Text},
            {"@start_time", DtpkStartDate.Value},
            {"@duration_minutes", NumDuration.Value},
            {"@amount_vip", NumAmountVip.Value},
            {"@amount_couple", NumAmountCouple.Value},
            {"@amount_standard", NumAmountStandard.Value},
            {"@updated_date", Now}
        }

        Return db.ExecuteNonQuery(query, parameters)
    End Function

    ''' <summary>
    ''' Delete data Rerformances
    ''' </summary>
    ''' <returns></returns>
    Private Function DeleteData() As Integer
        Dim db As New DbContext()
        Dim query As String = "DELETE FROM performances WHERE performance_id = @performance_id"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", _currentId}
        }
        Return db.ExecuteNonQuery(query, parameters)
    End Function

    ''' <summary>
    ''' Check Error
    ''' </summary>
    ''' <returns></returns>
    Private Function CheckError() As Boolean

        If TxtTitle.Text.Trim = String.Empty Then
            MessageBox.Show(String.Format(MSG_REQUIRED_TEXT, "Title"), "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtTitle.Focus()
            Return False
        End If

        Dim trimmedInput As DateTime = New DateTime(DtpkStartDate.Value.Year, DtpkStartDate.Value.Month, DtpkStartDate.Value.Day, DtpkStartDate.Value.Hour, DtpkStartDate.Value.Minute, 0)
        Dim trimmedNow As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, 0)
        If trimmedInput < trimmedNow Then
            MessageBox.Show("Start time must be later than the current date.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DtpkStartDate.Focus()
            Return False
        End If

        If NumDuration.Value = 0 Then
            MessageBox.Show(String.Format(MSG_REQUIRED_NUMBER, "Duration"), "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumDuration.Focus()
            Return False
        End If

        If NumAmountVip.Value = 0 Then
            MessageBox.Show(String.Format(MSG_REQUIRED_NUMBER, "Amount (Vip)"), "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumAmountVip.Focus()
            Return False
        End If

        If NumAmountCouple.Value = 0 Then
            MessageBox.Show(String.Format(MSG_REQUIRED_NUMBER, "Amount (Couple)"), "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumAmountCouple.Focus()
            Return False
        End If

        If NumAmountStandard.Value = 0 Then
            MessageBox.Show(String.Format(MSG_REQUIRED_NUMBER, "Amount (Standard)"), "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumAmountStandard.Focus()
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Button Delete click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click

        'If tickets have already been sold, deletion is not allowed.
        If Not CheckDel() Then
            MessageBox.Show("This performance already has bookings and cannot be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show(MSG_CONFIRM_DEL_DATA, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) <> DialogResult.OK Then
            Return
        End If

        If DeleteData() > 0 Then
            MessageBox.Show(MSG_DEL_SUCCESS, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DialogResult = DialogResult.OK
            Close()
        End If
    End Sub

    ''' <summary>
    ''' Check error delete data
    ''' </summary>
    ''' <returns></returns>
    Private Function CheckDel() As Boolean
        Dim db As New DbContext()
        Dim query As String = "SELECT COUNT(*) FROM bookings WHERE performance_id = @performance_id"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@performance_id", _currentId}
        }

        Dim count As Integer = db.ExecuteScalar(query, parameters)
        Return count = 0
    End Function
End Class
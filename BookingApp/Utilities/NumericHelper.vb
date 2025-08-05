Public Class NumericHelper
    ''' <summary>
    ''' Protect Empty Value
    ''' </summary>
    ''' <param name="numeric"></param>
    Public Shared Sub ProtectEmptyValue(numeric As NumericUpDown)
        Dim textBox = TryCast(numeric.Controls.OfType(Of Control)().
                              FirstOrDefault(Function(c) TypeOf c Is TextBox), TextBox)

        If textBox IsNot Nothing Then
            AddHandler textBox.TextChanged, Sub(sender, e)
                                                Dim tb = DirectCast(sender, TextBox)
                                                If String.IsNullOrWhiteSpace(tb.Text) Then
                                                    numeric.Value = numeric.Minimum
                                                End If
                                            End Sub
        End If
    End Sub
End Class

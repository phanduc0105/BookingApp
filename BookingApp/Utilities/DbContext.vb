Imports System.Configuration
Imports Npgsql

Public Class DbContext

    ''' <summary>
    ''' Open Connection Database
    ''' </summary>
    ''' <returns></returns>
    Public Function OpenConnection() As NpgsqlConnection
        Dim conn As New NpgsqlConnection(ConfigurationManager.ConnectionStrings("PostgresDb").ConnectionString)
        conn.Open()
        Return conn
    End Function

    ''' <summary>
    ''' Executes a SQL statement against the connection and returns the data table.
    ''' </summary>
    ''' <param name="query"></param>
    ''' <param name="parameters"></param>
    ''' <returns></returns>
    Public Function ExecuteQuery(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim dt As New DataTable()

        Using conn = OpenConnection()
            Using cmd As New NpgsqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If

                Using reader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using

        Return dt
    End Function

    ''' <summary>
    ''' Executes a SQL statement against the connection and returns the number of rows affected.
    ''' </summary>
    ''' <param name="query"></param>
    ''' <param name="parameters"></param>
    ''' <returns></returns>
    Public Function ExecuteNonQuery(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Integer
        Using conn = OpenConnection()
            Using cmd As New NpgsqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If

                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ''' <summary>
    ''' Executes a SQL statement against the connection and returns the number of rows affected.
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="params"></param>
    ''' <param name="conn"></param>
    ''' <param name="trans"></param>
    ''' <returns></returns>
    Public Function ExecuteNonQuery(sql As String, params As Dictionary(Of String, Object), conn As NpgsqlConnection, trans As NpgsqlTransaction) As Integer
        Using cmd As New NpgsqlCommand(sql, conn, trans)
            If params IsNot Nothing Then
                For Each p In params
                    cmd.Parameters.AddWithValue(p.Key, p.Value)
                Next
            End If
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

    ''' <summary>
    ''' Executes the query, and returns the first column of the first row in the result set returned by the query. Extra columns or rows are ignored.
    ''' </summary>
    ''' <param name="query"></param>
    ''' <param name="parameters"></param>
    ''' <returns></returns>
    Public Function ExecuteScalar(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Object
        Using conn = OpenConnection()
            Using cmd As New NpgsqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If

                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function
End Class

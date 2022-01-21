Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Users
    Private username As String

    Public Function EncryptPassword(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function
    Public Property usernameProperty() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Function UserDatabase(username As String, password As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            connect()

            sqlCmd.Connection = sqlConn
            Dim queryAuth = "SELECT UserName, Password FROM registrasi WHERE UserName = '" & username & "'AND Password ='" & EncryptPassword(password) & "'"

            sqlCmd.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlDr = sqlCmd.ExecuteReader
            If sqlDr.HasRows Then
                While sqlDr.Read
                    result.Add(sqlDr.GetString(0).ToString())
                    result.Add(sqlDr.GetString(1).ToString())
                End While
            End If

            sqlDr.Close()
            sqlConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
    End Function
    Public Function AddUsersDatabase(username_regist As String, password_regist As String, email As String)
        Try
            connect()

            sqlCmd.Connection = sqlConn
            sqlQuery = "INSERT INTO registrasi( UserName, Password, email, foto) VALUE(
            '" & username_regist & "',
            '" & EncryptPassword(password_regist) & "',
            '" & email & "',
            '" & imgPath & " ')"

            Debug.WriteLine(sqlQuery)

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlDr = sqlCmd.ExecuteReader

            sqlDr.Close()
            sqlConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            sqlConn.Dispose()
        End Try
        Return 0
    End Function
End Class

Imports System.Security.Cryptography

Module HashFunctions

    Public Function HashPasswordMD5(password As String) As String
        Dim md5 As New MD5CryptoServiceProvider()
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = md5.ComputeHash(bytes)
        Dim stringBuilder As New System.Text.StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("x2"))
        Next
        Return stringBuilder.ToString()
    End Function

    Public Function HashPasswordSHA1(password As String) As String
        Dim sha1 As New SHA1CryptoServiceProvider()
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha1.ComputeHash(bytes)
        Dim stringBuilder As New System.Text.StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("x2"))
        Next
        Return stringBuilder.ToString()
    End Function

    Public Function HashPasswordSHA256(password As String) As String
        Dim sha256 As New SHA256CryptoServiceProvider()
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New System.Text.StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("x2"))
        Next
        Return stringBuilder.ToString()
    End Function

    Public Function HashPasswordSHA512(password As String) As String
        Dim sha512 As New SHA512CryptoServiceProvider()
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Dim stringBuilder As New System.Text.StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("x2"))
        Next
        Return stringBuilder.ToString()
    End Function

End Module

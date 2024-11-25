Imports Microsoft.VisualBasic


Public Class class_conexion

    Public db_usuario As String
    Public db_password As String
    Public db_server As String
    Public db_base As String
    Public db_cadena As String

    Sub set_conexion1()
        db_usuario = "sa"
        db_password = "sasa"
        db_server = "DESKTOP-5NUT75C\MSSQLSERVER2019"
        db_base = "test2024"
        db_cadena = "server=" & db_server & "; Persist Security Info=false; database=" & db_base & ";uid=" & db_usuario & ";pwd=" & db_password & ";"

    End Sub



 

End Class
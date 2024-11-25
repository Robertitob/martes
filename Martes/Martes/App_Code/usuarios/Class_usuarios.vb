Imports Microsoft.VisualBasic

Public Class Class_usuarios


    Dim conexion As New class_conexion

    Public tbl_usuarios_consultar As New class_llena_tabla

    Public Sub sub_usuarios_consultar()
        conexion.set_conexion1()
        tbl_usuarios_consultar.cadena_conexion = conexion.db_cadena
        tbl_usuarios_consultar.sqltext = "sp_usuarios_consultar"
        tbl_usuarios_consultar.sub_llena_tabla()

    End Sub



    Public tbl_usuarios_buscar As New class_llena_tabla

    Public Sub sub_usuarios_buscar(ByVal cadena As String)
        conexion.set_conexion1()
        tbl_usuarios_buscar.cadena_conexion = conexion.db_cadena
        tbl_usuarios_buscar.sqltext = "sp_usuarios_buscar " _
        & " @cadena = '" & cadena & "'"

        tbl_usuarios_buscar.sub_llena_tabla()

    End Sub
End Class

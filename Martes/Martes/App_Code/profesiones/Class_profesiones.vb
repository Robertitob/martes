Imports Microsoft.VisualBasic

Public Class Class_profesiones
    Dim conexion As New class_conexion

    Public tbl_profesiones_consultar As New class_llena_tabla

    Public Sub sub_profesiones_consultar()
        conexion.set_conexion1()
        tbl_profesiones_consultar.cadena_conexion = conexion.db_cadena
        tbl_profesiones_consultar.sqltext = "sp_profesiones_consulta"
        tbl_profesiones_consultar.sub_llena_tabla()

    End Sub

End Class

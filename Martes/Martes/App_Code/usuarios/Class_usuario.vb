Imports Microsoft.VisualBasic

Public Class Class_usuario

    Public nombre As String
    Public correo As String
    Public id_usuario As String
    Public fecha_registro As String
    Dim conexion As New class_conexion


    Public Sub sub_usuario_inserta()
        conexion.set_conexion1()
        Dim tbl_usuario_inserta As New class_llena_tabla
        tbl_usuario_inserta.cadena_conexion = conexion.db_cadena
        tbl_usuario_inserta.sqltext = "sp_usuario_inserta " _
  & " @nombre = N'" & nombre & "'," _
  & " @correo = N'" & correo & "'"
        tbl_usuario_inserta.sub_llena_tabla()

    End Sub

    Public Sub sub_usuario_eliminar()

        conexion.set_conexion1()
        Dim tbl_usuario_eliminar As New class_llena_tabla
        tbl_usuario_eliminar.cadena_conexion = conexion.db_cadena
        tbl_usuario_eliminar.sqltext = "sp_usuario_elimina " _
  & " @id_usuario = N'" & id_usuario & "'"
        tbl_usuario_eliminar.sub_llena_tabla()

    End Sub



    Public Sub sub_usuario_modificar()

        conexion.set_conexion1()
        Dim tbl_usuario_modificar As New class_llena_tabla
        tbl_usuario_modificar.cadena_conexion = conexion.db_cadena
        tbl_usuario_modificar.sqltext = "sp_usuario_modifica " _
  & " @id_usuario = N'" & id_usuario & "'," _
  & " @correo = N'" & correo & "'"
        tbl_usuario_modificar.sub_llena_tabla()

    End Sub


    Public Sub sub_usuario_consultar()

        conexion.set_conexion1()
        Dim tbl_usuario_consultar As New class_llena_tabla
        tbl_usuario_consultar.cadena_conexion = conexion.db_cadena
        tbl_usuario_consultar.sqltext = "sp_usuario_consulta " _
  & " @id_usuario = N'" & id_usuario & "'"
        tbl_usuario_consultar.sub_llena_tabla()

        If tbl_usuario_consultar.tabla_llena.Rows.Count > 0 Then
            id_usuario = tbl_usuario_consultar.tabla_llena.Rows(0)("id_usuario").ToString

            nombre = tbl_usuario_consultar.tabla_llena.Rows(0)("nombre").ToString
            correo = tbl_usuario_consultar.tabla_llena.Rows(0)("correo").ToString
            fecha_registro = tbl_usuario_consultar.tabla_llena.Rows(0)("fecha_registro").ToString


        End If


    End Sub



End Class

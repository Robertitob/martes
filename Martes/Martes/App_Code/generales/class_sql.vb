Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

'Imports System.Data.OleDb


Public Class class_llena_tabla
    Public error_datos As String
    Public sqltext As String
    Public cadena_conexion As String

    Public tabla_llena As New DataTable
    Public dataset_lleno As New DataSet

    Public Sub sub_llena_tabla()
        tabla_llena = New DataTable
        dataset_lleno = New DataSet
        Dim conexion As New SqlConnection
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()
            Dim Adapter3 As New SqlDataAdapter(sqltext, conexion)
            tabla_llena.Clear()


            '     Adapter3.Fill(tabla_llena)
            Adapter3.Fill(dataset_lleno)




            If dataset_lleno.Tables.Count > 0 Then
                tabla_llena = dataset_lleno.Tables(0)
            End If
            Adapter3 = Nothing
            conexion.Close()
            conexion = Nothing
        Catch ex As SqlException
            error_datos = ex.Message.ToString
        End Try
    End Sub
End Class




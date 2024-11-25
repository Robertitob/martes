Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports Microsoft.VisualBasic
Imports CrystalDecisions.Shared

Public Class Class_report
    Public Report As New ReportDocument
    Public DatosConexion As New class_conexion
    Public NombreReporte As String
    Public Parametros(20, 2) As String
    Public TotalParametros As Integer

    Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        'Dim test As String

        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next

    End Sub

    Public Sub Configurar()
        Report = New ReportDocument()
        Report.Load(NombreReporte)
        DatosConexion.set_conexion1()
        Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
        myConnectionInfo.DatabaseName = DatosConexion.db_base
        myConnectionInfo.ServerName = DatosConexion.db_server
        myConnectionInfo.UserID = DatosConexion.db_usuario
        myConnectionInfo.Password = DatosConexion.db_password
        'Dim test As String
        'test = mi_reporte.Database.Tables(0).Name
        SetDBLogonForReport(myConnectionInfo, Report)
        'test = mi_reporte.Database.Tables(0).Name



        Dim w As Integer
        For w = 1 To TotalParametros
            Dim parametroDiscretoValor As New CrystalDecisions.Shared.ParameterDiscreteValue
            Dim parametroValor As New CrystalDecisions.Shared.ParameterValues
            parametroDiscretoValor.Value = Parametros(w, 2)
            parametroValor.Add(parametroDiscretoValor)
            Report.DataDefinition.ParameterFields(Parametros(w, 1)).ApplyCurrentValues(parametroValor)
            ' Response.Write(parametros(w, 1) & "<br>")
        Next
    End Sub


    Public Sub SubReporteExportPdf()

        Dim s As System.IO.MemoryStream = CType(Report.ExportToStream(ExportFormatType.PortableDocFormat), MemoryStream)
        With HttpContext.Current.Response
            .ClearContent()
            .ClearHeaders()
            .ContentType = "application/pdf"
            .AddHeader("Content-Disposition", "inline; filename=FO-TESE-CCT-06 " & Now() & ".pdf")
            .BinaryWrite(s.ToArray)
            .End()
        End With

    End Sub
End Class

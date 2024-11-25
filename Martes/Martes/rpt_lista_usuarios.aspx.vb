
Partial Class rpt_lista_usuarios
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Dim principal As New class_principal
        principal.obj_report.NombreReporte = Server.MapPath("reportes/lista_usuarios.rpt")
        principal.obj_report.Configurar()
        principal.obj_report.SubReporteExportPdf()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class

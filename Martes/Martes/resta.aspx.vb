
Partial Class resta
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Dim principal As New class_principal
        principal.obj_operaciones.a = Request.QueryString("v1")
        principal.obj_operaciones.b = Request.QueryString("v2")

        principal.obj_operaciones.sub_resta()


        Me.txt_resultado.Text = principal.obj_operaciones.c



    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class

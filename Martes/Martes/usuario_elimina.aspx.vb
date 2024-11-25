
Partial Class usuario_elimina
    Inherits System.Web.UI.Page
    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        principal.obj_usuario.id_usuario = Request.QueryString("id_usuario")

        principal.obj_usuario.sub_usuario_eliminar()
        Response.Redirect("usuario__inserta_Test.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        End Sub
End Class

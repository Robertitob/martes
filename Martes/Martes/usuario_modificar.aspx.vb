
Partial Class usuario_modificar
    Inherits System.Web.UI.Page
    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        principal.obj_usuario.id_usuario = Request.QueryString("id_usuario")
        principal.obj_usuario.sub_usuario_consultar()

        Me.lb_nombre.Text = principal.obj_usuario.nombre
        Me.lb_fecha_registro.Text = principal.obj_usuario.fecha_registro
        Me.txt_correo.Text = principal.obj_usuario.correo
        Me.lb_id.Text = principal.obj_usuario.id_usuario


    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
 
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        principal.obj_usuario.id_usuario = Me.lb_id.Text
        principal.obj_usuario.correo = Me.txt_correo.Text
        principal.obj_usuario.sub_usuario_modificar()
        Response.Redirect("usuario__inserta_Test.aspx")

    End Sub
End Class

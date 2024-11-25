
Partial Class Profesiones_normal
    Inherits System.Web.UI.Page

    Dim principal As New class_principal
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
         Me.list_profesiones.DataTextField = "profesion"
        Me.list_profesiones.DataValueField = "id_profesion"

        principal.obj_profesiones.sub_profesiones_consultar()

        Me.list_profesiones.DataSource = principal.obj_profesiones.tbl_profesiones_consultar.tabla_llena
        Me.list_profesiones.DataBind()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub list_profesiones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_profesiones.SelectedIndexChanged

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.txt_valor.Text = Me.list_profesiones.SelectedValue

    End Sub
End Class

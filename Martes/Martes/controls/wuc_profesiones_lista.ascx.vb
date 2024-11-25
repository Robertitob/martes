
Partial Class controls_wuc_profesiones_lista
    Inherits System.Web.UI.UserControl
    Dim principal As New class_principal


    Public Function ftn_Lista_valor_seleccionado()
        Return Me.list_profesiones.SelectedValue

    End Function

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Me.list_profesiones.DataTextField = "profesion"
        Me.list_profesiones.DataValueField = "id_profesion"

        principal.obj_profesiones.sub_profesiones_consultar()

        Me.list_profesiones.DataSource = principal.obj_profesiones.tbl_profesiones_consultar.tabla_llena
        Me.list_profesiones.DataBind()
        Me.list_profesiones.SelectedIndex = 0

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class

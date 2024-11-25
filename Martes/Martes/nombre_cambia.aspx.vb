
Partial Class nombre_cambia
    Inherits System.Web.UI.Page

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_valor.TextChanged

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim principal As New class_principal
        Me.txt_valor.Text = principal.obj_Cadenas.ftn_nombre_cambia(Me.txt_valor.Text)

    End Sub
End Class

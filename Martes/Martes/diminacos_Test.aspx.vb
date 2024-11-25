
Partial Class diminacos_Test
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Dim txt_cajas(100) As TextBox
        Dim i As Integer

        For i = 0 To 50
            txt_cajas(i) = New TextBox
            txt_cajas(i).ID = "id_" & i
            txt_cajas(i).Text = i

            Panel1.Controls.Add(txt_cajas(i))


        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class


Partial Class suma
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_valor2.TextChanged

    End Sub

    Protected Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_valor1.TextChanged

    End Sub

    Protected Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_resultado.TextChanged

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim principal As New class_principal


        principal.obj_operaciones.a = Me.txt_valor1.Text
        principal.obj_operaciones.b = Me.txt_valor2.Text

        principal.obj_operaciones.sub_suma()

        Me.txt_resultado.Text = principal.obj_operaciones.c


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.txt_valores.Text = Me.Wuc_profesiones_lista1.ftn_Lista_valor_seleccionado & "," _
        & Me.Wuc_profesiones_lista2.ftn_Lista_valor_seleccionado & "," _
        & Me.Wuc_profesiones_lista3.ftn_Lista_valor_seleccionado & "," _
        & Me.Wuc_profesiones_lista4.ftn_Lista_valor_seleccionado & ","


    End Sub
End Class

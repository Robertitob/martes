
Partial Class usuario__inserta_Test
    Inherits System.Web.UI.Page
    Dim principal As New class_principal

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        principal.obj_usuario.nombre = Me.txt_nombre.Text
        principal.obj_usuario.correo = Me.txt_correo.Text
        principal.obj_usuario.sub_usuario_inserta()
        Response.Redirect("usuario__inserta_Test.aspx")

    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        principal.obj_usuarios.sub_usuarios_consultar()


        Dim columna As New Data.DataColumn
        columna.ColumnName = "eliminar"


        principal.obj_usuarios.tbl_usuarios_consultar.tabla_llena.Columns.Add(columna)


        columna = New Data.DataColumn
        columna.ColumnName = "Modificar"


        principal.obj_usuarios.tbl_usuarios_consultar.tabla_llena.Columns.Add(columna)



        columna = New Data.DataColumn
        columna.ColumnName = "Profesion"


        principal.obj_usuarios.tbl_usuarios_consultar.tabla_llena.Columns.Add(columna)



        Me.GridView1.DataSource = principal.obj_usuarios.tbl_usuarios_consultar.tabla_llena
        Me.GridView1.DataBind()

        Dim i As Integer
        Dim hl_liga As New HyperLink
        Dim wuc_profesion As New ASP.controls_wuc_profesiones_lista_ascx


        For i = 0 To principal.obj_usuarios.tbl_usuarios_consultar.tabla_llena.Rows.Count - 1
            hl_liga = New HyperLink
            hl_liga.ID = "ligae" & i
            hl_liga.Text = "Eliminar"
            hl_liga.NavigateUrl = "usuario_elimina.aspx?id_usuario=" & principal.obj_usuarios.tbl_usuarios_consultar.tabla_llena.Rows(i)("id_usuario").ToString
            Me.GridView1.Rows(i).Cells(4).Controls.Add(hl_liga)

            hl_liga = New HyperLink
            hl_liga.ID = "ligaM" & i
            hl_liga.Text = "Modificar"
            hl_liga.NavigateUrl = "usuario_modificar.aspx?id_usuario=" & principal.obj_usuarios.tbl_usuarios_consultar.tabla_llena.Rows(i)("id_usuario").ToString
            Me.GridView1.Rows(i).Cells(5).Controls.Add(hl_liga)

            wuc_profesion = New ASP.controls_wuc_profesiones_lista_ascx
            wuc_profesion.ID = "wucp" & i
            Me.GridView1.Rows(i).Cells(6).Controls.Add(wuc_profesion)

        Next




    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        principal.obj_usuarios.sub_usuarios_buscar(Me.txt_Cadena.Text)
        Me.GridView2.DataSource = principal.obj_usuarios.tbl_usuarios_buscar.tabla_llena
        Me.GridView2.DataBind()

    End Sub
End Class

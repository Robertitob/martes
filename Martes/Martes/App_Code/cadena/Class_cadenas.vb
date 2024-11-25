Imports Microsoft.VisualBasic

Public Class Class_cadenas

    Public Function ftn_nombre_cambia(ByVal cadena As String)
        cadena = Replace(cadena, "nombre", "name")
        Return cadena
    End Function

End Class

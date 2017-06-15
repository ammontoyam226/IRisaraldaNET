Public Class ConfigIP

    Private Sub ConfigIP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'DUsuarios = New AdoNet("Usuarios", CONN, DbProvedor)
            'DUsuarios.Open("Select * from USUARIOS ")

            'DUsuariosDesc = New AdoSQL("UsuariosDesc")
            'DUsuariosDesc.Open("Select * from USUARIOSDESC order BY posicion ")

            ''Se realiza un ciclo para agregar todos los permisos de la tabla al treview

            'For Each fila As DataRow In DUsuariosDesc.Rows
            '    TVUsuarios.CheckBoxes = True
            '    TVUsuarios.Nodes.Add(fila("DESCRIPCION"))
            'Next

        Catch ex As Exception
            MsgError(ex.ToString)
        End Try
    End Sub
End Class
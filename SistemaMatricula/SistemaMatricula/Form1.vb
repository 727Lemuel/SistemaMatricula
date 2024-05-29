Imports System.Data.OleDb
Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim gato As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=G:\Programacion\2 Parcial\Codigos\Visual Studio\Sistema Matricula\Base de datos\Sistema Matricula.mdb")
        Try
            gato.Open()
            MsgBox("Conectado")

            Dim query = "Select * from Maestros"
            Dim perro As New OleDbDataAdapter(query, gato)
            Dim bs As New DataTable
            perro.Fill(bs)
            DataGridView1.DataSource = bs

        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)
        End Try

    End Sub

    Private Function dt() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscar.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class

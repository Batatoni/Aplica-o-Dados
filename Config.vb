Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports ApplicationBlocks.Data

Public Class Config   
    Public Dim db As Boolean

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        connection.connn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & TextBox1.Text & ";Jet OLEDB:Database Password=" & TextBox2.Text & ";"
        db = True
        testaconexao()
    End Sub
    Private Sub testaconexao()
        Dim con As  IDbConnection = connection.con(db)
        Try
            con.Open
            connection.validator = True
            Me.Close
        Catch ex As Exception
            MessageBox.Show("Erro :" + ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openfile As New OpenFileDialog()
        openfile.Title = "Selecione o arquivo Acess"

        If openfile.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = openfile.FileName
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim server As String = Textip.Text
        Dim banco As String = TextData.Text
        Dim id As String = TextUser.Text
        Dim password As String = TextSenha.Text
        db = False
        connection.connn = "Data Source= "& server &";Initial Catalog= "& banco &";User ID= "& id &" ;Password= "& password  &" ;"
        testaconexao()
    End Sub

    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
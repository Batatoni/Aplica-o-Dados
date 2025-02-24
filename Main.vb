Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Common

Public Class Main
    Public Dim Val As Boolean   
 
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                  
    End Sub
    
    Sub initdatagrid()


            dim conn As DbConnection = Class1.connection.con(Val)
            Dim sql As String = "SELECT * FROM Clientes ORDER BY id desc"

            Dim command As DbCommand = Class1.connection.cmd(Val, sql, conn)
            conn.Open
            
            Dim adapter As DbDataAdapter = Class1.connection.adapter(Val, command)
            
            Dim datatable As New DataTable()
            adapter.fill(datatable)

            DataGridView1.DataSource = datatable
            DataGridView1.Columns(0).Visible = False
            conn.Close
       

    End Sub

    Private Sub Att_Click(sender As Object, e As EventArgs) Handles Att.Click
         If Class1.connection.validator = True Then            
            initdatagrid()
      Else
            MessageBox.Show("Erro de conexâo")
        End If
        
    End Sub

    Private Sub Config_Click(sender As Object, e As EventArgs) Handles Config.Click
        Dim config As new Config()
        config.Owner = Me
        config.ShowDialog()       
        Val = config.db
        
    End Sub

    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Del.Click
        If DataGridView1.SelectedRows.Count>0 Then
            If Class1.connection.validator = True Then
                dim id As Integer 
                id = DataGridView1.SelectedRows(0).Cells(0).Value
                Dim conn As  DbConnection = Class1.connection.con(Val)
                Dim sql As String = "DELETE FROM Clientes WHERE id = "& id &""

                Dim command As DbCommand = Class1.connection.cmd(Val, sql, conn)
                conn.Open
                command.ExecuteNonQuery
                conn.Close
                initdatagrid
            Else
                MessageBox.Show("Erro de conexâo")
            End If
        Else
            MessageBox.Show("Nenhuma linha selecionada")
        End If
        

    End Sub

    Private Sub Novo_Click(sender As Object, e As EventArgs) Handles Novo.Click
        
        If Class1.connection.validator = True Then
        
            Dim conn As DbConnection = Class1.connection.con(Val)
            Dim sql As String = "INSERT INTO Clientes (Nome, Ender, Cel, Tel, Email)" &
                                "Values (@param1, @param2, @param3, @param4, @param5)"

            Dim command As DbCommand  = Class1.connection.cmd(Val, sql, conn)
            
        
            conn.Open
            
            InsertValuesInData(command)
            
            command.ExecuteNonQuery
            conn.Close
            TextBox6.Text = ""
            initdatagrid
            TextBox6.Text = DataGridView1.Rows(0).Cells(0).Value
        Else
            MessageBox.Show("Erro de conexâo")
        End If
    End Sub

    Private Sub InsertValuesInData(cmd As DbCommand)
        
        If TypeOf cmd Is OleDbCommand then
            Dim c As OleDbCommand = DirectCast(cmd, OleDbCommand)
            c.Parameters.AddWithValue("@param1", TextBox1.Text)
            c.Parameters.AddWithValue("@param2", TextBox2.Text)
            c.Parameters.AddWithValue("@param3", TextBox4.Text)
            c.Parameters.AddWithValue("@param4", TextBox3.Text)
            c.Parameters.AddWithValue("@param5", TextBox5.Text)
            Else
                Dim c As SqlCommand = DirectCast(cmd, SqlCommand)
                c.Parameters.AddWithValue("@param1", TextBox1.Text)
                c.Parameters.AddWithValue("@param2", TextBox2.Text)
                c.Parameters.AddWithValue("@param3", TextBox4.Text)
                c.Parameters.AddWithValue("@param4", TextBox3.Text)
                c.Parameters.AddWithValue("@param5", TextBox5.Text)
        End If

    End Sub
    
    
    
    Private Sub Sair_Click(sender As Object, e As EventArgs) Handles Sair.Click
        Me.Close
    End Sub
    
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
          
        If Class1.connection.validator = True Then
            If TextBox6.Text <> "" Then
                Dim conn As DbConnection = Class1.connection.con(Val)
                Dim sql As String = "UPDATE Clientes SET Nome = @param1, Ender = @param2, Cel = @param3, Tel = @param4, Email = @param5 WHERE id = "& TextBox6.Text &" "

                Dim command As DbCommand = Class1.connection.cmd(Val, sql, conn)
                conn.Open
                
                InsertValuesInData(command)

                command.ExecuteNonQuery
                conn.Close
                initdatagrid
            Else
                MessageBox.Show("nenhuma linha selecionada, para carregar os valores de uma linha click duas vezez da primeria coluna da linha desejada")
            End If
        Else
            MessageBox.Show("Erro de conexâo")
        End If

    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            If DataGridView1.SelectedRows.Count > 0 Then
            TextBox6.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            TextBox1.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            TextBox2.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            TextBox4.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            TextBox3.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            TextBox5.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            End If        
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
       
        Dim relatorio As New Form1
        relatorio.Val = Val
        relatorio.ShowDialog

    End Sub
End Class

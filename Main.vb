Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Common
Imports ApplicationBlocks.Data

Public Class Main
    Public Dim Val As Boolean   
    Public Dim ds As DataSet 
    Public Dim conn As IDbConnection
 
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                  
    End Sub
    
    Sub initdatagrid()

            Dim dss As DataSet
            conn = connection.con(Val)
            Dim sql As String = "SELECT * FROM Clientes ORDER BY id desc"
            
            conn.Open
           
           dss = connection.m_dbHelper.ExecuteDataset(conn, CommandType.Text, sql)

            DataGridView1.DataSource = dss.Tables(0)
            DataGridView1.Columns(0).Visible = False
            conn.Close
       

    End Sub

    Private Sub Att_Click(sender As Object, e As EventArgs) Handles Att.Click
         If connection.validator = True Then            
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
            If connection.validator = True Then

                dim id As Integer 
                id = DataGridView1.SelectedRows(0).Cells(0).Value

                Dim sql As String = "DELETE FROM Clientes WHERE id = "& id &""


                conn.Open
                Dim affected = connection.m_dbHelper.ExecuteNonQuery(conn, CommandType.Text,sql)
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
        
        If connection.validator = True Then
        
            Dim sql As String = "INSERT INTO Clientes (Nome, Ender, Cel, Tel, Email)" &
                                "Values (@param1, @param2, @param3, @param4, @param5)"

            conn.Open
            
           Dim params As IDataParameter() =  InsertValuesInData()
           Dim affected = connection.m_dbHelper.ExecuteNonQuery(conn, CommandType.Text, sql, params)

            conn.Close
            initdatagrid()

            TextBox6.Text = ""
            TextBox6.Text = DataGridView1.Rows(0).Cells(0).Value
        Else
            MessageBox.Show("Erro de conexâo")
        End If
    End Sub

    Private function InsertValuesInData()

       Dim param1 = connection.m_dbHelper.NewParameter("@param1", DbType.String, CObj(TextBox1.Text))
       Dim param2 = connection.m_dbHelper.NewParameter("@param2", DbType.String, CObj(TextBox2.Text))
       Dim param3 = connection.m_dbHelper.NewParameter("@param3", DbType.String, CObj(TextBox4.Text))
       Dim param4 = connection.m_dbHelper.NewParameter("@param4", DbType.String, CObj(TextBox3.Text))
       Dim param5 = connection.m_dbHelper.NewParameter("@param5", DbType.String, CObj(TextBox5.Text))
       Return New IDataParameter() {param1, param2, param3, param4, param5}

    End function
    
    
    
    Private Sub Sair_Click(sender As Object, e As EventArgs) Handles Sair.Click
        Me.Close
    End Sub
    
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
          
        If connection.validator = True Then
            If TextBox6.Text <> "" Then

                Dim sql As String = "UPDATE Clientes SET Nome = @param1, Ender = @param2, Cel = @param3, Tel = @param4, Email = @param5 WHERE id = "& TextBox6.Text &" "

                conn.Open
                
              Dim params As IDataParameter() =  InsertValuesInData()
              Dim affected = connection.m_dbHelper.ExecuteNonQuery(conn, CommandType.Text, sql, params)


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

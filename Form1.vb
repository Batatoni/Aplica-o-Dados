Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common

Public Class Form1
   
    public dim Val As Boolean
    
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As IDbConnection = connection.con(Val)
        Dim Sql As String = "SELECT * FROM Clientes"
       

        Dim ds As DataSet

        con.Open()

        ds = connection.m_dbHelper.ExecuteDataset(con, CommandType.Text, sql)
        
        Dim rpt As New CrystalReport1
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt'
    End Sub
End Class
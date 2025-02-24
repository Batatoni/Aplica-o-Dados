Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common

Public Class Form1
   
    public dim Val As Boolean
    
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As DbConnection = Class1.connection.con(Val)
        Dim Sql As String = "SELECT * FROM Clientes"
        Dim command As DbCommand = Class1.connection.cmd(Val, Sql, con)
        Dim adap As DbDataAdapter = Class1.connection.adapter(Val, command)
        Dim ds As DataSet

        con.Open()
        ds = New DataSet
        adap.Fill(ds, "Clientes")
        
        Dim rpt As New CrystalReport1
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt'
    End Sub
End Class
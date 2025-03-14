Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports ApplicationBlocks.Data

    Public Class connection
        Public shared Property connn As String
        Public Shared Property validator As Boolean = False
        Public Shared Property m_dbHelper As IDBHelper

         shared public Function con(ByVal wich As Boolean) As DbConnection
            Dim m_dbConn As IDbConnection
            
            If (wich = True)
                Dim OleDBDbHelper As New OleDBDbHelper
                m_dbHelper = OleDBDbHelper
                m_dbConn = oleDBDbHelper.NewConnection(connn)
               
                Return m_dbConn
               
            Else
                Dim sqlDbHelper As New SqlDbHelper
                m_dbHelper = sqlDbHelper
                m_dbConn = sqlDbHelper.NewConnection(connn)
                Return m_dbConn
            End If
        End Function

        shared public Function cmd (ByVal wich As Boolean, ByVal sql As String, ByVal conn As DbConnection)As DbCommand
            If (wich = true)
                Return New OleDbCommand(sql, conn)
                Else
                Return New SqlCommand(sql, conn)
            End If
        End Function

        Public Shared Function adapter (ByVal wich As Boolean, ByVal command As DbCommand) As DbDataAdapter
            If (wich = True)
                Return New OleDbDataAdapter(command)
                Else
                Return New SqlDataAdapter(command)
            End If
        End Function
    End Class

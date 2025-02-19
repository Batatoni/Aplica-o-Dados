Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Class1
  
    Class connection
        Public shared Property connn As String
        Public Shared Property validator As Boolean = False

         shared public Function con(ByVal wich As Boolean) As DbConnection
            If (wich = True)
                Return new OleDbConnection(connn)
                Else
                Return New SqlConnection(connn)
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
End Class

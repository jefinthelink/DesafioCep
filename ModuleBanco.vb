Imports System.Data.SqlClient
Module ModuleBanco
    Private objConexao As SqlClient.SqlConnection
    ReadOnly stringConexao = "Data Source=(localDB)\SSGP; Integrated Security=False; Initial Catalog=db_banco; User ID=Keye; PassWord=123456"


    Public Function ExecuteQuery(sql As String) As DataTable
        Try
            Using objConexao = New SqlClient.SqlConnection(stringConexao)
                objConexao.Open()

                Using da = New SqlDataAdapter(sql, objConexao)
                    Dim tabela As DataTable = New DataTable
                    da.Fill(tabela)
                    Return tabela

                End Using

            End Using





        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Sub desconectar()
        Try
            If Not IsNothing(objConexao) Then
                If objConexao.State = ConnectionState.Open Then
                    objConexao.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub





End Module

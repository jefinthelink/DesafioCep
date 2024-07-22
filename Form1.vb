Public Class Form1
    Private idSelecionado As Integer = New Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click
        Try

            ModuleBanco.ExecuteQuery("INSERT INTO dbo.cep_endereco
           (cep
           ,logradouro
           ,bairro
           ,cidade
           ,uf)
     VALUES
           ('" & TextBoxCep.Text & "',
           '" & TextBoxEndereco.Text & "',
           '" & TextBoxBairro.Text & "',
           '" & TextBoxCidade.Text & "',
           '" & TextBoxUf.Text & "')")
            MessageBox.Show("Inserido ao banco de dados")
            atualizaTabela()
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir no banco de dados")
        End Try


    End Sub

    Private Sub ButtonConsultar_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        If TextBoxCep.Text.Equals("") Then
            MessageBox.Show("Informe um cep valido")
        Else
            Dim endereco As cep = ModuleApi.cep.ObterEndereco(TextBoxCep.Text.Trim())

            TextBoxEndereco.Text = endereco.logradouro
            TextBoxCidade.Text = endereco.localidade
            TextBoxBairro.Text = endereco.bairro
            TextBoxUf.Text = endereco.uf
            ButtonSalvar.Enabled = True
            ButtonEditar.Enabled = False
            ButtonExcluir.Enabled = False
        End If
    End Sub



    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        atualizaTabela()
    End Sub

    Private Sub DataGridViewBanco_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewBanco.CellMouseClick

        Dim teste2 As DataTable = DataGridViewBanco.DataSource
        enableTextBoxs(True)
        ButtonEditar.Enabled = True
        ButtonExcluir.Enabled = True

        idSelecionado = teste2.Rows(e.RowIndex).Item(0)
        TextBoxCep.Text = teste2.Rows(e.RowIndex).Item(1).ToString.Trim()
        TextBoxEndereco.Text = teste2.Rows(e.RowIndex).Item(2).ToString.Trim()
        TextBoxBairro.Text = teste2.Rows(e.RowIndex).Item(3).ToString.Trim()
        TextBoxCidade.Text = teste2.Rows(e.RowIndex).Item(4).ToString.Trim()
        TextBoxUf.Text = teste2.Rows(e.RowIndex).Item(5).ToString.Trim()

        ' MessageBox.Show(teste2.Rows(e.RowIndex).Item(1))



    End Sub

    Private Sub enableTextBoxs(value As Boolean)
        TextBoxEndereco.Enabled = value
        TextBoxBairro.Enabled = value
        TextBoxCidade.Enabled = value
        TextBoxUf.Enabled = value

    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        'enableTextBoxs(True)
        ' ButtonSalvar.Enabled = True

        Try
            ModuleBanco.ExecuteQuery("UPDATE dbo.cep_endereco
   SET cep = '" & TextBoxCep.Text & "',
      logradouro = '" & TextBoxEndereco.Text & "',
      bairro = '" & TextBoxBairro.Text & "',
      cidade = '" & TextBoxCidade.Text & "',
      uf = '" & TextBoxUf.Text & "'
 WHERE id = " & idSelecionado & "")

            MessageBox.Show("Item com id = " & idSelecionado & " alterado no banco de dados")
            atualizaTabela()
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar item com id = " & idSelecionado & " no banco de dados")
        End Try


    End Sub

    Private Sub ButtonExcluir_Click(sender As Object, e As EventArgs) Handles ButtonExcluir.Click

        If MessageBox.Show("Deseja mesmo excluir o item da tabela com id = " & idSelecionado & " ?", "", MessageBoxButtons.OKCancel) = DialogResult.OK Then

            Try

                ModuleBanco.ExecuteQuery("DELETE FROM dbo.cep_endereco
      WHERE id = " & idSelecionado & "")
                atualizaTabela()

            Catch ex As Exception

            End Try

        End If






    End Sub

    Private Sub atualizaTabela()
        Dim tabelaBanco As DataTable = ModuleBanco.ExecuteQuery("SELECT * FROM dbo.cep_endereco")
        DataGridViewBanco.DataSource = tabelaBanco
    End Sub
End Class

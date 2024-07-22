<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelCep = New System.Windows.Forms.Label()
        Me.TextBoxCep = New System.Windows.Forms.TextBox()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.LabelEndereco = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonExcluir = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.TextBoxUf = New System.Windows.Forms.TextBox()
        Me.LabelUf = New System.Windows.Forms.Label()
        Me.TextBoxCidade = New System.Windows.Forms.TextBox()
        Me.LabelCidade = New System.Windows.Forms.Label()
        Me.TextBoxBairro = New System.Windows.Forms.TextBox()
        Me.LabelBairro = New System.Windows.Forms.Label()
        Me.TextBoxEndereco = New System.Windows.Forms.TextBox()
        Me.DataGridViewBanco = New System.Windows.Forms.DataGridView()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelCep
        '
        Me.LabelCep.AutoSize = True
        Me.LabelCep.Location = New System.Drawing.Point(35, 29)
        Me.LabelCep.Name = "LabelCep"
        Me.LabelCep.Size = New System.Drawing.Size(37, 17)
        Me.LabelCep.TabIndex = 0
        Me.LabelCep.Text = "Cep:"
        '
        'TextBoxCep
        '
        Me.TextBoxCep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCep.Location = New System.Drawing.Point(79, 29)
        Me.TextBoxCep.Name = "TextBoxCep"
        Me.TextBoxCep.Size = New System.Drawing.Size(240, 22)
        Me.TextBoxCep.TabIndex = 1
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConsultar.Location = New System.Drawing.Point(346, 28)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConsultar.TabIndex = 2
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = True
        '
        'LabelEndereco
        '
        Me.LabelEndereco.AutoSize = True
        Me.LabelEndereco.Location = New System.Drawing.Point(23, 34)
        Me.LabelEndereco.Name = "LabelEndereco"
        Me.LabelEndereco.Size = New System.Drawing.Size(73, 17)
        Me.LabelEndereco.TabIndex = 3
        Me.LabelEndereco.Text = "Endereço:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ButtonSelect)
        Me.Panel1.Controls.Add(Me.ButtonExcluir)
        Me.Panel1.Controls.Add(Me.ButtonEditar)
        Me.Panel1.Controls.Add(Me.ButtonSalvar)
        Me.Panel1.Controls.Add(Me.TextBoxUf)
        Me.Panel1.Controls.Add(Me.LabelUf)
        Me.Panel1.Controls.Add(Me.TextBoxCidade)
        Me.Panel1.Controls.Add(Me.LabelCidade)
        Me.Panel1.Controls.Add(Me.TextBoxBairro)
        Me.Panel1.Controls.Add(Me.LabelBairro)
        Me.Panel1.Controls.Add(Me.TextBoxEndereco)
        Me.Panel1.Controls.Add(Me.LabelEndereco)
        Me.Panel1.Location = New System.Drawing.Point(12, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 316)
        Me.Panel1.TabIndex = 4
        '
        'ButtonExcluir
        '
        Me.ButtonExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonExcluir.Enabled = False
        Me.ButtonExcluir.Location = New System.Drawing.Point(353, 269)
        Me.ButtonExcluir.Name = "ButtonExcluir"
        Me.ButtonExcluir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExcluir.TabIndex = 12
        Me.ButtonExcluir.Text = "Excluir"
        Me.ButtonExcluir.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonEditar.Enabled = False
        Me.ButtonEditar.Location = New System.Drawing.Point(272, 269)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditar.TabIndex = 11
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSalvar.Enabled = False
        Me.ButtonSalvar.Location = New System.Drawing.Point(191, 269)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalvar.TabIndex = 5
        Me.ButtonSalvar.Text = "inserir"
        Me.ButtonSalvar.UseVisualStyleBackColor = True
        '
        'TextBoxUf
        '
        Me.TextBoxUf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxUf.Location = New System.Drawing.Point(103, 192)
        Me.TextBoxUf.Name = "TextBoxUf"
        Me.TextBoxUf.Size = New System.Drawing.Size(268, 22)
        Me.TextBoxUf.TabIndex = 10
        '
        'LabelUf
        '
        Me.LabelUf.AutoSize = True
        Me.LabelUf.Location = New System.Drawing.Point(23, 192)
        Me.LabelUf.Name = "LabelUf"
        Me.LabelUf.Size = New System.Drawing.Size(26, 17)
        Me.LabelUf.TabIndex = 9
        Me.LabelUf.Text = "Uf:"
        '
        'TextBoxCidade
        '
        Me.TextBoxCidade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCidade.Location = New System.Drawing.Point(103, 140)
        Me.TextBoxCidade.Name = "TextBoxCidade"
        Me.TextBoxCidade.Size = New System.Drawing.Size(268, 22)
        Me.TextBoxCidade.TabIndex = 8
        '
        'LabelCidade
        '
        Me.LabelCidade.AutoSize = True
        Me.LabelCidade.Location = New System.Drawing.Point(23, 140)
        Me.LabelCidade.Name = "LabelCidade"
        Me.LabelCidade.Size = New System.Drawing.Size(56, 17)
        Me.LabelCidade.TabIndex = 7
        Me.LabelCidade.Text = "Cidade:"
        '
        'TextBoxBairro
        '
        Me.TextBoxBairro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBairro.Location = New System.Drawing.Point(103, 84)
        Me.TextBoxBairro.Name = "TextBoxBairro"
        Me.TextBoxBairro.Size = New System.Drawing.Size(268, 22)
        Me.TextBoxBairro.TabIndex = 6
        '
        'LabelBairro
        '
        Me.LabelBairro.AutoSize = True
        Me.LabelBairro.Location = New System.Drawing.Point(23, 84)
        Me.LabelBairro.Name = "LabelBairro"
        Me.LabelBairro.Size = New System.Drawing.Size(50, 17)
        Me.LabelBairro.TabIndex = 5
        Me.LabelBairro.Text = "Bairro:"
        '
        'TextBoxEndereco
        '
        Me.TextBoxEndereco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEndereco.Location = New System.Drawing.Point(103, 34)
        Me.TextBoxEndereco.Name = "TextBoxEndereco"
        Me.TextBoxEndereco.Size = New System.Drawing.Size(268, 22)
        Me.TextBoxEndereco.TabIndex = 4
        '
        'DataGridViewBanco
        '
        Me.DataGridViewBanco.AllowUserToAddRows = False
        Me.DataGridViewBanco.AllowUserToDeleteRows = False
        Me.DataGridViewBanco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewBanco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBanco.Location = New System.Drawing.Point(12, 416)
        Me.DataGridViewBanco.MultiSelect = False
        Me.DataGridViewBanco.Name = "DataGridViewBanco"
        Me.DataGridViewBanco.ReadOnly = True
        Me.DataGridViewBanco.RowHeadersWidth = 51
        Me.DataGridViewBanco.RowTemplate.Height = 24
        Me.DataGridViewBanco.ShowCellToolTips = False
        Me.DataGridViewBanco.ShowEditingIcon = False
        Me.DataGridViewBanco.Size = New System.Drawing.Size(441, 160)
        Me.DataGridViewBanco.TabIndex = 5
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSelect.Location = New System.Drawing.Point(8, 269)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(132, 23)
        Me.ButtonSelect.TabIndex = 13
        Me.ButtonSelect.Text = "Buscar no banco"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'MySqlDataAdapter1
        '
        Me.MySqlDataAdapter1.DeleteCommand = Nothing
        Me.MySqlDataAdapter1.InsertCommand = Nothing
        Me.MySqlDataAdapter1.SelectCommand = Nothing
        Me.MySqlDataAdapter1.UpdateCommand = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 588)
        Me.Controls.Add(Me.DataGridViewBanco)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonConsultar)
        Me.Controls.Add(Me.TextBoxCep)
        Me.Controls.Add(Me.LabelCep)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCep As Label
    Friend WithEvents TextBoxCep As TextBox
    Friend WithEvents ButtonConsultar As Button
    Friend WithEvents LabelEndereco As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxEndereco As TextBox
    Friend WithEvents TextBoxBairro As TextBox
    Friend WithEvents LabelBairro As Label
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents TextBoxUf As TextBox
    Friend WithEvents LabelUf As Label
    Friend WithEvents TextBoxCidade As TextBox
    Friend WithEvents LabelCidade As Label
    Friend WithEvents ButtonExcluir As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents DataGridViewBanco As DataGridView
    Friend WithEvents ButtonSelect As Button
    Friend WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
End Class

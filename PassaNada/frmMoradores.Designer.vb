<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoradores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnFechar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCadastro = New System.Windows.Forms.Label()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblWhatsapp = New System.Windows.Forms.Label()
        Me.txtResponsavel = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtWhatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtLogradouro = New System.Windows.Forms.MaskedTextBox()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.MaskedTextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.MaskedTextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.MaskedTextBox()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.mnNovo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalvar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExcluir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNovo, Me.mnSalvar, Me.mnExcluir, Me.mnFechar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnFechar
        '
        Me.mnFechar.Image = Global.PassaNada.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Close_2_32
        Me.mnFechar.Name = "mnFechar"
        Me.mnFechar.Size = New System.Drawing.Size(54, 35)
        Me.mnFechar.Text = "&Fechar"
        Me.mnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lblCadastro
        '
        Me.lblCadastro.AutoSize = True
        Me.lblCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadastro.Location = New System.Drawing.Point(12, 51)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(70, 16)
        Me.lblCadastro.TabIndex = 1
        Me.lblCadastro.Text = "Cadastro"
        '
        'lblResponsavel
        '
        Me.lblResponsavel.AutoSize = True
        Me.lblResponsavel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsavel.Location = New System.Drawing.Point(105, 77)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Size = New System.Drawing.Size(81, 15)
        Me.lblResponsavel.TabIndex = 2
        Me.lblResponsavel.Text = "Responsável:"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpf.Location = New System.Drawing.Point(317, 77)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(33, 15)
        Me.lblCpf.TabIndex = 5
        Me.lblCpf.Text = "CPF:"
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.AutoSize = True
        Me.lblWhatsapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsapp.Location = New System.Drawing.Point(458, 77)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(65, 15)
        Me.lblWhatsapp.TabIndex = 7
        Me.lblWhatsapp.Text = "Whatsapp:"
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(108, 95)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(203, 20)
        Me.txtResponsavel.TabIndex = 9
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(314, 95)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(135, 20)
        Me.txtCpf.TabIndex = 10
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(461, 95)
        Me.txtWhatsapp.Mask = "(00)0,000-0000"
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(96, 20)
        Me.txtWhatsapp.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(563, 77)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 15)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "E-mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(563, 95)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(222, 20)
        Me.txtEmail.TabIndex = 13
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(12, 137)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(296, 20)
        Me.txtLogradouro.TabIndex = 15
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogradouro.Location = New System.Drawing.Point(12, 119)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(74, 15)
        Me.lblLogradouro.TabIndex = 14
        Me.lblLogradouro.Text = "Logradouro:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(314, 137)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero.TabIndex = 17
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(317, 119)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(55, 15)
        Me.lblNumero.TabIndex = 16
        Me.lblNumero.Text = "Número:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(455, 137)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(330, 20)
        Me.MaskedTextBox1.TabIndex = 20
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(455, 119)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(88, 15)
        Me.lblComplemento.TabIndex = 19
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(660, 185)
        Me.txtCep.Mask = "00000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(125, 20)
        Me.txtCep.TabIndex = 26
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.Location = New System.Drawing.Point(657, 167)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(34, 15)
        Me.lblCep.TabIndex = 25
        Me.lblCep.Text = "CEP:"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(309, 186)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(197, 20)
        Me.MaskedTextBox3.TabIndex = 24
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(310, 168)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(49, 15)
        Me.lblCidade.TabIndex = 23
        Me.lblCidade.Text = "Cidade:"
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(12, 186)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(291, 20)
        Me.MaskedTextBox4.TabIndex = 22
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(12, 168)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 15)
        Me.lblBairro.TabIndex = 21
        Me.lblBairro.Text = "Bairro:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"AC, Acre", "AL, Alagoas", "AP, Amapá", "AM, Amazonas", "BA, Bahia", "CE, Ceará", "DF, Distrito Federal", "ES, Espirito Santo", "GO, Goiás", "MA, Maranhão", "MS, Mato Grosso do Sul", "MT, Mato Grosso", "MG, Minas Gerais", "PA, Pará", "PB, Paraíba", "PR, Paraná", "PE, Pernambuco", "PI, Piauí", "RJ, Rio de Janeiro", "RN, Rio Grande do Norte", "RS, Rio Grande do Sul", "RO, Rondônia", "RR, Roraima", "SC, Santa Catarina", "SP, São Paulo", "SE, Sergipe", "TO, Tocantins"})
        Me.cbEstado.Location = New System.Drawing.Point(512, 184)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(142, 21)
        Me.cbEstado.TabIndex = 27
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(509, 166)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(48, 15)
        Me.lblEstado.TabIndex = 28
        Me.lblEstado.Text = "Estado:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(512, 254)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(179, 20)
        Me.txtBuscar.TabIndex = 30
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(509, 236)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(48, 15)
        Me.lblBuscar.TabIndex = 29
        Me.lblBuscar.Text = "Buscar:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(710, 251)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(12, 95)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(90, 20)
        Me.txtCod.TabIndex = 32
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.Location = New System.Drawing.Point(9, 77)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(32, 15)
        Me.lblCod.TabIndex = 33
        Me.lblCod.Text = "Cod:"
        '
        'mnNovo
        '
        Me.mnNovo.Image = Global.PassaNada.My.Resources.Resources.Aha_Soft_Free_3d_Glossy_Interface_Create_32
        Me.mnNovo.Name = "mnNovo"
        Me.mnNovo.Size = New System.Drawing.Size(48, 35)
        Me.mnNovo.Text = "&Novo"
        Me.mnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnSalvar
        '
        Me.mnSalvar.Image = Global.PassaNada.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_document_save_32
        Me.mnSalvar.Name = "mnSalvar"
        Me.mnSalvar.Size = New System.Drawing.Size(50, 35)
        Me.mnSalvar.Text = "&Salvar"
        Me.mnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnExcluir
        '
        Me.mnExcluir.Image = Global.PassaNada.My.Resources.Resources.Wwalczyszyn_Iwindows_Recycle_Bin_32
        Me.mnExcluir.Name = "mnExcluir"
        Me.mnExcluir.Size = New System.Drawing.Size(54, 35)
        Me.mnExcluir.Text = "&Excluir"
        Me.mnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMoradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.lblComplemento)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtLogradouro)
        Me.Controls.Add(Me.lblLogradouro)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtWhatsapp)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtResponsavel)
        Me.Controls.Add(Me.lblWhatsapp)
        Me.Controls.Add(Me.lblCpf)
        Me.Controls.Add(Me.lblResponsavel)
        Me.Controls.Add(Me.lblCadastro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMoradores"
        Me.Text = "Moradores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnNovo As ToolStripMenuItem
    Friend WithEvents mnSalvar As ToolStripMenuItem
    Friend WithEvents mnExcluir As ToolStripMenuItem
    Friend WithEvents mnFechar As ToolStripMenuItem
    Friend WithEvents lblCadastro As Label
    Friend WithEvents lblResponsavel As Label
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblWhatsapp As Label
    Friend WithEvents txtResponsavel As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtWhatsapp As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As MaskedTextBox
    Friend WithEvents txtLogradouro As MaskedTextBox
    Friend WithEvents lblLogradouro As Label
    Friend WithEvents txtNumero As MaskedTextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents lblCep As Label
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents txtBuscar As MaskedTextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCod As MaskedTextBox
    Friend WithEvents lblCod As Label
End Class

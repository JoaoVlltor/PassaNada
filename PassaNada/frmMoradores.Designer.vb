<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMoradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoradores))
        Me.lblCod = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.MaskedTextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.MaskedTextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.MaskedTextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.MaskedTextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.MaskedTextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.MaskedTextBox()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtWhatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtResponsavel = New System.Windows.Forms.MaskedTextBox()
        Me.lblWhatsapp = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.lblCadastro = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExcluir = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.Location = New System.Drawing.Point(11, 83)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(31, 15)
        Me.lblCod.TabIndex = 61
        Me.lblCod.Text = "Cod:"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(14, 101)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(90, 22)
        Me.txtCod.TabIndex = 60
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(712, 247)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 59
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(527, 247)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(179, 22)
        Me.txtBuscar.TabIndex = 58
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(524, 229)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(45, 15)
        Me.lblBuscar.TabIndex = 57
        Me.lblBuscar.Text = "Buscar:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(642, 177)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 15)
        Me.lblEstado.TabIndex = 56
        Me.lblEstado.Text = "Estado:"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cmbEstado.Location = New System.Drawing.Point(645, 195)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(142, 21)
        Me.cmbEstado.TabIndex = 55
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(311, 195)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(328, 22)
        Me.txtCidade.TabIndex = 52
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(308, 177)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(46, 15)
        Me.lblCidade.TabIndex = 51
        Me.lblCidade.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(14, 195)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(291, 22)
        Me.txtBairro.TabIndex = 50
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(11, 177)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(41, 15)
        Me.lblBairro.TabIndex = 49
        Me.lblBairro.Text = "Bairro:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(457, 143)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(330, 22)
        Me.txtComplemento.TabIndex = 48
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(457, 125)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(86, 15)
        Me.lblComplemento.TabIndex = 47
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(316, 143)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(135, 22)
        Me.txtNumero.TabIndex = 46
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(313, 125)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(54, 15)
        Me.lblNumero.TabIndex = 45
        Me.lblNumero.Text = "Número:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(14, 143)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(296, 22)
        Me.txtLogradouro.TabIndex = 44
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogradouro.Location = New System.Drawing.Point(11, 125)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(72, 15)
        Me.lblLogradouro.TabIndex = 43
        Me.lblLogradouro.Text = "Logradouro:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(565, 101)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(222, 22)
        Me.txtEmail.TabIndex = 42
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(565, 83)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(44, 15)
        Me.lblEmail.TabIndex = 41
        Me.lblEmail.Text = "E-mail:"
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(463, 101)
        Me.txtWhatsapp.Mask = "(00)0000-00000"
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(96, 22)
        Me.txtWhatsapp.TabIndex = 40
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(322, 101)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(135, 22)
        Me.txtCpf.TabIndex = 39
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(110, 101)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(203, 22)
        Me.txtResponsavel.TabIndex = 38
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.AutoSize = True
        Me.lblWhatsapp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsapp.Location = New System.Drawing.Point(460, 83)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(64, 15)
        Me.lblWhatsapp.TabIndex = 37
        Me.lblWhatsapp.Text = "Whatsapp:"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpf.Location = New System.Drawing.Point(319, 83)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(30, 15)
        Me.lblCpf.TabIndex = 36
        Me.lblCpf.Text = "CPF:"
        '
        'lblResponsavel
        '
        Me.lblResponsavel.AutoSize = True
        Me.lblResponsavel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsavel.Location = New System.Drawing.Point(107, 83)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Size = New System.Drawing.Size(75, 15)
        Me.lblResponsavel.TabIndex = 35
        Me.lblResponsavel.Text = "Responsável:"
        '
        'lblCadastro
        '
        Me.lblCadastro.AutoSize = True
        Me.lblCadastro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadastro.Location = New System.Drawing.Point(10, 49)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(77, 21)
        Me.lblCadastro.TabIndex = 34
        Me.lblCadastro.Text = "Cadastro"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.mnExcluir, Me.FecharToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 62
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Image = CType(resources.GetObject("NovoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.NovoToolStripMenuItem.Text = "&Novo"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Image = CType(resources.GetObject("SalvarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.SalvarToolStripMenuItem.Text = "&Salvar"
        '
        'mnExcluir
        '
        Me.mnExcluir.Image = CType(resources.GetObject("mnExcluir.Image"), System.Drawing.Image)
        Me.mnExcluir.Name = "mnExcluir"
        Me.mnExcluir.Size = New System.Drawing.Size(70, 20)
        Me.mnExcluir.Text = "&Excluir"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Image = CType(resources.GetObject("FecharToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.FecharToolStripMenuItem.Text = "&Fechar"
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvDados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsvDados.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.HideSelection = False
        Me.lsvDados.Location = New System.Drawing.Point(0, 276)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(800, 207)
        Me.lsvDados.TabIndex = 63
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Responsável"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CPF"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "WhatsApp"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "E-mail"
        Me.ColumnHeader5.Width = 186
        '
        'frmMoradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 483)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.txtComplemento)
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
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMoradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PassaNada | Moradores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCod As Label
    Friend WithEvents txtCod As MaskedTextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As MaskedTextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtCidade As MaskedTextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtBairro As MaskedTextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtComplemento As MaskedTextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtNumero As MaskedTextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtLogradouro As MaskedTextBox
    Friend WithEvents lblLogradouro As Label
    Friend WithEvents txtEmail As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtWhatsapp As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtResponsavel As MaskedTextBox
    Friend WithEvents lblWhatsapp As Label
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblResponsavel As Label
    Friend WithEvents lblCadastro As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnExcluir As ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lsvDados As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class

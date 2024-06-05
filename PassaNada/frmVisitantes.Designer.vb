<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVisitantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisitantes))
        Me.gbVisitante = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtVeiculo = New System.Windows.Forms.MaskedTextBox()
        Me.lblVeiculo = New System.Windows.Forms.Label()
        Me.imgFoto = New System.Windows.Forms.PictureBox()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.MaskedTextBox()
        Me.txtWhatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtVisitante = New System.Windows.Forms.MaskedTextBox()
        Me.lblWhatsapp = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblVisitante = New System.Windows.Forms.Label()
        Me.gbMoradores = New System.Windows.Forms.GroupBox()
        Me.cmbMorador = New System.Windows.Forms.ComboBox()
        Me.txtWhatsappM = New System.Windows.Forms.MaskedTextBox()
        Me.lblWhatsappM = New System.Windows.Forms.Label()
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
        Me.lblMorador = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnNovo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalvar = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbVisitante.SuspendLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMoradores.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbVisitante
        '
        Me.gbVisitante.Controls.Add(Me.Button1)
        Me.gbVisitante.Controls.Add(Me.txtVeiculo)
        Me.gbVisitante.Controls.Add(Me.lblVeiculo)
        Me.gbVisitante.Controls.Add(Me.imgFoto)
        Me.gbVisitante.Controls.Add(Me.lblCod)
        Me.gbVisitante.Controls.Add(Me.txtCod)
        Me.gbVisitante.Controls.Add(Me.txtWhatsapp)
        Me.gbVisitante.Controls.Add(Me.txtCpf)
        Me.gbVisitante.Controls.Add(Me.txtVisitante)
        Me.gbVisitante.Controls.Add(Me.lblWhatsapp)
        Me.gbVisitante.Controls.Add(Me.lblCpf)
        Me.gbVisitante.Controls.Add(Me.lblVisitante)
        Me.gbVisitante.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVisitante.Location = New System.Drawing.Point(12, 27)
        Me.gbVisitante.Name = "gbVisitante"
        Me.gbVisitante.Size = New System.Drawing.Size(775, 216)
        Me.gbVisitante.TabIndex = 0
        Me.gbVisitante.TabStop = False
        Me.gbVisitante.Text = "Dados Visitante:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 30)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Foto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtVeiculo
        '
        Me.txtVeiculo.Location = New System.Drawing.Point(199, 102)
        Me.txtVeiculo.Mask = ">LLL-0A00"
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.Size = New System.Drawing.Size(90, 22)
        Me.txtVeiculo.TabIndex = 72
        '
        'lblVeiculo
        '
        Me.lblVeiculo.AutoSize = True
        Me.lblVeiculo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeiculo.Location = New System.Drawing.Point(196, 84)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.Size = New System.Drawing.Size(49, 15)
        Me.lblVeiculo.TabIndex = 71
        Me.lblVeiculo.Text = "Veiculo:"
        '
        'imgFoto
        '
        Me.imgFoto.BackgroundImage = CType(resources.GetObject("imgFoto.BackgroundImage"), System.Drawing.Image)
        Me.imgFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgFoto.Location = New System.Drawing.Point(19, 19)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(142, 143)
        Me.imgFoto.TabIndex = 70
        Me.imgFoto.TabStop = False
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.Location = New System.Drawing.Point(196, 41)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(31, 15)
        Me.lblCod.TabIndex = 69
        Me.lblCod.Text = "Cod:"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(199, 59)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(90, 22)
        Me.txtCod.TabIndex = 68
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(648, 59)
        Me.txtWhatsapp.Mask = "(00)0000-00000"
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(96, 22)
        Me.txtWhatsapp.TabIndex = 67
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(507, 59)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(135, 22)
        Me.txtCpf.TabIndex = 66
        '
        'txtVisitante
        '
        Me.txtVisitante.Location = New System.Drawing.Point(295, 59)
        Me.txtVisitante.Name = "txtVisitante"
        Me.txtVisitante.Size = New System.Drawing.Size(203, 22)
        Me.txtVisitante.TabIndex = 65
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.AutoSize = True
        Me.lblWhatsapp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsapp.Location = New System.Drawing.Point(645, 41)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(64, 15)
        Me.lblWhatsapp.TabIndex = 64
        Me.lblWhatsapp.Text = "Whatsapp:"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpf.Location = New System.Drawing.Point(504, 41)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(30, 15)
        Me.lblCpf.TabIndex = 63
        Me.lblCpf.Text = "CPF:"
        '
        'lblVisitante
        '
        Me.lblVisitante.AutoSize = True
        Me.lblVisitante.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitante.Location = New System.Drawing.Point(292, 41)
        Me.lblVisitante.Name = "lblVisitante"
        Me.lblVisitante.Size = New System.Drawing.Size(56, 15)
        Me.lblVisitante.TabIndex = 62
        Me.lblVisitante.Text = "Visitante:"
        '
        'gbMoradores
        '
        Me.gbMoradores.Controls.Add(Me.cmbMorador)
        Me.gbMoradores.Controls.Add(Me.txtWhatsappM)
        Me.gbMoradores.Controls.Add(Me.lblWhatsappM)
        Me.gbMoradores.Controls.Add(Me.txtCidade)
        Me.gbMoradores.Controls.Add(Me.lblCidade)
        Me.gbMoradores.Controls.Add(Me.txtBairro)
        Me.gbMoradores.Controls.Add(Me.lblBairro)
        Me.gbMoradores.Controls.Add(Me.txtComplemento)
        Me.gbMoradores.Controls.Add(Me.lblComplemento)
        Me.gbMoradores.Controls.Add(Me.txtNumero)
        Me.gbMoradores.Controls.Add(Me.lblNumero)
        Me.gbMoradores.Controls.Add(Me.txtLogradouro)
        Me.gbMoradores.Controls.Add(Me.lblLogradouro)
        Me.gbMoradores.Controls.Add(Me.lblMorador)
        Me.gbMoradores.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMoradores.Location = New System.Drawing.Point(12, 249)
        Me.gbMoradores.Name = "gbMoradores"
        Me.gbMoradores.Size = New System.Drawing.Size(775, 189)
        Me.gbMoradores.TabIndex = 1
        Me.gbMoradores.TabStop = False
        Me.gbMoradores.Text = "Dados Morador:"
        '
        'cmbMorador
        '
        Me.cmbMorador.FormattingEnabled = True
        Me.cmbMorador.Location = New System.Drawing.Point(19, 35)
        Me.cmbMorador.Name = "cmbMorador"
        Me.cmbMorador.Size = New System.Drawing.Size(197, 21)
        Me.cmbMorador.TabIndex = 76
        '
        'txtWhatsappM
        '
        Me.txtWhatsappM.Location = New System.Drawing.Point(228, 35)
        Me.txtWhatsappM.Mask = "(00)0,000-0000"
        Me.txtWhatsappM.Name = "txtWhatsappM"
        Me.txtWhatsappM.ReadOnly = True
        Me.txtWhatsappM.Size = New System.Drawing.Size(99, 22)
        Me.txtWhatsappM.TabIndex = 75
        '
        'lblWhatsappM
        '
        Me.lblWhatsappM.AutoSize = True
        Me.lblWhatsappM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsappM.Location = New System.Drawing.Point(225, 17)
        Me.lblWhatsappM.Name = "lblWhatsappM"
        Me.lblWhatsappM.Size = New System.Drawing.Size(64, 15)
        Me.lblWhatsappM.TabIndex = 74
        Me.lblWhatsappM.Text = "Whatsapp:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(19, 93)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.ReadOnly = True
        Me.txtCidade.Size = New System.Drawing.Size(197, 22)
        Me.txtCidade.TabIndex = 71
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(16, 75)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(46, 15)
        Me.lblCidade.TabIndex = 70
        Me.lblCidade.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(558, 93)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.ReadOnly = True
        Me.txtBairro.Size = New System.Drawing.Size(202, 22)
        Me.txtBairro.TabIndex = 69
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(555, 75)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(41, 15)
        Me.lblBairro.TabIndex = 68
        Me.lblBairro.Text = "Bairro:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(222, 93)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.ReadOnly = True
        Me.txtComplemento.Size = New System.Drawing.Size(330, 22)
        Me.txtComplemento.TabIndex = 67
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(222, 75)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(86, 15)
        Me.lblComplemento.TabIndex = 66
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(634, 35)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(135, 22)
        Me.txtNumero.TabIndex = 65
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(631, 17)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(54, 15)
        Me.lblNumero.TabIndex = 64
        Me.lblNumero.Text = "Número:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(333, 35)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.ReadOnly = True
        Me.txtLogradouro.Size = New System.Drawing.Size(296, 22)
        Me.txtLogradouro.TabIndex = 46
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogradouro.Location = New System.Drawing.Point(330, 17)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(72, 15)
        Me.lblLogradouro.TabIndex = 45
        Me.lblLogradouro.Text = "Logradouro:"
        '
        'lblMorador
        '
        Me.lblMorador.AutoSize = True
        Me.lblMorador.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMorador.Location = New System.Drawing.Point(16, 17)
        Me.lblMorador.Name = "lblMorador"
        Me.lblMorador.Size = New System.Drawing.Size(56, 15)
        Me.lblMorador.TabIndex = 42
        Me.lblMorador.Text = "Morador:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNovo, Me.mnSalvar, Me.FecharToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 63
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnNovo
        '
        Me.mnNovo.Image = CType(resources.GetObject("mnNovo.Image"), System.Drawing.Image)
        Me.mnNovo.Name = "mnNovo"
        Me.mnNovo.Size = New System.Drawing.Size(64, 20)
        Me.mnNovo.Text = "&Novo"
        '
        'mnSalvar
        '
        Me.mnSalvar.Image = CType(resources.GetObject("mnSalvar.Image"), System.Drawing.Image)
        Me.mnSalvar.Name = "mnSalvar"
        Me.mnSalvar.Size = New System.Drawing.Size(66, 20)
        Me.mnSalvar.Text = "&Salvar"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Image = CType(resources.GetObject("FecharToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.FecharToolStripMenuItem.Text = "&Fechar"
        '
        'frmVisitantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbMoradores)
        Me.Controls.Add(Me.gbVisitante)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisitantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PassaNada | Visitantes"
        Me.gbVisitante.ResumeLayout(False)
        Me.gbVisitante.PerformLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMoradores.ResumeLayout(False)
        Me.gbMoradores.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbVisitante As GroupBox
    Friend WithEvents gbMoradores As GroupBox
    Friend WithEvents imgFoto As PictureBox
    Friend WithEvents lblCod As Label
    Friend WithEvents txtCod As MaskedTextBox
    Friend WithEvents txtWhatsapp As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtVisitante As MaskedTextBox
    Friend WithEvents lblWhatsapp As Label
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblVisitante As Label
    Friend WithEvents lblMorador As Label
    Friend WithEvents txtLogradouro As MaskedTextBox
    Friend WithEvents lblLogradouro As Label
    Friend WithEvents txtVeiculo As MaskedTextBox
    Friend WithEvents lblVeiculo As Label
    Friend WithEvents txtCidade As MaskedTextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtBairro As MaskedTextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtComplemento As MaskedTextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtNumero As MaskedTextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtWhatsappM As MaskedTextBox
    Friend WithEvents lblWhatsappM As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbMorador As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnNovo As ToolStripMenuItem
    Friend WithEvents mnSalvar As ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As ToolStripMenuItem
End Class

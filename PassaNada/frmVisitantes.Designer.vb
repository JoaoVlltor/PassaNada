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
        Me.MaskedTextBox7 = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.MaskedTextBox()
        Me.txtWhatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtResponsavel = New System.Windows.Forms.MaskedTextBox()
        Me.lblWhatsapp = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.gbMoradores = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.MaskedTextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.MaskedTextBox()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbVisitante.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMoradores.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbVisitante
        '
        Me.gbVisitante.Controls.Add(Me.Button1)
        Me.gbVisitante.Controls.Add(Me.MaskedTextBox7)
        Me.gbVisitante.Controls.Add(Me.Label4)
        Me.gbVisitante.Controls.Add(Me.PictureBox1)
        Me.gbVisitante.Controls.Add(Me.lblCod)
        Me.gbVisitante.Controls.Add(Me.txtCod)
        Me.gbVisitante.Controls.Add(Me.txtWhatsapp)
        Me.gbVisitante.Controls.Add(Me.txtCpf)
        Me.gbVisitante.Controls.Add(Me.txtResponsavel)
        Me.gbVisitante.Controls.Add(Me.lblWhatsapp)
        Me.gbVisitante.Controls.Add(Me.lblCpf)
        Me.gbVisitante.Controls.Add(Me.lblResponsavel)
        Me.gbVisitante.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVisitante.Location = New System.Drawing.Point(12, 12)
        Me.gbVisitante.Name = "gbVisitante"
        Me.gbVisitante.Size = New System.Drawing.Size(775, 204)
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
        'MaskedTextBox7
        '
        Me.MaskedTextBox7.Location = New System.Drawing.Point(199, 102)
        Me.MaskedTextBox7.Name = "MaskedTextBox7"
        Me.MaskedTextBox7.Size = New System.Drawing.Size(203, 22)
        Me.MaskedTextBox7.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Veiculo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(19, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 143)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
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
        Me.txtWhatsapp.Mask = "(00)0,000-0000"
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
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(295, 59)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(203, 22)
        Me.txtResponsavel.TabIndex = 65
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
        'lblResponsavel
        '
        Me.lblResponsavel.AutoSize = True
        Me.lblResponsavel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsavel.Location = New System.Drawing.Point(292, 41)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Size = New System.Drawing.Size(56, 15)
        Me.lblResponsavel.TabIndex = 62
        Me.lblResponsavel.Text = "Visitante:"
        '
        'gbMoradores
        '
        Me.gbMoradores.Controls.Add(Me.MaskedTextBox1)
        Me.gbMoradores.Controls.Add(Me.Label1)
        Me.gbMoradores.Controls.Add(Me.txtCep)
        Me.gbMoradores.Controls.Add(Me.lblCep)
        Me.gbMoradores.Controls.Add(Me.MaskedTextBox4)
        Me.gbMoradores.Controls.Add(Me.lblCidade)
        Me.gbMoradores.Controls.Add(Me.MaskedTextBox5)
        Me.gbMoradores.Controls.Add(Me.lblBairro)
        Me.gbMoradores.Controls.Add(Me.MaskedTextBox6)
        Me.gbMoradores.Controls.Add(Me.lblComplemento)
        Me.gbMoradores.Controls.Add(Me.txtNumero)
        Me.gbMoradores.Controls.Add(Me.lblNumero)
        Me.gbMoradores.Controls.Add(Me.txtLogradouro)
        Me.gbMoradores.Controls.Add(Me.lblLogradouro)
        Me.gbMoradores.Controls.Add(Me.MaskedTextBox2)
        Me.gbMoradores.Controls.Add(Me.Label2)
        Me.gbMoradores.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMoradores.Location = New System.Drawing.Point(12, 222)
        Me.gbMoradores.Name = "gbMoradores"
        Me.gbMoradores.Size = New System.Drawing.Size(775, 216)
        Me.gbMoradores.TabIndex = 1
        Me.gbMoradores.TabStop = False
        Me.gbMoradores.Text = "Dados Morador:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(228, 35)
        Me.MaskedTextBox1.Mask = "(00)0,000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.ReadOnly = True
        Me.MaskedTextBox1.Size = New System.Drawing.Size(99, 22)
        Me.MaskedTextBox1.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Whatsapp:"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(635, 35)
        Me.txtCep.Mask = "00000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.ReadOnly = True
        Me.txtCep.Size = New System.Drawing.Size(125, 22)
        Me.txtCep.TabIndex = 73
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.Location = New System.Drawing.Point(632, 17)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(30, 15)
        Me.lblCep.TabIndex = 72
        Me.lblCep.Text = "CEP:"
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(19, 93)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.ReadOnly = True
        Me.MaskedTextBox4.Size = New System.Drawing.Size(197, 22)
        Me.MaskedTextBox4.TabIndex = 71
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
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Location = New System.Drawing.Point(558, 93)
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.ReadOnly = True
        Me.MaskedTextBox5.Size = New System.Drawing.Size(202, 22)
        Me.MaskedTextBox5.TabIndex = 69
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
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Location = New System.Drawing.Point(222, 93)
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.ReadOnly = True
        Me.MaskedTextBox6.Size = New System.Drawing.Size(330, 22)
        Me.MaskedTextBox6.TabIndex = 67
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
        Me.txtNumero.Location = New System.Drawing.Point(19, 140)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(135, 22)
        Me.txtNumero.TabIndex = 65
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(16, 122)
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
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(19, 35)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(203, 22)
        Me.MaskedTextBox2.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Morador:"
        '
        'frmVisitantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbMoradores)
        Me.Controls.Add(Me.gbVisitante)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisitantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PassaNada | Visitantes"
        Me.gbVisitante.ResumeLayout(False)
        Me.gbVisitante.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMoradores.ResumeLayout(False)
        Me.gbMoradores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbVisitante As GroupBox
    Friend WithEvents gbMoradores As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCod As Label
    Friend WithEvents txtCod As MaskedTextBox
    Friend WithEvents txtWhatsapp As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtResponsavel As MaskedTextBox
    Friend WithEvents lblWhatsapp As Label
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblResponsavel As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLogradouro As MaskedTextBox
    Friend WithEvents lblLogradouro As Label
    Friend WithEvents MaskedTextBox7 As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents lblCep As Label
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtNumero As MaskedTextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class

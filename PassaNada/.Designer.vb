<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.imgLogin = New System.Windows.Forms.PictureBox()
        CType(Me.imgLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmail.Location = New System.Drawing.Point(217, 190)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 20)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "E-mail:"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblSenha.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.Location = New System.Drawing.Point(217, 248)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(55, 20)
        Me.lblSenha.TabIndex = 2
        Me.lblSenha.Text = "Senha:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(221, 213)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(191, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(220, 271)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(192, 20)
        Me.txtSenha.TabIndex = 4
        '
        'btnLimpar
        '
        Me.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLimpar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Location = New System.Drawing.Point(220, 351)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(94, 35)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnEntrar
        '
        Me.btnEntrar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.Black
        Me.btnEntrar.Location = New System.Drawing.Point(317, 351)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(94, 35)
        Me.btnEntrar.TabIndex = 7
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'imgLogin
        '
        Me.imgLogin.BackColor = System.Drawing.Color.Transparent
        Me.imgLogin.BackgroundImage = CType(resources.GetObject("imgLogin.BackgroundImage"), System.Drawing.Image)
        Me.imgLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgLogin.Location = New System.Drawing.Point(202, 12)
        Me.imgLogin.Name = "imgLogin"
        Me.imgLogin.Size = New System.Drawing.Size(210, 175)
        Me.imgLogin.TabIndex = 5
        Me.imgLogin.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(631, 436)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.imgLogin)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblEmail)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PassaNada | Login"
        CType(Me.imgLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnEntrar As Button
    Friend WithEvents imgLogin As PictureBox
End Class

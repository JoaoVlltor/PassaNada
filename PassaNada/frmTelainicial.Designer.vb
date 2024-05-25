<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelaInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelaInicial))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.VisitantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHistorico = New System.Windows.Forms.Button()
        Me.btnMoradores = New System.Windows.Forms.Button()
        Me.BtnVisitantes = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitantesToolStripMenuItem, Me.HistóricoToolStripMenuItem, Me.MoradoresToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 39)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'VisitantesToolStripMenuItem
        '
        Me.VisitantesToolStripMenuItem.Image = CType(resources.GetObject("VisitantesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VisitantesToolStripMenuItem.Name = "VisitantesToolStripMenuItem"
        Me.VisitantesToolStripMenuItem.Size = New System.Drawing.Size(69, 35)
        Me.VisitantesToolStripMenuItem.Text = "&Visitantes"
        Me.VisitantesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'HistóricoToolStripMenuItem
        '
        Me.HistóricoToolStripMenuItem.Image = CType(resources.GetObject("HistóricoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistóricoToolStripMenuItem.Name = "HistóricoToolStripMenuItem"
        Me.HistóricoToolStripMenuItem.Size = New System.Drawing.Size(67, 35)
        Me.HistóricoToolStripMenuItem.Text = "&Histórico"
        Me.HistóricoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MoradoresToolStripMenuItem
        '
        Me.MoradoresToolStripMenuItem.Image = CType(resources.GetObject("MoradoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoradoresToolStripMenuItem.Name = "MoradoresToolStripMenuItem"
        Me.MoradoresToolStripMenuItem.Size = New System.Drawing.Size(76, 35)
        Me.MoradoresToolStripMenuItem.Text = "&Moradores"
        Me.MoradoresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Image = CType(resources.GetObject("FecharToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(54, 35)
        Me.FecharToolStripMenuItem.Text = "&Fechar"
        Me.FecharToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(266, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(534, 346)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnHistorico
        '
        Me.btnHistorico.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorico.Image = CType(resources.GetObject("btnHistorico.Image"), System.Drawing.Image)
        Me.btnHistorico.Location = New System.Drawing.Point(7, 280)
        Me.btnHistorico.Name = "btnHistorico"
        Me.btnHistorico.Size = New System.Drawing.Size(253, 101)
        Me.btnHistorico.TabIndex = 8
        Me.btnHistorico.Text = "Historico"
        Me.btnHistorico.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHistorico.UseVisualStyleBackColor = True
        '
        'btnMoradores
        '
        Me.btnMoradores.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoradores.Image = CType(resources.GetObject("btnMoradores.Image"), System.Drawing.Image)
        Me.btnMoradores.Location = New System.Drawing.Point(7, 66)
        Me.btnMoradores.Name = "btnMoradores"
        Me.btnMoradores.Size = New System.Drawing.Size(253, 102)
        Me.btnMoradores.TabIndex = 7
        Me.btnMoradores.Text = "Moradores"
        Me.btnMoradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMoradores.UseVisualStyleBackColor = True
        '
        'BtnVisitantes
        '
        Me.BtnVisitantes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisitantes.Image = CType(resources.GetObject("BtnVisitantes.Image"), System.Drawing.Image)
        Me.BtnVisitantes.Location = New System.Drawing.Point(7, 174)
        Me.BtnVisitantes.Name = "BtnVisitantes"
        Me.BtnVisitantes.Size = New System.Drawing.Size(253, 100)
        Me.BtnVisitantes.TabIndex = 6
        Me.BtnVisitantes.Text = "Visitantes"
        Me.BtnVisitantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVisitantes.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripUsuario
        '
        Me.ToolStripUsuario.Name = "ToolStripUsuario"
        Me.ToolStripUsuario.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripUsuario.Text = "ToolStripStatusLabel1"
        '
        'frmTelaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHistorico)
        Me.Controls.Add(Me.btnMoradores)
        Me.Controls.Add(Me.BtnVisitantes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTelaInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PassaNada | Tela Inicial"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents VisitantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoradoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHistorico As Button
    Friend WithEvents btnMoradores As Button
    Friend WithEvents BtnVisitantes As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripUsuario As ToolStripStatusLabel
End Class

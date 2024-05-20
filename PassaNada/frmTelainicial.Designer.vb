<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelainicial
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHistorico = New System.Windows.Forms.Button()
        Me.btnMoradores = New System.Windows.Forms.Button()
        Me.BtnVisitantes = New System.Windows.Forms.Button()
        Me.VisitantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 39)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitantesToolStripMenuItem, Me.HistóricoToolStripMenuItem, Me.MoradoresToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 39)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PassaNada.My.Resources.Resources.t
        Me.PictureBox1.Location = New System.Drawing.Point(271, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(539, 414)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnHistorico
        '
        Me.btnHistorico.Image = Global.PassaNada.My.Resources.Resources.Treetog_Junior_Folder_documents_32
        Me.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHistorico.Location = New System.Drawing.Point(12, 265)
        Me.btnHistorico.Name = "btnHistorico"
        Me.btnHistorico.Size = New System.Drawing.Size(253, 101)
        Me.btnHistorico.TabIndex = 2
        Me.btnHistorico.Text = "Historico"
        Me.btnHistorico.UseVisualStyleBackColor = True
        '
        'btnMoradores
        '
        Me.btnMoradores.Image = Global.PassaNada.My.Resources.Resources.Awicons_Vista_Artistic_4_Disabled_Home_32
        Me.btnMoradores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoradores.Location = New System.Drawing.Point(12, 51)
        Me.btnMoradores.Name = "btnMoradores"
        Me.btnMoradores.Size = New System.Drawing.Size(253, 102)
        Me.btnMoradores.TabIndex = 1
        Me.btnMoradores.Text = "Moradores"
        Me.btnMoradores.UseVisualStyleBackColor = True
        '
        'BtnVisitantes
        '
        Me.BtnVisitantes.Image = Global.PassaNada.My.Resources.Resources.Pictogrammers_Material_Exit_run_32
        Me.BtnVisitantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnVisitantes.Location = New System.Drawing.Point(12, 159)
        Me.BtnVisitantes.Name = "BtnVisitantes"
        Me.BtnVisitantes.Size = New System.Drawing.Size(253, 100)
        Me.BtnVisitantes.TabIndex = 0
        Me.BtnVisitantes.Text = "Visitantes"
        Me.BtnVisitantes.UseVisualStyleBackColor = True
        '
        'VisitantesToolStripMenuItem
        '
        Me.VisitantesToolStripMenuItem.Image = Global.PassaNada.My.Resources.Resources.Pictogrammers_Material_Exit_run_32
        Me.VisitantesToolStripMenuItem.Name = "VisitantesToolStripMenuItem"
        Me.VisitantesToolStripMenuItem.Size = New System.Drawing.Size(69, 35)
        Me.VisitantesToolStripMenuItem.Text = "&Visitantes"
        Me.VisitantesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'HistóricoToolStripMenuItem
        '
        Me.HistóricoToolStripMenuItem.Image = Global.PassaNada.My.Resources.Resources.Treetog_Junior_Folder_documents_32
        Me.HistóricoToolStripMenuItem.Name = "HistóricoToolStripMenuItem"
        Me.HistóricoToolStripMenuItem.Size = New System.Drawing.Size(67, 35)
        Me.HistóricoToolStripMenuItem.Text = "&Histórico"
        Me.HistóricoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MoradoresToolStripMenuItem
        '
        Me.MoradoresToolStripMenuItem.Image = Global.PassaNada.My.Resources.Resources.Awicons_Vista_Artistic_4_Disabled_Home_32
        Me.MoradoresToolStripMenuItem.Name = "MoradoresToolStripMenuItem"
        Me.MoradoresToolStripMenuItem.Size = New System.Drawing.Size(76, 35)
        Me.MoradoresToolStripMenuItem.Text = "&Moradores"
        Me.MoradoresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Image = Global.PassaNada.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Close_2_32
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(54, 35)
        Me.FecharToolStripMenuItem.Text = "&Fechar"
        Me.FecharToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmTelainicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHistorico)
        Me.Controls.Add(Me.btnMoradores)
        Me.Controls.Add(Me.BtnVisitantes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTelainicial"
        Me.Text = "Tela Inicial"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVisitantes As Button
    Friend WithEvents btnMoradores As Button
    Friend WithEvents btnHistorico As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents VisitantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoradoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As ToolStripMenuItem
End Class

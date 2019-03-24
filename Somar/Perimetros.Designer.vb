<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perimetros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRetan = New System.Windows.Forms.Button()
        Me.btnCirculo = New System.Windows.Forms.Button()
        Me.btnQuadrado = New System.Windows.Forms.Button()
        Me.btnTriangulo = New System.Windows.Forms.Button()
        Me.lblPeri = New System.Windows.Forms.Label()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txbQuad = New System.Windows.Forms.TextBox()
        Me.txbTri = New System.Windows.Forms.TextBox()
        Me.TxbRet = New System.Windows.Forms.TextBox()
        Me.TxbCirc = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NúmerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabuadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRetan
        '
        Me.btnRetan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetan.Location = New System.Drawing.Point(79, 261)
        Me.btnRetan.Name = "btnRetan"
        Me.btnRetan.Size = New System.Drawing.Size(283, 171)
        Me.btnRetan.TabIndex = 38
        Me.btnRetan.Text = "&Retângulo"
        Me.btnRetan.UseVisualStyleBackColor = True
        '
        'btnCirculo
        '
        Me.btnCirculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCirculo.Location = New System.Drawing.Point(441, 261)
        Me.btnCirculo.Name = "btnCirculo"
        Me.btnCirculo.Size = New System.Drawing.Size(283, 171)
        Me.btnCirculo.TabIndex = 37
        Me.btnCirculo.Text = "&Círculo"
        Me.btnCirculo.UseVisualStyleBackColor = True
        '
        'btnQuadrado
        '
        Me.btnQuadrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuadrado.Location = New System.Drawing.Point(79, 84)
        Me.btnQuadrado.Name = "btnQuadrado"
        Me.btnQuadrado.Size = New System.Drawing.Size(283, 171)
        Me.btnQuadrado.TabIndex = 35
        Me.btnQuadrado.Text = "&Quadrado"
        Me.btnQuadrado.UseVisualStyleBackColor = True
        '
        'btnTriangulo
        '
        Me.btnTriangulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTriangulo.Location = New System.Drawing.Point(441, 84)
        Me.btnTriangulo.Name = "btnTriangulo"
        Me.btnTriangulo.Size = New System.Drawing.Size(283, 171)
        Me.btnTriangulo.TabIndex = 36
        Me.btnTriangulo.Text = "&Triângulo"
        Me.btnTriangulo.UseVisualStyleBackColor = True
        '
        'lblPeri
        '
        Me.lblPeri.AutoSize = True
        Me.lblPeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeri.Location = New System.Drawing.Point(338, 40)
        Me.lblPeri.Name = "lblPeri"
        Me.lblPeri.Size = New System.Drawing.Size(145, 31)
        Me.lblPeri.TabIndex = 39
        Me.lblPeri.Text = "Perimetros"
        '
        'BtnMenu
        '
        Me.BtnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenu.Location = New System.Drawing.Point(132, 438)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(193, 73)
        Me.BtnMenu.TabIndex = 41
        Me.BtnMenu.Text = "&Menu"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(461, 438)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(244, 73)
        Me.btnSair.TabIndex = 40
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'txbQuad
        '
        Me.txbQuad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbQuad.Location = New System.Drawing.Point(90, 190)
        Me.txbQuad.Name = "txbQuad"
        Me.txbQuad.ReadOnly = True
        Me.txbQuad.Size = New System.Drawing.Size(262, 26)
        Me.txbQuad.TabIndex = 48
        Me.txbQuad.Visible = False
        '
        'txbTri
        '
        Me.txbTri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTri.Location = New System.Drawing.Point(461, 190)
        Me.txbTri.Name = "txbTri"
        Me.txbTri.ReadOnly = True
        Me.txbTri.Size = New System.Drawing.Size(244, 26)
        Me.txbTri.TabIndex = 49
        Me.txbTri.Visible = False
        '
        'TxbRet
        '
        Me.TxbRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbRet.Location = New System.Drawing.Point(90, 375)
        Me.TxbRet.Name = "TxbRet"
        Me.TxbRet.ReadOnly = True
        Me.TxbRet.Size = New System.Drawing.Size(262, 26)
        Me.TxbRet.TabIndex = 50
        Me.TxbRet.Visible = False
        '
        'TxbCirc
        '
        Me.TxbCirc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbCirc.Location = New System.Drawing.Point(461, 375)
        Me.TxbCirc.Name = "TxbCirc"
        Me.TxbCirc.ReadOnly = True
        Me.TxbCirc.Size = New System.Drawing.Size(242, 26)
        Me.TxbCirc.TabIndex = 51
        Me.TxbCirc.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.GeometriaToolStripMenuItem, Me.NúmerosToolStripMenuItem, Me.TabuadaToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 29)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(104, 25)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'GeometriaToolStripMenuItem
        '
        Me.GeometriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÁreasToolStripMenuItem})
        Me.GeometriaToolStripMenuItem.Name = "GeometriaToolStripMenuItem"
        Me.GeometriaToolStripMenuItem.Size = New System.Drawing.Size(95, 25)
        Me.GeometriaToolStripMenuItem.Text = "Geometria"
        '
        'ÁreasToolStripMenuItem
        '
        Me.ÁreasToolStripMenuItem.Name = "ÁreasToolStripMenuItem"
        Me.ÁreasToolStripMenuItem.Size = New System.Drawing.Size(119, 26)
        Me.ÁreasToolStripMenuItem.Text = "Áreas"
        '
        'NúmerosToolStripMenuItem
        '
        Me.NúmerosToolStripMenuItem.Name = "NúmerosToolStripMenuItem"
        Me.NúmerosToolStripMenuItem.Size = New System.Drawing.Size(87, 25)
        Me.NúmerosToolStripMenuItem.Text = "Números"
        '
        'TabuadaToolStripMenuItem
        '
        Me.TabuadaToolStripMenuItem.Name = "TabuadaToolStripMenuItem"
        Me.TabuadaToolStripMenuItem.Size = New System.Drawing.Size(79, 25)
        Me.TabuadaToolStripMenuItem.Text = "Tabuada"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(62, 25)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'Perimetros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.TxbCirc)
        Me.Controls.Add(Me.TxbRet)
        Me.Controls.Add(Me.txbTri)
        Me.Controls.Add(Me.txbQuad)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblPeri)
        Me.Controls.Add(Me.btnRetan)
        Me.Controls.Add(Me.btnCirculo)
        Me.Controls.Add(Me.btnQuadrado)
        Me.Controls.Add(Me.btnTriangulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Perimetros"
        Me.Text = "Perimetros"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRetan As Button
    Friend WithEvents btnCirculo As Button
    Friend WithEvents btnQuadrado As Button
    Friend WithEvents btnTriangulo As Button
    Friend WithEvents lblPeri As Label
    Friend WithEvents BtnMenu As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents txbQuad As TextBox
    Friend WithEvents txbTri As TextBox
    Friend WithEvents TxbRet As TextBox
    Friend WithEvents TxbCirc As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÁreasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NúmerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabuadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
End Class

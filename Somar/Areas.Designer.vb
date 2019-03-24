<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Areas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnRetan = New System.Windows.Forms.Button()
        Me.btnCirculo = New System.Windows.Forms.Button()
        Me.btnQuadrado = New System.Windows.Forms.Button()
        Me.btnTriangulo = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txbQuad = New System.Windows.Forms.TextBox()
        Me.txbRet = New System.Windows.Forms.TextBox()
        Me.txbTri = New System.Windows.Forms.TextBox()
        Me.txbCirc = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerimetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NúmerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabuadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(353, 48)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(85, 31)
        Me.lblArea.TabIndex = 44
        Me.lblArea.Text = "Áreas"
        '
        'btnRetan
        '
        Me.btnRetan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetan.Location = New System.Drawing.Point(73, 271)
        Me.btnRetan.Name = "btnRetan"
        Me.btnRetan.Size = New System.Drawing.Size(283, 171)
        Me.btnRetan.TabIndex = 43
        Me.btnRetan.Text = "&Retângulo"
        Me.btnRetan.UseVisualStyleBackColor = True
        '
        'btnCirculo
        '
        Me.btnCirculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCirculo.Location = New System.Drawing.Point(435, 271)
        Me.btnCirculo.Name = "btnCirculo"
        Me.btnCirculo.Size = New System.Drawing.Size(283, 171)
        Me.btnCirculo.TabIndex = 42
        Me.btnCirculo.Text = "&Círculo"
        Me.btnCirculo.UseVisualStyleBackColor = True
        '
        'btnQuadrado
        '
        Me.btnQuadrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuadrado.Location = New System.Drawing.Point(73, 94)
        Me.btnQuadrado.Name = "btnQuadrado"
        Me.btnQuadrado.Size = New System.Drawing.Size(283, 171)
        Me.btnQuadrado.TabIndex = 40
        Me.btnQuadrado.Text = "&Quadrado"
        Me.btnQuadrado.UseVisualStyleBackColor = True
        '
        'btnTriangulo
        '
        Me.btnTriangulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTriangulo.Location = New System.Drawing.Point(435, 94)
        Me.btnTriangulo.Name = "btnTriangulo"
        Me.btnTriangulo.Size = New System.Drawing.Size(283, 171)
        Me.btnTriangulo.TabIndex = 41
        Me.btnTriangulo.Text = "&Triângulo"
        Me.btnTriangulo.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenu.Location = New System.Drawing.Point(122, 474)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(193, 73)
        Me.BtnMenu.TabIndex = 46
        Me.BtnMenu.Text = "&Menu"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(456, 474)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(244, 73)
        Me.btnSair.TabIndex = 45
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'txbQuad
        '
        Me.txbQuad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbQuad.Location = New System.Drawing.Point(84, 201)
        Me.txbQuad.Name = "txbQuad"
        Me.txbQuad.ReadOnly = True
        Me.txbQuad.Size = New System.Drawing.Size(262, 26)
        Me.txbQuad.TabIndex = 47
        Me.txbQuad.Visible = False
        '
        'txbRet
        '
        Me.txbRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbRet.Location = New System.Drawing.Point(84, 385)
        Me.txbRet.Name = "txbRet"
        Me.txbRet.ReadOnly = True
        Me.txbRet.Size = New System.Drawing.Size(262, 26)
        Me.txbRet.TabIndex = 48
        Me.txbRet.Visible = False
        '
        'txbTri
        '
        Me.txbTri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTri.Location = New System.Drawing.Point(447, 201)
        Me.txbTri.Name = "txbTri"
        Me.txbTri.ReadOnly = True
        Me.txbTri.Size = New System.Drawing.Size(262, 26)
        Me.txbTri.TabIndex = 49
        Me.txbTri.Visible = False
        '
        'txbCirc
        '
        Me.txbCirc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCirc.Location = New System.Drawing.Point(447, 385)
        Me.txbCirc.Name = "txbCirc"
        Me.txbCirc.ReadOnly = True
        Me.txbCirc.Size = New System.Drawing.Size(262, 26)
        Me.txbCirc.TabIndex = 50
        Me.txbCirc.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.GeometriaToolStripMenuItem, Me.NúmerosToolStripMenuItem, Me.TabuadasToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 29)
        Me.MenuStrip1.TabIndex = 51
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
        Me.GeometriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerimetrosToolStripMenuItem})
        Me.GeometriaToolStripMenuItem.Name = "GeometriaToolStripMenuItem"
        Me.GeometriaToolStripMenuItem.Size = New System.Drawing.Size(95, 25)
        Me.GeometriaToolStripMenuItem.Text = "Geometria"
        '
        'PerimetrosToolStripMenuItem
        '
        Me.PerimetrosToolStripMenuItem.Name = "PerimetrosToolStripMenuItem"
        Me.PerimetrosToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.PerimetrosToolStripMenuItem.Text = "Perimetros"
        '
        'NúmerosToolStripMenuItem
        '
        Me.NúmerosToolStripMenuItem.Name = "NúmerosToolStripMenuItem"
        Me.NúmerosToolStripMenuItem.Size = New System.Drawing.Size(87, 25)
        Me.NúmerosToolStripMenuItem.Text = "Números"
        '
        'TabuadasToolStripMenuItem
        '
        Me.TabuadasToolStripMenuItem.Name = "TabuadasToolStripMenuItem"
        Me.TabuadasToolStripMenuItem.Size = New System.Drawing.Size(86, 25)
        Me.TabuadasToolStripMenuItem.Text = "Tabuadas"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(62, 25)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'Areas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 576)
        Me.Controls.Add(Me.txbCirc)
        Me.Controls.Add(Me.txbTri)
        Me.Controls.Add(Me.txbRet)
        Me.Controls.Add(Me.txbQuad)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.btnRetan)
        Me.Controls.Add(Me.btnCirculo)
        Me.Controls.Add(Me.btnQuadrado)
        Me.Controls.Add(Me.btnTriangulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Areas"
        Me.Text = "Áreas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblArea As Label
    Friend WithEvents btnRetan As Button
    Friend WithEvents btnCirculo As Button
    Friend WithEvents btnQuadrado As Button
    Friend WithEvents btnTriangulo As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents txbQuad As TextBox
    Friend WithEvents txbRet As TextBox
    Friend WithEvents txbTri As TextBox
    Friend WithEvents txbCirc As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerimetrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NúmerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabuadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.lblval1 = New System.Windows.Forms.Label()
        Me.lblval2 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.TxtVal1 = New System.Windows.Forms.TextBox()
        Me.TxtVal2 = New System.Windows.Forms.TextBox()
        Me.TextResultado = New System.Windows.Forms.TextBox()
        Me.btnSubtrair = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GeometriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerimetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NúmerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabuadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSomar
        '
        Me.btnSomar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSomar.Location = New System.Drawing.Point(463, 69)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(128, 73)
        Me.btnSomar.TabIndex = 6
        Me.btnSomar.Text = "+"
        Me.btnSomar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(34, 256)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(192, 73)
        Me.btnLimpar.TabIndex = 7
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(503, 256)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(244, 73)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'lblval1
        '
        Me.lblval1.AutoSize = True
        Me.lblval1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblval1.Location = New System.Drawing.Point(45, 86)
        Me.lblval1.Name = "lblval1"
        Me.lblval1.Size = New System.Drawing.Size(61, 20)
        Me.lblval1.TabIndex = 9
        Me.lblval1.Text = "1ºValor"
        '
        'lblval2
        '
        Me.lblval2.AutoSize = True
        Me.lblval2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblval2.Location = New System.Drawing.Point(45, 125)
        Me.lblval2.Name = "lblval2"
        Me.lblval2.Size = New System.Drawing.Size(61, 20)
        Me.lblval2.TabIndex = 4
        Me.lblval2.Text = "2ºValor"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(45, 204)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(82, 20)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "Resultado"
        '
        'TxtVal1
        '
        Me.TxtVal1.Location = New System.Drawing.Point(166, 79)
        Me.TxtVal1.Name = "TxtVal1"
        Me.TxtVal1.Size = New System.Drawing.Size(253, 20)
        Me.TxtVal1.TabIndex = 0
        '
        'TxtVal2
        '
        Me.TxtVal2.Location = New System.Drawing.Point(166, 122)
        Me.TxtVal2.Name = "TxtVal2"
        Me.TxtVal2.Size = New System.Drawing.Size(253, 20)
        Me.TxtVal2.TabIndex = 1
        '
        'TextResultado
        '
        Me.TextResultado.Location = New System.Drawing.Point(166, 201)
        Me.TextResultado.Name = "TextResultado"
        Me.TextResultado.ReadOnly = True
        Me.TextResultado.Size = New System.Drawing.Size(253, 20)
        Me.TextResultado.TabIndex = 8
        '
        'btnSubtrair
        '
        Me.btnSubtrair.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSubtrair.Location = New System.Drawing.Point(618, 69)
        Me.btnSubtrair.Name = "btnSubtrair"
        Me.btnSubtrair.Size = New System.Drawing.Size(128, 73)
        Me.btnSubtrair.TabIndex = 10
        Me.btnSubtrair.Text = "-"
        Me.btnSubtrair.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnMultiplicar.Location = New System.Drawing.Point(463, 148)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(128, 73)
        Me.btnMultiplicar.TabIndex = 11
        Me.btnMultiplicar.Text = "x"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnDividir.Location = New System.Drawing.Point(618, 148)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(128, 73)
        Me.btnDividir.TabIndex = 12
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenu.Location = New System.Drawing.Point(267, 256)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(193, 73)
        Me.BtnMenu.TabIndex = 13
        Me.BtnMenu.Text = "&Menu"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeometriaToolStripMenuItem, Me.NúmerosToolStripMenuItem, Me.TabuadaToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(789, 29)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GeometriaToolStripMenuItem
        '
        Me.GeometriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÁreasToolStripMenuItem, Me.PerimetrosToolStripMenuItem})
        Me.GeometriaToolStripMenuItem.Name = "GeometriaToolStripMenuItem"
        Me.GeometriaToolStripMenuItem.Size = New System.Drawing.Size(95, 25)
        Me.GeometriaToolStripMenuItem.Text = "Geometria"
        '
        'ÁreasToolStripMenuItem
        '
        Me.ÁreasToolStripMenuItem.Name = "ÁreasToolStripMenuItem"
        Me.ÁreasToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.ÁreasToolStripMenuItem.Text = "Áreas"
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
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 352)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnSubtrair)
        Me.Controls.Add(Me.TextResultado)
        Me.Controls.Add(Me.TxtVal2)
        Me.Controls.Add(Me.TxtVal1)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblval2)
        Me.Controls.Add(Me.lblval1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnSomar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSomar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents lblval1 As Label
    Friend WithEvents lblval2 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents TxtVal1 As TextBox
    Friend WithEvents TxtVal2 As TextBox
    Friend WithEvents TextResultado As TextBox
    Friend WithEvents btnSubtrair As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GeometriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÁreasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerimetrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NúmerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabuadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
End Class

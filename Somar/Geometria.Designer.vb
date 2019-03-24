<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Geometria
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
        Me.lblGeom = New System.Windows.Forms.Label()
        Me.BtnPerimetros = New System.Windows.Forms.Button()
        Me.BtnAreas = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NúmerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabuadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGeom
        '
        Me.lblGeom.AutoSize = True
        Me.lblGeom.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeom.Location = New System.Drawing.Point(331, 44)
        Me.lblGeom.Name = "lblGeom"
        Me.lblGeom.Size = New System.Drawing.Size(140, 31)
        Me.lblGeom.TabIndex = 0
        Me.lblGeom.Text = "Geometria"
        '
        'BtnPerimetros
        '
        Me.BtnPerimetros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnPerimetros.Location = New System.Drawing.Point(68, 101)
        Me.BtnPerimetros.Name = "BtnPerimetros"
        Me.BtnPerimetros.Size = New System.Drawing.Size(283, 171)
        Me.BtnPerimetros.TabIndex = 29
        Me.BtnPerimetros.Text = "&Perimetros"
        Me.BtnPerimetros.UseVisualStyleBackColor = True
        '
        'BtnAreas
        '
        Me.BtnAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnAreas.Location = New System.Drawing.Point(447, 101)
        Me.BtnAreas.Name = "BtnAreas"
        Me.BtnAreas.Size = New System.Drawing.Size(283, 171)
        Me.BtnAreas.TabIndex = 30
        Me.BtnAreas.Text = "&Áreas"
        Me.BtnAreas.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnMenu.Location = New System.Drawing.Point(247, 318)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(283, 90)
        Me.btnMenu.TabIndex = 31
        Me.btnMenu.Text = "&Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.NúmerosToolStripMenuItem, Me.TabuadaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 29)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(104, 25)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
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
        'Geometria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 420)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.BtnAreas)
        Me.Controls.Add(Me.BtnPerimetros)
        Me.Controls.Add(Me.lblGeom)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Geometria"
        Me.Text = "Geometria"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGeom As Label
    Friend WithEvents BtnPerimetros As Button
    Friend WithEvents BtnAreas As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NúmerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabuadaToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MatMenu
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
        Me.BtnGeo = New System.Windows.Forms.Button()
        Me.BtnNumeros = New System.Windows.Forms.Button()
        Me.BtnTab = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.BtnCalculadora = New System.Windows.Forms.Button()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerímetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NúmerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabuadaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGeo
        '
        Me.BtnGeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnGeo.Location = New System.Drawing.Point(429, 186)
        Me.BtnGeo.Name = "BtnGeo"
        Me.BtnGeo.Size = New System.Drawing.Size(283, 73)
        Me.BtnGeo.TabIndex = 29
        Me.BtnGeo.Text = "&Geometria"
        Me.BtnGeo.UseVisualStyleBackColor = True
        '
        'BtnNumeros
        '
        Me.BtnNumeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnNumeros.Location = New System.Drawing.Point(429, 86)
        Me.BtnNumeros.Name = "BtnNumeros"
        Me.BtnNumeros.Size = New System.Drawing.Size(283, 73)
        Me.BtnNumeros.TabIndex = 28
        Me.BtnNumeros.Text = "&Números"
        Me.BtnNumeros.UseVisualStyleBackColor = True
        '
        'BtnTab
        '
        Me.BtnTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnTab.Location = New System.Drawing.Point(63, 186)
        Me.BtnTab.Name = "BtnTab"
        Me.BtnTab.Size = New System.Drawing.Size(283, 73)
        Me.BtnTab.TabIndex = 27
        Me.BtnTab.Text = "&Tabuada"
        Me.BtnTab.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnSair.Location = New System.Drawing.Point(278, 303)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(216, 70)
        Me.btnSair.TabIndex = 30
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'BtnCalculadora
        '
        Me.BtnCalculadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BtnCalculadora.Location = New System.Drawing.Point(63, 86)
        Me.BtnCalculadora.Name = "BtnCalculadora"
        Me.BtnCalculadora.Size = New System.Drawing.Size(283, 73)
        Me.BtnCalculadora.TabIndex = 26
        Me.BtnCalculadora.Text = "&Calculadora"
        Me.BtnCalculadora.UseVisualStyleBackColor = True
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(344, 42)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(84, 29)
        Me.lblArea.TabIndex = 45
        Me.lblArea.Text = "MENU"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.GeometriaToolStripMenuItem, Me.NúmerosToolStripMenuItem, Me.TabuadaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 29)
        Me.MenuStrip1.TabIndex = 46
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
        Me.GeometriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÁreasToolStripMenuItem, Me.PerímetrosToolStripMenuItem})
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
        'PerímetrosToolStripMenuItem
        '
        Me.PerímetrosToolStripMenuItem.Name = "PerímetrosToolStripMenuItem"
        Me.PerímetrosToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.PerímetrosToolStripMenuItem.Text = "Perímetros"
        '
        'NúmerosToolStripMenuItem
        '
        Me.NúmerosToolStripMenuItem.Name = "NúmerosToolStripMenuItem"
        Me.NúmerosToolStripMenuItem.Size = New System.Drawing.Size(87, 25)
        Me.NúmerosToolStripMenuItem.Text = "Números"
        '
        'TabuadaToolStripMenuItem1
        '
        Me.TabuadaToolStripMenuItem1.Name = "TabuadaToolStripMenuItem1"
        Me.TabuadaToolStripMenuItem1.Size = New System.Drawing.Size(79, 25)
        Me.TabuadaToolStripMenuItem1.Text = "Tabuada"
        '
        'MatMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 391)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.BtnCalculadora)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.BtnGeo)
        Me.Controls.Add(Me.BtnNumeros)
        Me.Controls.Add(Me.BtnTab)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MatMenu"
        Me.Text = "MatMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGeo As Button
    Friend WithEvents BtnNumeros As Button
    Friend WithEvents BtnTab As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents BtnCalculadora As Button
    Friend WithEvents lblArea As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÁreasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerímetrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NúmerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabuadaToolStripMenuItem1 As ToolStripMenuItem
End Class

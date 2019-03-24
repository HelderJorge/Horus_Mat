<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Números
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
        Me.LblLimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.TxtPares = New System.Windows.Forms.TextBox()
        Me.TxtImp = New System.Windows.Forms.TextBox()
        Me.TxtPos = New System.Windows.Forms.TextBox()
        Me.TxtNeg = New System.Windows.Forms.TextBox()
        Me.LblPar = New System.Windows.Forms.Label()
        Me.LblImp = New System.Windows.Forms.Label()
        Me.LblPos = New System.Windows.Forms.Label()
        Me.LblNeg = New System.Windows.Forms.Label()
        Me.BtnExec = New System.Windows.Forms.Button()
        Me.TxtContPar = New System.Windows.Forms.TextBox()
        Me.TxtContImp = New System.Windows.Forms.TextBox()
        Me.TxtContPos = New System.Windows.Forms.TextBox()
        Me.TxtContNeg = New System.Windows.Forms.TextBox()
        Me.LblCont = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMaior = New System.Windows.Forms.TextBox()
        Me.TxtMenor = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerimetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabuadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblLimpar
        '
        Me.LblLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLimpar.Location = New System.Drawing.Point(52, 157)
        Me.LblLimpar.Name = "LblLimpar"
        Me.LblLimpar.Size = New System.Drawing.Size(157, 34)
        Me.LblLimpar.TabIndex = 9
        Me.LblLimpar.Text = "&Limpar"
        Me.LblLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(52, 213)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(157, 36)
        Me.btnSair.TabIndex = 10
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'TxtPares
        '
        Me.TxtPares.Location = New System.Drawing.Point(233, 71)
        Me.TxtPares.Multiline = True
        Me.TxtPares.Name = "TxtPares"
        Me.TxtPares.Size = New System.Drawing.Size(100, 219)
        Me.TxtPares.TabIndex = 11
        '
        'TxtImp
        '
        Me.TxtImp.Location = New System.Drawing.Point(381, 71)
        Me.TxtImp.Multiline = True
        Me.TxtImp.Name = "TxtImp"
        Me.TxtImp.Size = New System.Drawing.Size(100, 220)
        Me.TxtImp.TabIndex = 12
        '
        'TxtPos
        '
        Me.TxtPos.Location = New System.Drawing.Point(524, 71)
        Me.TxtPos.Multiline = True
        Me.TxtPos.Name = "TxtPos"
        Me.TxtPos.Size = New System.Drawing.Size(100, 220)
        Me.TxtPos.TabIndex = 13
        '
        'TxtNeg
        '
        Me.TxtNeg.Location = New System.Drawing.Point(664, 71)
        Me.TxtNeg.Multiline = True
        Me.TxtNeg.Name = "TxtNeg"
        Me.TxtNeg.Size = New System.Drawing.Size(100, 220)
        Me.TxtNeg.TabIndex = 14
        '
        'LblPar
        '
        Me.LblPar.AutoSize = True
        Me.LblPar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPar.Location = New System.Drawing.Point(243, 48)
        Me.LblPar.Name = "LblPar"
        Me.LblPar.Size = New System.Drawing.Size(71, 20)
        Me.LblPar.TabIndex = 18
        Me.LblPar.Text = "Nº Pares"
        '
        'LblImp
        '
        Me.LblImp.AutoSize = True
        Me.LblImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImp.Location = New System.Drawing.Point(389, 48)
        Me.LblImp.Name = "LblImp"
        Me.LblImp.Size = New System.Drawing.Size(88, 20)
        Me.LblImp.TabIndex = 17
        Me.LblImp.Text = "Nº Impares"
        '
        'LblPos
        '
        Me.LblPos.AutoSize = True
        Me.LblPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPos.Location = New System.Drawing.Point(528, 48)
        Me.LblPos.Name = "LblPos"
        Me.LblPos.Size = New System.Drawing.Size(92, 20)
        Me.LblPos.TabIndex = 16
        Me.LblPos.Text = "Nº Positivos"
        '
        'LblNeg
        '
        Me.LblNeg.AutoSize = True
        Me.LblNeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNeg.Location = New System.Drawing.Point(661, 48)
        Me.LblNeg.Name = "LblNeg"
        Me.LblNeg.Size = New System.Drawing.Size(100, 20)
        Me.LblNeg.TabIndex = 15
        Me.LblNeg.Text = "Nº Negativos"
        '
        'BtnExec
        '
        Me.BtnExec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExec.Location = New System.Drawing.Point(52, 93)
        Me.BtnExec.Name = "BtnExec"
        Me.BtnExec.Size = New System.Drawing.Size(157, 41)
        Me.BtnExec.TabIndex = 8
        Me.BtnExec.Text = "&Executar"
        Me.BtnExec.UseVisualStyleBackColor = True
        '
        'TxtContPar
        '
        Me.TxtContPar.Location = New System.Drawing.Point(233, 323)
        Me.TxtContPar.Name = "TxtContPar"
        Me.TxtContPar.Size = New System.Drawing.Size(100, 20)
        Me.TxtContPar.TabIndex = 19
        '
        'TxtContImp
        '
        Me.TxtContImp.Location = New System.Drawing.Point(381, 322)
        Me.TxtContImp.Name = "TxtContImp"
        Me.TxtContImp.Size = New System.Drawing.Size(100, 20)
        Me.TxtContImp.TabIndex = 20
        '
        'TxtContPos
        '
        Me.TxtContPos.Location = New System.Drawing.Point(524, 322)
        Me.TxtContPos.Name = "TxtContPos"
        Me.TxtContPos.Size = New System.Drawing.Size(100, 20)
        Me.TxtContPos.TabIndex = 21
        '
        'TxtContNeg
        '
        Me.TxtContNeg.Location = New System.Drawing.Point(664, 322)
        Me.TxtContNeg.Name = "TxtContNeg"
        Me.TxtContNeg.Size = New System.Drawing.Size(100, 20)
        Me.TxtContNeg.TabIndex = 22
        '
        'LblCont
        '
        Me.LblCont.AutoSize = True
        Me.LblCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCont.Location = New System.Drawing.Point(71, 322)
        Me.LblCont.Name = "LblCont"
        Me.LblCont.Size = New System.Drawing.Size(102, 24)
        Me.LblCont.TabIndex = 23
        Me.LblCont.Text = "Contagem:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Maior:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(518, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Menor:"
        '
        'TxtMaior
        '
        Me.TxtMaior.Location = New System.Drawing.Point(311, 376)
        Me.TxtMaior.Name = "TxtMaior"
        Me.TxtMaior.Size = New System.Drawing.Size(100, 20)
        Me.TxtMaior.TabIndex = 26
        '
        'TxtMenor
        '
        Me.TxtMenor.Location = New System.Drawing.Point(609, 376)
        Me.TxtMenor.Name = "TxtMenor"
        Me.TxtMenor.Size = New System.Drawing.Size(100, 20)
        Me.TxtMenor.TabIndex = 27
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.GeometriaToolStripMenuItem, Me.TabuadaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 29)
        Me.MenuStrip1.TabIndex = 28
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
        'TabuadaToolStripMenuItem
        '
        Me.TabuadaToolStripMenuItem.Name = "TabuadaToolStripMenuItem"
        Me.TabuadaToolStripMenuItem.Size = New System.Drawing.Size(79, 25)
        Me.TabuadaToolStripMenuItem.Text = "Tabuada"
        '
        'Números
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 415)
        Me.Controls.Add(Me.TxtMenor)
        Me.Controls.Add(Me.TxtMaior)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblCont)
        Me.Controls.Add(Me.TxtContNeg)
        Me.Controls.Add(Me.TxtContPos)
        Me.Controls.Add(Me.TxtContImp)
        Me.Controls.Add(Me.TxtContPar)
        Me.Controls.Add(Me.BtnExec)
        Me.Controls.Add(Me.LblNeg)
        Me.Controls.Add(Me.LblPos)
        Me.Controls.Add(Me.LblImp)
        Me.Controls.Add(Me.LblPar)
        Me.Controls.Add(Me.TxtNeg)
        Me.Controls.Add(Me.TxtPos)
        Me.Controls.Add(Me.TxtImp)
        Me.Controls.Add(Me.TxtPares)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.LblLimpar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Números"
        Me.Text = "Números"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblLimpar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents TxtPares As TextBox
    Friend WithEvents TxtImp As TextBox
    Friend WithEvents TxtPos As TextBox
    Friend WithEvents TxtNeg As TextBox
    Friend WithEvents LblPar As Label
    Friend WithEvents LblImp As Label
    Friend WithEvents LblPos As Label
    Friend WithEvents LblNeg As Label
    Friend WithEvents BtnExec As Button
    Friend WithEvents TxtContPar As TextBox
    Friend WithEvents TxtContImp As TextBox
    Friend WithEvents TxtContPos As TextBox
    Friend WithEvents TxtContNeg As TextBox
    Friend WithEvents LblCont As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMaior As TextBox
    Friend WithEvents TxtMenor As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeometriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÁreasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerimetrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabuadaToolStripMenuItem As ToolStripMenuItem
End Class

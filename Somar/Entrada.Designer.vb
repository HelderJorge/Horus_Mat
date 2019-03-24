<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUti = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbUti = New System.Windows.Forms.TextBox()
        Me.txbPass = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HÓRUS_MAT"
        '
        'lblUti
        '
        Me.lblUti.AutoSize = True
        Me.lblUti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblUti.Location = New System.Drawing.Point(48, 131)
        Me.lblUti.Name = "lblUti"
        Me.lblUti.Size = New System.Drawing.Size(79, 20)
        Me.lblUti.TabIndex = 1
        Me.lblUti.Text = "Utilizador:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(48, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'txbUti
        '
        Me.txbUti.Location = New System.Drawing.Point(142, 131)
        Me.txbUti.Name = "txbUti"
        Me.txbUti.Size = New System.Drawing.Size(195, 20)
        Me.txbUti.TabIndex = 3
        '
        'txbPass
        '
        Me.txbPass.Location = New System.Drawing.Point(142, 181)
        Me.txbPass.Name = "txbPass"
        Me.txbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.txbPass.Size = New System.Drawing.Size(192, 20)
        Me.txbPass.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(383, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 375)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackgroundImage = CType(resources.GetObject("btnEntrar.BackgroundImage"), System.Drawing.Image)
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEntrar.Location = New System.Drawing.Point(68, 254)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(224, 112)
        Me.btnEntrar.TabIndex = 6
        Me.btnEntrar.Text = "&Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 430)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txbPass)
        Me.Controls.Add(Me.txbUti)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUti)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Entrada"
        Me.Text = "Hórus_Mat"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUti As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbUti As TextBox
    Friend WithEvents txbPass As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEntrar As Button
End Class

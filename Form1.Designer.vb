<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.grpbDados = New System.Windows.Forms.GroupBox()
        Me.rtxtCaracteristicas = New System.Windows.Forms.RichTextBox()
        Me.cmbEscalao = New System.Windows.Forms.ComboBox()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.picbFoto = New System.Windows.Forms.PictureBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblCaracteristicas = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblEscalao = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.btnPrimeiroReg = New System.Windows.Forms.Button()
        Me.btnUltimoReg = New System.Windows.Forms.Button()
        Me.btnProximoReg = New System.Windows.Forms.Button()
        Me.btnProcura = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.grpbDados.SuspendLayout()
        CType(Me.picbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbDados
        '
        Me.grpbDados.Controls.Add(Me.rtxtCaracteristicas)
        Me.grpbDados.Controls.Add(Me.cmbEscalao)
        Me.grpbDados.Controls.Add(Me.btnFoto)
        Me.grpbDados.Controls.Add(Me.picbFoto)
        Me.grpbDados.Controls.Add(Me.txtAno)
        Me.grpbDados.Controls.Add(Me.txtMes)
        Me.grpbDados.Controls.Add(Me.txtDia)
        Me.grpbDados.Controls.Add(Me.txtNome)
        Me.grpbDados.Controls.Add(Me.lblCaracteristicas)
        Me.grpbDados.Controls.Add(Me.lblData)
        Me.grpbDados.Controls.Add(Me.lblEscalao)
        Me.grpbDados.Controls.Add(Me.lblNome)
        Me.grpbDados.Location = New System.Drawing.Point(41, 25)
        Me.grpbDados.Name = "grpbDados"
        Me.grpbDados.Size = New System.Drawing.Size(996, 380)
        Me.grpbDados.TabIndex = 0
        Me.grpbDados.TabStop = False
        Me.grpbDados.Text = "Dados"
        '
        'rtxtCaracteristicas
        '
        Me.rtxtCaracteristicas.Location = New System.Drawing.Point(137, 234)
        Me.rtxtCaracteristicas.Name = "rtxtCaracteristicas"
        Me.rtxtCaracteristicas.Size = New System.Drawing.Size(430, 114)
        Me.rtxtCaracteristicas.TabIndex = 15
        Me.rtxtCaracteristicas.Text = "" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbEscalao
        '
        Me.cmbEscalao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEscalao.FormattingEnabled = True
        Me.cmbEscalao.Items.AddRange(New Object() {"sub11", "sub12", "sub13", "sub15"})
        Me.cmbEscalao.Location = New System.Drawing.Point(151, 106)
        Me.cmbEscalao.Name = "cmbEscalao"
        Me.cmbEscalao.Size = New System.Drawing.Size(121, 23)
        Me.cmbEscalao.TabIndex = 14
        '
        'btnFoto
        '
        Me.btnFoto.Location = New System.Drawing.Point(670, 267)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(255, 40)
        Me.btnFoto.TabIndex = 9
        Me.btnFoto.Text = "Escolhe Foto"
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'picbFoto
        '
        Me.picbFoto.Location = New System.Drawing.Point(670, 52)
        Me.picbFoto.Name = "picbFoto"
        Me.picbFoto.Size = New System.Drawing.Size(255, 185)
        Me.picbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbFoto.TabIndex = 8
        Me.picbFoto.TabStop = False
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(243, 169)
        Me.txtAno.MaxLength = 4
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(76, 23)
        Me.txtAno.TabIndex = 7
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(197, 169)
        Me.txtMes.MaxLength = 2
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(40, 23)
        Me.txtMes.TabIndex = 6
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(151, 169)
        Me.txtDia.MaxLength = 2
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(40, 23)
        Me.txtDia.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(151, 49)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(416, 23)
        Me.txtNome.TabIndex = 4
        '
        'lblCaracteristicas
        '
        Me.lblCaracteristicas.AutoSize = True
        Me.lblCaracteristicas.Location = New System.Drawing.Point(18, 237)
        Me.lblCaracteristicas.Name = "lblCaracteristicas"
        Me.lblCaracteristicas.Size = New System.Drawing.Size(83, 15)
        Me.lblCaracteristicas.TabIndex = 3
        Me.lblCaracteristicas.Text = "Caracteristicas"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(18, 169)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(114, 30)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = "Data de Nascimento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  (dia - mês - ano)"
        '
        'lblEscalao
        '
        Me.lblEscalao.AutoSize = True
        Me.lblEscalao.Location = New System.Drawing.Point(18, 109)
        Me.lblEscalao.Name = "lblEscalao"
        Me.lblEscalao.Size = New System.Drawing.Size(46, 15)
        Me.lblEscalao.TabIndex = 1
        Me.lblEscalao.Text = "Escalão"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(18, 52)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(102, 15)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome do Jogador"
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Location = New System.Drawing.Point(52, 439)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(99, 46)
        Me.btnAdiciona.TabIndex = 10
        Me.btnAdiciona.Text = "Adiciona"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'btnPrimeiroReg
        '
        Me.btnPrimeiroReg.Location = New System.Drawing.Point(192, 439)
        Me.btnPrimeiroReg.Name = "btnPrimeiroReg"
        Me.btnPrimeiroReg.Size = New System.Drawing.Size(99, 46)
        Me.btnPrimeiroReg.TabIndex = 11
        Me.btnPrimeiroReg.Text = "Primeiro Registo"
        Me.btnPrimeiroReg.UseVisualStyleBackColor = True
        '
        'btnUltimoReg
        '
        Me.btnUltimoReg.Location = New System.Drawing.Point(333, 439)
        Me.btnUltimoReg.Name = "btnUltimoReg"
        Me.btnUltimoReg.Size = New System.Drawing.Size(99, 46)
        Me.btnUltimoReg.TabIndex = 12
        Me.btnUltimoReg.Text = "Último Registo"
        Me.btnUltimoReg.UseVisualStyleBackColor = True
        '
        'btnProximoReg
        '
        Me.btnProximoReg.Location = New System.Drawing.Point(474, 439)
        Me.btnProximoReg.Name = "btnProximoReg"
        Me.btnProximoReg.Size = New System.Drawing.Size(99, 46)
        Me.btnProximoReg.TabIndex = 13
        Me.btnProximoReg.Text = "Próximo Registo"
        Me.btnProximoReg.UseVisualStyleBackColor = True
        '
        'btnProcura
        '
        Me.btnProcura.BackgroundImage = Global.team_DB.My.Resources.Resources._3721746
        Me.btnProcura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProcura.Location = New System.Drawing.Point(794, 425)
        Me.btnProcura.Name = "btnProcura"
        Me.btnProcura.Size = New System.Drawing.Size(92, 74)
        Me.btnProcura.TabIndex = 14
        Me.btnProcura.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(603, 439)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(99, 46)
        Me.btnAnterior.TabIndex = 15
        Me.btnAnterior.Text = "Registo Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 552)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnProcura)
        Me.Controls.Add(Me.btnProximoReg)
        Me.Controls.Add(Me.btnUltimoReg)
        Me.Controls.Add(Me.btnPrimeiroReg)
        Me.Controls.Add(Me.grpbDados)
        Me.Controls.Add(Me.btnAdiciona)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpbDados.ResumeLayout(False)
        Me.grpbDados.PerformLayout()
        CType(Me.picbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbDados As GroupBox
    Friend WithEvents txtDia As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblCaracteristicas As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblEscalao As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents cmbEscalao As ComboBox
    Friend WithEvents btnFoto As Button
    Friend WithEvents picbFoto As PictureBox
    Friend WithEvents txtAno As TextBox
    Friend WithEvents txtMes As TextBox
    Friend WithEvents btnAdiciona As Button
    Friend WithEvents btnPrimeiroReg As Button
    Friend WithEvents btnUltimoReg As Button
    Friend WithEvents btnProximoReg As Button
    Friend WithEvents rtxtCaracteristicas As RichTextBox
    Friend WithEvents btnProcura As Button
    Friend WithEvents btnAnterior As Button
End Class

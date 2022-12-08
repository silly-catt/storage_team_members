<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cmbEscalao = New System.Windows.Forms.ComboBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblEscalao = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lstvMain = New System.Windows.Forms.ListView()
        Me.lstvNome = New System.Windows.Forms.ColumnHeader()
        Me.lstvEscalao = New System.Windows.Forms.ColumnHeader()
        Me.lstvData = New System.Windows.Forms.ColumnHeader()
        Me.lstvCaracteristicas = New System.Windows.Forms.ColumnHeader()
        Me.btnProcura = New System.Windows.Forms.Button()
        Me.picbJogador = New System.Windows.Forms.PictureBox()
        Me.rbtNome = New System.Windows.Forms.RadioButton()
        Me.rbtEscalao = New System.Windows.Forms.RadioButton()
        Me.rbtData = New System.Windows.Forms.RadioButton()
        Me.rbtMes = New System.Windows.Forms.RadioButton()
        Me.rbtAno = New System.Windows.Forms.RadioButton()
        CType(Me.picbJogador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbEscalao
        '
        Me.cmbEscalao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEscalao.Enabled = False
        Me.cmbEscalao.FormattingEnabled = True
        Me.cmbEscalao.Items.AddRange(New Object() {"sub11", "sub12", "sub13", "sub15"})
        Me.cmbEscalao.Location = New System.Drawing.Point(155, 94)
        Me.cmbEscalao.Name = "cmbEscalao"
        Me.cmbEscalao.Size = New System.Drawing.Size(121, 23)
        Me.cmbEscalao.TabIndex = 22
        '
        'txtAno
        '
        Me.txtAno.Enabled = False
        Me.txtAno.Location = New System.Drawing.Point(247, 157)
        Me.txtAno.MaxLength = 4
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(76, 23)
        Me.txtAno.TabIndex = 21
        '
        'txtMes
        '
        Me.txtMes.Enabled = False
        Me.txtMes.Location = New System.Drawing.Point(201, 157)
        Me.txtMes.MaxLength = 2
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(40, 23)
        Me.txtMes.TabIndex = 20
        '
        'txtDia
        '
        Me.txtDia.Enabled = False
        Me.txtDia.Location = New System.Drawing.Point(155, 157)
        Me.txtDia.MaxLength = 2
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(40, 23)
        Me.txtDia.TabIndex = 19
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(155, 37)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(386, 23)
        Me.txtNome.TabIndex = 18
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(22, 157)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(114, 30)
        Me.lblData.TabIndex = 17
        Me.lblData.Text = "Data de Nascimento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  (dia - mês - ano)"
        '
        'lblEscalao
        '
        Me.lblEscalao.AutoSize = True
        Me.lblEscalao.Location = New System.Drawing.Point(22, 97)
        Me.lblEscalao.Name = "lblEscalao"
        Me.lblEscalao.Size = New System.Drawing.Size(46, 15)
        Me.lblEscalao.TabIndex = 16
        Me.lblEscalao.Text = "Escalão"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(22, 40)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(102, 15)
        Me.lblNome.TabIndex = 15
        Me.lblNome.Text = "Nome do Jogador"
        '
        'lstvMain
        '
        Me.lstvMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstvNome, Me.lstvEscalao, Me.lstvData, Me.lstvCaracteristicas})
        Me.lstvMain.FullRowSelect = True
        Me.lstvMain.GridLines = True
        Me.lstvMain.Location = New System.Drawing.Point(137, 244)
        Me.lstvMain.Name = "lstvMain"
        Me.lstvMain.Size = New System.Drawing.Size(551, 208)
        Me.lstvMain.TabIndex = 28
        Me.lstvMain.UseCompatibleStateImageBehavior = False
        Me.lstvMain.View = System.Windows.Forms.View.Details
        '
        'lstvNome
        '
        Me.lstvNome.Text = "Nome"
        Me.lstvNome.Width = 200
        '
        'lstvEscalao
        '
        Me.lstvEscalao.Text = "Escalão"
        Me.lstvEscalao.Width = 70
        '
        'lstvData
        '
        Me.lstvData.Text = "Data de nascimento"
        Me.lstvData.Width = 130
        '
        'lstvCaracteristicas
        '
        Me.lstvCaracteristicas.Text = "Características"
        Me.lstvCaracteristicas.Width = 150
        '
        'btnProcura
        '
        Me.btnProcura.Location = New System.Drawing.Point(12, 473)
        Me.btnProcura.Name = "btnProcura"
        Me.btnProcura.Size = New System.Drawing.Size(90, 43)
        Me.btnProcura.TabIndex = 29
        Me.btnProcura.Text = "Procura"
        Me.btnProcura.UseVisualStyleBackColor = True
        '
        'picbJogador
        '
        Me.picbJogador.Location = New System.Drawing.Point(833, 94)
        Me.picbJogador.Name = "picbJogador"
        Me.picbJogador.Size = New System.Drawing.Size(329, 292)
        Me.picbJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbJogador.TabIndex = 30
        Me.picbJogador.TabStop = False
        '
        'rbtNome
        '
        Me.rbtNome.AutoSize = True
        Me.rbtNome.Location = New System.Drawing.Point(22, 252)
        Me.rbtNome.Name = "rbtNome"
        Me.rbtNome.Size = New System.Drawing.Size(58, 19)
        Me.rbtNome.TabIndex = 31
        Me.rbtNome.TabStop = True
        Me.rbtNome.Text = "Nome"
        Me.rbtNome.UseVisualStyleBackColor = True
        '
        'rbtEscalao
        '
        Me.rbtEscalao.AutoSize = True
        Me.rbtEscalao.Location = New System.Drawing.Point(22, 286)
        Me.rbtEscalao.Name = "rbtEscalao"
        Me.rbtEscalao.Size = New System.Drawing.Size(64, 19)
        Me.rbtEscalao.TabIndex = 32
        Me.rbtEscalao.TabStop = True
        Me.rbtEscalao.Text = "Escalão"
        Me.rbtEscalao.UseVisualStyleBackColor = True
        '
        'rbtData
        '
        Me.rbtData.AutoSize = True
        Me.rbtData.Location = New System.Drawing.Point(22, 320)
        Me.rbtData.Name = "rbtData"
        Me.rbtData.Size = New System.Drawing.Size(49, 19)
        Me.rbtData.TabIndex = 33
        Me.rbtData.TabStop = True
        Me.rbtData.Text = "Data"
        Me.rbtData.UseVisualStyleBackColor = True
        '
        'rbtMes
        '
        Me.rbtMes.AutoSize = True
        Me.rbtMes.Location = New System.Drawing.Point(22, 355)
        Me.rbtMes.Name = "rbtMes"
        Me.rbtMes.Size = New System.Drawing.Size(47, 19)
        Me.rbtMes.TabIndex = 34
        Me.rbtMes.TabStop = True
        Me.rbtMes.Text = "Mês"
        Me.rbtMes.UseVisualStyleBackColor = True
        '
        'rbtAno
        '
        Me.rbtAno.AutoSize = True
        Me.rbtAno.Location = New System.Drawing.Point(22, 389)
        Me.rbtAno.Name = "rbtAno"
        Me.rbtAno.Size = New System.Drawing.Size(47, 19)
        Me.rbtAno.TabIndex = 35
        Me.rbtAno.TabStop = True
        Me.rbtAno.Text = "Ano"
        Me.rbtAno.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 546)
        Me.Controls.Add(Me.rbtAno)
        Me.Controls.Add(Me.rbtMes)
        Me.Controls.Add(Me.rbtData)
        Me.Controls.Add(Me.rbtEscalao)
        Me.Controls.Add(Me.rbtNome)
        Me.Controls.Add(Me.picbJogador)
        Me.Controls.Add(Me.btnProcura)
        Me.Controls.Add(Me.lstvMain)
        Me.Controls.Add(Me.cmbEscalao)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblEscalao)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.picbJogador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbEscalao As ComboBox
    Friend WithEvents txtAno As TextBox
    Friend WithEvents txtMes As TextBox
    Friend WithEvents txtDia As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblData As Label
    Friend WithEvents lblEscalao As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lstvMain As ListView
    Friend WithEvents lstvNome As ColumnHeader
    Friend WithEvents lstvEscalao As ColumnHeader
    Friend WithEvents lstvData As ColumnHeader
    Friend WithEvents lstvCaracteristicas As ColumnHeader
    Friend WithEvents btnProcura As Button
    Friend WithEvents picbJogador As PictureBox
    Friend WithEvents rbtNome As RadioButton
    Friend WithEvents rbtEscalao As RadioButton
    Friend WithEvents rbtData As RadioButton
    Friend WithEvents rbtMes As RadioButton
    Friend WithEvents rbtAno As RadioButton
End Class

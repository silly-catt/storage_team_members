Public Class Form1
    Public cntGlobal As Integer
    Public dados(100) As DadosJogador
    Dim guardarFoto As Object
    Public Structure DadosJogador

        Public nome As String
        Public escalao As String
        Public data As String
        Dim caracteristicas As String
        Public foto As Object

    End Structure

    Private Sub btnAdiciona_Click(sender As Object, e As EventArgs) Handles btnAdiciona.Click

        Dim data As String


        If btnAdiciona.Text = "Adiciona" And btnAdiciona.DialogResult = 0 Then
            txtNome.Text = ""
            txtDia.Text = ""
            txtMes.Text = ""
            txtAno.Text = ""
            rtxtCaracteristicas.Text = ""
            cmbEscalao.SelectedIndex = -1
            picbFoto.Image = Nothing
            btnAdiciona.DialogResult = 1
            btnAdiciona.Text = "Gravar"
        Else
            If txtNome.Text <> "" And cmbEscalao.SelectedIndex <> -1 And txtDia.Text <> "" And txtMes.Text <> "" And txtAno.Text <> "" And rtxtCaracteristicas.Text <> "" And picbFoto.Image IsNot Nothing Then
                If btnAdiciona.DialogResult <> 0 And btnAdiciona.Text = "Gravar" Then
                    dados(cntGlobal).nome = txtNome.Text
                    dados(cntGlobal).escalao = cmbEscalao.SelectedItem
                    data = txtDia.Text + "-" + txtMes.Text + "-" + txtAno.Text
                    dados(cntGlobal).data = data
                    dados(cntGlobal).caracteristicas = rtxtCaracteristicas.Text
                    dados(cntGlobal).foto = guardarFoto
                    btnAdiciona.Text = "Adiciona"
                    btnAdiciona.DialogResult = 0
                    cntGlobal += 1

                    'image.fromfilename(dados.foto) para chamar a foto
                End If
            Else
                MsgBox("Preencha o registo.", vbCritical)
            End If
        End If




    End Sub

    Private Sub btnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles btnPrimeiroReg.Click
        Dim data(3) As String

        If dados(0).nome = "" Then

            MsgBox("Não existe registos.")

        Else

            txtNome.Text = dados(0).nome
            cmbEscalao.SelectedItem = dados(0).escalao

            data = dados(0).data.Split("-")

            txtDia.Text = data(0)
            txtMes.Text = data(1)
            txtAno.Text = data(2)


            rtxtCaracteristicas.Text = dados(0).caracteristicas

            picbFoto.Image = Image.FromFile(dados(0).foto)
        End If
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Dim image As New OpenFileDialog

        image.ShowDialog()
        If image.FileName <> "" Then
            Dim image2 As String = image.FileName
            picbFoto.Image = System.Drawing.Image.FromFile(image2)

            guardarFoto = image2
        End If
    End Sub

    Private Sub btnUltimoReg_Click(sender As Object, e As EventArgs) Handles btnUltimoReg.Click
        Dim data(3) As String
        If dados(0).nome = "" Then

            MsgBox("Não existe registos.")

        Else

            txtNome.Text = dados(cntGlobal - 1).nome
            cmbEscalao.SelectedItem = dados(cntGlobal - 1).escalao

            data = dados(cntGlobal - 1).data.Split("-")

            txtDia.Text = Data(0)
            txtMes.Text = Data(1)
            txtAno.Text = Data(2)


            rtxtCaracteristicas.Text = dados(cntGlobal - 1).caracteristicas
            picbFoto.Image = Image.FromFile(dados(cntGlobal - 1).foto)
        End If
    End Sub

    Private Sub btnProximoReg_Click(sender As Object, e As EventArgs) Handles btnProximoReg.Click
        Dim i As Integer
        Dim procura As Integer
        Dim data(3) As String


        If dados(0).nome = "" Then

            MsgBox("Não existe registos.")
        Else

            For i = 0 To cntGlobal - 1
                If txtNome.Text = dados(i).nome Then
                    procura = i
                    Exit For
                End If
            Next
            If procura = cntGlobal - 1 Then
                MsgBox("Este é o último")
            Else

                data = dados(procura + 1).data.Split("-")

                txtNome.Text = dados(procura + 1).nome
                cmbEscalao.SelectedItem = dados(procura + 1).escalao
                txtDia.Text = data(0)
                txtMes.Text = data(1)
                txtAno.Text = data(2)

                rtxtCaracteristicas.Text = dados(procura + 1).caracteristicas
                picbFoto.Image = Image.FromFile(dados(procura + 1).foto)
            End If
        End If


    End Sub

    Private Sub btnProcura_Click(sender As Object, e As EventArgs) Handles btnProcura.Click

        Form2.Show()

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim i As Integer
        Dim procura As Integer
        Dim data(3) As String


        If dados(0).nome = "" Then
            MsgBox("Não existe registos.")
        Else

            For i = 0 To cntGlobal - 1
                If txtNome.Text = dados(i).nome Then
                    procura = i
                    Exit For
                End If
            Next
            If procura = 0 Then
                MsgBox("Este é o primeiro")
            Else

                data = dados(procura - 1).data.Split("-")

                txtNome.Text = dados(procura - 1).nome
                rtxtCaracteristicas.Text = dados(procura - 1).caracteristicas
                txtDia.Text = data(0)
                txtMes.Text = data(1)
                txtAno.Text = data(2)

                rtxtCaracteristicas.Text = dados(procura - 1).caracteristicas
                picbFoto.Image = Image.FromFile(dados(procura - 1).foto)
            End If
        End If

    End Sub
    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        Select Case e.KeyChar
            Case Chr(33) To Chr(64)
                e.Handled = True
            Case Chr(91) To Chr(96)
                e.Handled = True
            Case Chr(123) To Chr(126)
                e.Handled = True
        End Select
    End Sub

    Private Sub txtDia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDia.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMes.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAno.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
End Class
Public Class Form2
    Dim totalPessoas As Integer
    Dim dadosProcura(100) As Form1.DadosJogador

    Private Sub rbtNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNome.CheckedChanged
        If rbtNome.Checked = True Then
            txtNome.Enabled = True
        Else
            txtNome.Enabled = False
            txtNome.Text = ""
        End If
    End Sub

    Private Sub rbtEscalao_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEscalao.CheckedChanged
        If rbtEscalao.Checked = True Then
            cmbEscalao.Enabled = True
        Else
            cmbEscalao.Enabled = False
            cmbEscalao.SelectedIndex = -1
        End If
    End Sub

    Private Sub rbtData_CheckedChanged(sender As Object, e As EventArgs) Handles rbtData.CheckedChanged
        If rbtData.Checked = True Then
            txtDia.Enabled = True
            txtMes.Enabled = True
            txtAno.Enabled = True
        Else
            txtDia.Enabled = False
            txtDia.Text = ""
            txtMes.Enabled = False
            txtMes.Text = ""
            txtAno.Enabled = False
            txtAno.Text = ""
        End If
    End Sub

    Private Sub rbtMes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMes.CheckedChanged
        If rbtMes.Checked Then
            txtMes.Enabled = True

        Else
            txtMes.Enabled = False
            txtMes.Text = ""
        End If
    End Sub

    Private Sub rbtAno_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAno.CheckedChanged
        If rbtAno.Checked = True Then
            txtAno.Enabled = True

        Else
            txtAno.Enabled = False
            txtAno.Text = ""
        End If
    End Sub

    Private Sub btnProcura_Click(sender As Object, e As EventArgs) Handles btnProcura.Click
        Dim i, j As Integer
        Dim data() As String
        Dim dataDados() As String
        Dim procura As String
        Dim item As String() = New String(4) {}
        Dim novoItem As ListViewItem
        Dim flag As Boolean = False
        dadosProcura = Form1.dados
        totalPessoas = Form1.cntGlobal


        If rbtNome.Checked Then
            If txtNome.Text <> "" Then

                procura = txtNome.Text

                For i = 0 To totalPessoas - 1
                    If dadosProcura(i).nome = procura Then

                        item(0) = dadosProcura(i).nome
                        item(1) = dadosProcura(i).escalao
                        item(2) = dadosProcura(i).data
                        item(3) = dadosProcura(i).caracteristicas

                        For j = 0 To lstvMain.Items.Count - 1
                            If dadosProcura(i).nome = lstvMain.Items(j).SubItems(0).Text Then
                                flag = True
                            End If
                        Next
                        If flag = False Then
                            novoItem = New ListViewItem(item)
                            lstvMain.Items.Add(novoItem)
                        End If
                    End If
                Next
                MsgBox("Procura concluída.", vbInformation)
            Else
                MsgBox("Introduza um nome", vbCritical)
            End If
        End If

        If rbtEscalao.Checked Then
            If cmbEscalao.SelectedIndex <> -1 Then
                procura = cmbEscalao.Text

                For i = 0 To totalPessoas - 1
                    If dadosProcura(i).escalao = procura Then

                        item(0) = dadosProcura(i).nome
                        item(1) = dadosProcura(i).escalao
                        item(2) = dadosProcura(i).data
                        item(3) = dadosProcura(i).caracteristicas

                        novoItem = New ListViewItem(item)
                        lstvMain.Items.Add(novoItem)
                    End If
                Next
                MsgBox("Procura concluída.", vbInformation)
            Else
                MsgBox("Introduza um escalão", vbCritical)
            End If
        End If

            If rbtData.Checked Then
            If txtDia.Text <> "" And txtMes.Text <> "" And txtAno.Text <> "" Then
                procura = txtDia.Text + "-" + txtMes.Text + "-" + txtAno.Text
                For i = 0 To totalPessoas - 1
                    If dadosProcura(i).escalao = procura Then

                        item(0) = dadosProcura(i).nome
                        item(1) = dadosProcura(i).escalao
                        item(2) = dadosProcura(i).data
                        item(3) = dadosProcura(i).caracteristicas

                        novoItem = New ListViewItem(item)
                        lstvMain.Items.Add(novoItem)
                    End If
                Next
                MsgBox("Procura concluída.", vbInformation)
            Else
                MsgBox("Introduza a data completa", vbInformation)
            End If
        End If

            If rbtMes.Checked Then
            If txtMes.Text <> "" Then
                procura = txtDia.Text + "-" + txtMes.Text + "-" + txtAno.Text
                data = procura.Split("-")
                For i = 0 To totalPessoas - 1
                    dataDados = dadosProcura(i).data.Split("-")
                    If dataDados(1) = data(1) Then

                        item(0) = dadosProcura(i).nome
                        item(1) = dadosProcura(i).escalao
                        item(2) = dadosProcura(i).data
                        item(3) = dadosProcura(i).caracteristicas

                        novoItem = New ListViewItem(item)
                        lstvMain.Items.Add(novoItem)
                    End If
                Next
                MsgBox("Procura concluída.", vbInformation)
            Else
                MsgBox("Introduza o mês.", vbInformation)
            End If
        End If

        If rbtAno.Checked Then
            If txtAno.Text <> "" Then
                procura = txtDia.Text + "-" + txtMes.Text + "-" + txtAno.Text
                data = procura.Split("-")
                For i = 0 To totalPessoas - 1
                    dataDados = dadosProcura(i).data.Split("-")
                    If dataDados(2) = data(2) Then

                        item(0) = dadosProcura(i).nome
                        item(1) = dadosProcura(i).escalao
                        item(2) = dadosProcura(i).data
                        item(3) = dadosProcura(i).caracteristicas

                        novoItem = New ListViewItem(item)
                        lstvMain.Items.Add(novoItem)
                    End If
                Next
                MsgBox("Procura concluída.", vbInformation)
            Else
                MsgBox("Introduza o ano.", vbInformation)
            End If
        End If

    End Sub

    Private Sub lstvMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvMain.SelectedIndexChanged
        Dim i As Integer
        totalPessoas = Form1.cntGlobal
        For i = 0 To totalPessoas - 1
            If dadosProcura(i).nome = lstvMain.Items(lstvMain.FocusedItem.Index).SubItems(0).Text Then
                picbJogador.Image = Image.FromFile(dadosProcura(i).foto)
            End If
        Next


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

    Private Sub txtMes_TextChanged(sender As Object, e As EventArgs) Handles txtMes.TextChanged

    End Sub
End Class
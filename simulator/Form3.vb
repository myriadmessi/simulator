Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For i = 1 To Form1.no_of_process
            Dim txt As New TextBox

            txt.Name = "arrival" & i
            txt.Width = 80
            txt.Left = 120
            Dim txt2 As New TextBox

            txt2.Name = "burst" & i
            txt2.Width = 80
            txt2.Left = 220
            txt2.Height = 20
            txt2.Top = 30 * i

            Me.Controls.Add(txt2)
            txt.Height = 20
            txt.Top = 30 * i
            txt.Focus()
            Me.Controls.Add(txt)

            Dim plabl As New Label


            plabl.Name = "prc" & i
            plabl.Width = 80
            plabl.Left = 40
            plabl.Height = 20
            plabl.Top = 30 * i
            plabl.Text = "PROCESS" & i

            Me.Controls.Add(plabl)




        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        For i = 0 To Form1.no_of_process - 1
            Form1.arrivaltime(i) = Val(Me.Controls.Find("arrival" & i + 1, True)(0).Text)
            Form1.cpuburst(i) = Val(Me.Controls.Find("burst" & i + 1, True)(0).Text)

        Next
        '  MsgBox(Me.Controls.Find("arrival" & 1, True)(0).Text)

     
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
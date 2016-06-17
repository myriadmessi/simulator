Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtno_of_process.Text = "" Then
            MsgBox("process cannot be left blanked")
        Else

            Form1.no_of_process = Val(txtno_of_process.Text)
            ReDim Form1.arrivaltime(Val(txtno_of_process.Text))
            ReDim Form1.cpuburst(Val(txtno_of_process.Text))
            Me.Dispose()


        End If
        Form3.ShowDialog()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class
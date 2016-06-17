Public Class Form1
    Public no_of_process As Integer
    Public arrivaltime(2) As Double
    Public duplicate_arrivaltime(1) As Double
    Public duplicate_cpuburst(1) As Double
    Public index_store(1) As Integer
    Public cpuburst(2) As Double

    Public LEFT_Track As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' sjf_scheduling()
        'show_index()
        '       create_waitingtime()
        '        ComboBox1.Visible = True



    End Sub
    Private Sub sjf_scheduling()
        no_of_process = Form4.process_count
        Dim counter, min, k, temp_new_arrtime As Double
        For i = 0 To no_of_process - 1
            duplicate_cpuburst(i) = cpuburst(i)
            duplicate_arrivaltime(i) = arrivaltime(i)
        Next
        k = duplicate_cpuburst(0)
        For i = 0 To no_of_process - 1
            If (k < duplicate_cpuburst(i)) Then
                k = duplicate_cpuburst(i)
            End If
        Next
        temp_new_arrtime = duplicate_arrivaltime(0) + duplicate_cpuburst(0)

        index_store(0) = 0

        For i = 1 To no_of_process - 1
            min = k + 1
            counter = 0
            For j = 1 To no_of_process - 1

                If (duplicate_cpuburst(j) <> -1 And duplicate_arrivaltime(j) <> -1) Then

                    If (duplicate_arrivaltime(j) <= temp_new_arrtime And min >= duplicate_cpuburst(j)) Then
                        counter = 0
                        If (min = duplicate_cpuburst(j)) Then
                            min = duplicate_cpuburst(j)
                        End If
                        'index_store(i) = j
                        If (min > duplicate_cpuburst(j)) Then
                            min = duplicate_cpuburst(j)
                            index_store(i) = j
                        End If
                    End If
                    If (duplicate_arrivaltime(j) > temp_new_arrtime) Then
                        counter = counter + 1
                    End If
                End If
            Next
            If (counter = no_of_process - i) Then
                index_store(i) = i
                temp_new_arrtime = duplicate_arrivaltime(index_store(i)) + duplicate_cpuburst(index_store(i))
                Set_neg(index_store(i))
            Else
                temp_new_arrtime = temp_new_arrtime + duplicate_cpuburst(index_store(i))
                Set_neg(index_store(i))
            End If
            'MsgBox(counter)
            '   MsgBox(index_store(i))

        Next
        '        show_index()



    End Sub
    Private Sub show_index()
        For i = 0 To no_of_process - 1
            MsgBox(index_store(i))

        Next
    End Sub

    Private Sub Set_neg(ByVal i As Integer)
        duplicate_cpuburst(i) = -1
        duplicate_arrivaltime(i) = -1

    End Sub

    Private Sub create_waitingtime()
        'Dim k As Double
        For i = 0 To no_of_process - 1
            Dim wait, pname, pname2, turnaround As New Label
            ' wait.Text = (k - arrivaltime(index_store(i)))
            wait.Height = 15
            wait.Left = 120
            wait.Width = 80
            wait.Top = 50 + (index_store(i) * 30)
            wait.Name = "wait" & i

            'turnaround.Text = wait.Text + cpuburst(index_store(i))
            turnaround.Left = 120
            turnaround.Height = 15
            turnaround.Top = 50 + (index_store(i) * 30)
            turnaround.Height = 15
            turnaround.Width = 120
            turnaround.Name = "turnaround" & i


            pname.Text = "P" & i + 1
            pname.Width = 25
            pname.Top = 50 + (i * 30)
            pname.Left = 10
            pname.Height = 15
            pname.Name = "PNAME" & i

            pname2.Text = pname.Text
            pname2.Width = 25
            pname2.Left = 10
            pname2.Top = 50 + (i * 30)
            pname2.Name = "pname2" & i
            pname2.Height = 15
            '   avgwait.Text = (Val(avgwait.Text) + Val(wait.Text))
            '  avgturn.Text = (Val(avgturn.Text) + Val(turnaround.Text))
            Me.Panel1.Controls.Add(wait)
            Me.Panel1.Controls.Add(pname)
            Me.Panel2.Controls.Add(turnaround)
            Me.Panel2.Controls.Add(pname2)
            ' k = k + cpuburst(index_store(i))
        Next
        ' avgwait.Text = (Val(avgwait.Text)) / no_of_process
        'avgturn.Text = (Val(avgturn.Text)) / no_of_process
    End Sub

    Private Sub fcfs_scheduling()
        For i = 0 To no_of_process - 1
            index_store(i) = i
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        no_of_process = Form4.process_count
        fcfs_scheduling()
        create_waitingtime()

    End Sub

    Private Sub create_stat()
        Dim k As Double
        For i = 0 To no_of_process - 1
            If (arrivaltime(index_store(i)) < k) Then
                Me.Panel1.Controls.Find("wait" & i, True)(0).Text = (k - arrivaltime(index_store(i)))
            Else
                Me.Panel1.Controls.Find("wait" & i, True)(0).Text = 0
            End If

            Me.Panel2.Controls.Find("turnaround" & i, True)(0).Text = Me.Panel1.Controls.Find("wait" & i, True)(0).Text + cpuburst(index_store(i))
            Me.Panel1.Controls.Find("wait" & i, True)(0).Top = 50 + index_store(i) * 30
            Me.Panel2.Controls.Find("turnaround" & i, True)(0).Top = 50 + index_store(i) * 30
            k = k + cpuburst(index_store(i))
            avgwait.Text = (Val(avgwait.Text) + Val(Me.Panel1.Controls.Find("wait" & i, True)(0).Text))
            avgturn.Text = (Val(avgturn.Text) + Val(Me.Panel2.Controls.Find("turnaround" & i, True)(0).Text))

        Next
        avgwait.Text = (Val(avgwait.Text)) / no_of_process
        avgturn.Text = (Val(avgturn.Text)) / no_of_process

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        MsgBox(ComboBox1.SelectedItem)

        If ComboBox1.SelectedItem = "FCFS" Then
            fcfs_scheduling()
            avgturn.Text = 0
            avgwait.Text = 0

        ElseIf ComboBox1.SelectedItem = "SJF" Then

            sjf_scheduling()
            avgturn.Text = 0
            avgwait.Text = 0

        End If
        create_stat()
    End Sub

End Class

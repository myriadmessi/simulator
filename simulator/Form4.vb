
Public Class Form4
    Public processarray(1) As Integer
    Public process_count As Integer
    Public current_running As Integer
    Public caste_progres As ProgressBar
    Public left_track As Integer
    Public current_track As Integer
    Public RANDOMCOLOR As Color
    Public originalarray(1) As Integer
    Public arrival_counter As Double
    Public length, simlength, outcoming, simindex As Integer
    Public time_counter, time_counter2 As Double


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        caste_progres.Left = 0
        'MsgBox(Rnd() * 100)
        process_count = 1
        current_running = 1
        current_track = 1
        left_track = 50
        length = 1
        outcoming = 2
        simindex = 1
        simlength = 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
        processarray(0) = Val(burst0.Text)
        originalarray(0) = processarray(0)
        create_simulation_box()
        Me.Controls.Find("sim_box" & 1, True)(0).Tag = processarray(0)
        create_progress()
        create_process_name()
        'msgbox( IndexOf(processarray, Val(TextBox1.Text))
        'MsgBox(caste_progres.Maximum)
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim txt2 As New System.Windows.Forms.TextBox
        Dim labl As New Label
        txt2.Name = "burst" & process_count
        txt2.Width = 40
        txt2.Left = 85
        txt2.Height = 20
        txt2.Top = 30 * (process_count + 1)
        labl.Width = 30
        labl.Height = 20
        labl.Text = "P" & process_count + 1
        labl.Left = 10
        labl.Top = txt2.Top
        labl.ForeColor = Color.AntiqueWhite
        Me.Panel2.Controls.Add(txt2)
        Me.Panel2.Controls.Add(labl)
        process_count = process_count + 1
        ReDim Preserve processarray(process_count)
        ReDim Preserve originalarray(process_count)
    End Sub
    Private Sub sort(ByVal lower_bound As Integer, ByVal upper_bound As Integer)
        Dim temp As Integer
        For i = lower_bound To upper_bound - 1
            For j = i + 1 To upper_bound
                If processarray(j) < processarray(i) Then
                    temp = processarray(j)
                    processarray(j) = processarray(i)
                    processarray(i) = temp
                End If
            Next
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONFIRM.Click

        create_simulation_box()
        arrival_counter = arrival_counter + 0.01
      

        Dim k As Double
        k = 0.01

        For i = length To process_count - 1
            processarray(i) = Val(Me.Panel2.Controls.Find("burst" & i, True)(0).Text)
            Me.Panel3.Controls.Find("sim_box" & i + 1, True)(0).Tag = processarray(i)
            originalarray(i) = processarray(i)
            Dim arv_labl As New Label
            arv_labl.Width = 30
            arv_labl.Height = 20
            arv_labl.Text = (arrival_counter / 5) + k
            arv_labl.ForeColor = Color.AntiqueWhite
            arv_labl.Left = 50
            arv_labl.Top = 30 * (i + 1)
            arv_labl.Name = "arv_labl" & i
            Me.Panel2.Controls.Add(arv_labl)
            k = k + 0.01
        Next
        length = process_count
        '   MsgBox(originalarray(current_running - 1))
        If ComboBox1.SelectedItem = "SJF" Then
            sort(current_running, process_count - 1)
        End If
        'sort(current_running, process_count - 1)
      
        ' sort(current_running, process_count - 1)
    End Sub
    Private Sub create_progress()
        Dim prog1 As New ProgressBar
        prog1.Name = "progress" & current_running
        prog1.Maximum = processarray(current_running - 1) * 25
        prog1.Width = prog1.Maximum
        prog1.Height = 20
        prog1.Top = 25 * current_running
        prog1.Step = 5
        prog1.Left = left_track
        prog1.Enabled = True
        Me.Panel1.Controls.Add(prog1)
        caste_progres = Me.Panel1.Controls.Find("progress" & current_running, True)(0)
        caste_progres.Value = 0
        left_track = caste_progres.Width + caste_progres.Left
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        arrival_counter = arrival_counter + 1
        If caste_progres.Value = processarray(current_running - 1) * 25 And (current_running < process_count) Then
            '  MsgBox(current_running)
            If (processarray(current_running) <> 0) Then
                current_running = current_running + 1
                create_progress()
                create_process_name()
            End If
            '        MsgBox(caste_progres.Maximum)
            '    ElseIf current_running = process_count Then
            '        current_running = process_count
            '    End If
        ElseIf caste_progres.Value < caste_progres.Maximum Then
            caste_progres.Value = caste_progres.Value + 5
        Else
            ' MsgBox(current_running)
        End If
    End Sub
    Private Function find_index(ByVal k As Double) As Integer
        '   MsgBox(processarray(current_running - 1))
        Dim x As Integer
        For i = 0 To process_count - 1
            If originalarray(i) = k Then
                originalarray(i) = -1
                x = i + 1
                '  MsgBox(x)
                Exit For
            End If
        Next
        Return (x)
    End Function
    Private Sub create_process_name()
        Dim lbl As New Label
        lbl.Name = "lable" & current_running
        lbl.Top = 25 * current_running
        lbl.Left = 20
        lbl.Width = 580
        lbl.Text = "p" & (find_index(processarray(current_running - 1)))
        Me.Panel1.Controls.Add(lbl)
    End Sub
    Private Sub create_simulation_box()
        For i = simlength To process_count

            Dim txt3 As New TextBox
            txt3.Name = "sim_box" & i
            txt3.Left = 41
            txt3.Top = 449 - (20 * i)
            txt3.Width = 110
            txt3.BorderStyle = BorderStyle.Fixed3D
            txt3.Text = "P" & i
            txt3.TextAlign = HorizontalAlignment.Center
            txt3.BackColor = Color.FromArgb(255 - (Rnd() * 100), 255 - (Rnd() * 140), 255 - (Rnd() * 120))
            Me.Panel3.Controls.Add(txt3)

        Next
        simlength = process_count + 1
    End Sub
    Private Sub show_tansition()
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If (Me.Panel1.Controls.Find(("progress" & current_track), True)(0).Top <= (Panel1.Height + Panel1.Top - 40)) Then
            Me.Panel1.Controls.Find(("progress" & current_track), True)(0).Top = Me.Panel1.Controls.Find(("progress" & current_track), True)(0).Top + 5
        ElseIf (current_track >= 1) Then
            Me.Panel1.Controls.Find(("lable" & current_track), True)(0).Top = Me.Panel1.Controls.Find(("progress" & current_track), True)(0).Top - 20
            Me.Panel1.Controls.Find(("lable" & current_track), True)(0).Left = Me.Panel1.Controls.Find(("progress" & current_track), True)(0).Left
            Me.Panel1.Controls.Find(("lable" & current_track), True)(0).Width = 25
            current_track = current_track - 1
            If (current_track = 0) Then
                Timer3.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button4_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer3.Enabled = True
        current_track = current_running
    End Sub


    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(processarray(current_running))
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ReDim Form1.duplicate_arrivaltime(process_count)
        ReDim Form1.duplicate_cpuburst(process_count)
        ReDim Form1.arrivaltime(process_count)
        ReDim Form1.cpuburst(process_count)
        ReDim Form1.index_store(process_count)

        For i = 0 To process_count - 1
            Form1.arrivaltime(i) = Val(Me.Panel2.Controls.Find("arv_labl" & i, True)(0).Text)
            Form1.cpuburst(i) = Val(Me.Panel2.Controls.Find("burst" & i, True)(0).Text)
            ' Form1.duplicate_cpuburst(i) = Form1.cpuburst(i)
            'Form1.duplicate_arrivaltime(i) = Form1.arrivaltime(i)

        Next
        Form1.ShowDialog()
    End Sub

    Private Sub Button3_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Panel3.Controls.Find("sim_box" & Form1.index_store(simindex - 1) + 1, True)(0).Left = 250
        Me.Panel3.Controls.Find("sim_box" & Form1.index_store(simindex - 1) + 1, True)(0).Top = 20

        'For i = 0 To process_count - 1
        '    MsgBox(Val(Me.Panel2.Controls.Find("arv_labl" & i, True)(0).Text))
        'Next
        '        labl_cpu.ForeColor = Color.DarkBlue
        Timer2.Enabled = Not Timer2.Enabled

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

   
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim x As Integer
        For i = outcoming To process_count

            If (time_counter >= Me.Panel2.Controls.Find("arv_labl" & i - 1, True)(0).Text) Then
                Me.Panel3.Controls.Find("sim_box" & i, True)(0).Left = 183
                Me.Panel3.Controls.Find("sim_box" & i, True)(0).Top -= 10 * i

                outcoming = outcoming + 1
            End If

        Next
        If time_counter2 >= processarray(simindex - 1) And (simindex <= process_count) Then
            simindex = simindex + 1
            time_counter2 = 0
            Timer4.Enabled = True
            Timer2.Enabled = False


        End If
        x = Val(t_count.Text) * 100

        If x Mod 2 = 0 Then
            labl_cpu.ForeColor = Color.White
            '    ' MsgBox("hii")
        Else

            labl_cpu.ForeColor = Color.Red

        End If

        time_counter = time_counter + 0.01
        time_counter2 = time_counter2 + 0.01
        t_count.Text = time_counter
      
        ''   

         End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        If PictureBox1.Top = Me.Panel3.Controls.Find("sim_box" & Form1.index_store(simindex - 1) + 1, True)(0).Top And simindex <= process_count Then
            Me.Panel3.Controls.Find("sim_box" & Form1.index_store(simindex - 1) + 1, True)(0).Left = 250
            Me.Panel3.Controls.Find("sim_box" & Form1.index_store(simindex - 1) + 1, True)(0).Top = 20 * (simindex + 1)
            labl_cpu.Top = 20 * (simindex + 1)
            PictureBox1.Top = 430
            Timer2.Enabled = True
            Timer4.Enabled = False

        ElseIf simindex > process_count Then
            Timer4.Enabled = False
        Else

            PictureBox1.Top -= 1
        End If
        If PictureBox1.Top Mod 2 = 0 Then
            labl_sched.ForeColor = Color.White
        Else
            labl_sched.ForeColor = Color.Red

        End If

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.start = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.burst0 = New System.Windows.Forms.TextBox()
        Me.CONFIRM = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.arv_labl0 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.t_count = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.labl_sched = New System.Windows.Forms.Label()
        Me.labl_cpu = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(11, 499)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(99, 39)
        Me.start.TabIndex = 0
        Me.start.Text = "START"
        Me.start.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(627, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'burst0
        '
        Me.burst0.Location = New System.Drawing.Point(85, 30)
        Me.burst0.Name = "burst0"
        Me.burst0.Size = New System.Drawing.Size(40, 20)
        Me.burst0.TabIndex = 2
        '
        'CONFIRM
        '
        Me.CONFIRM.Location = New System.Drawing.Point(658, 8)
        Me.CONFIRM.Name = "CONFIRM"
        Me.CONFIRM.Size = New System.Drawing.Size(75, 30)
        Me.CONFIRM.TabIndex = 3
        Me.CONFIRM.Text = "CONFIRM"
        Me.CONFIRM.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.images
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(11, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 481)
        Me.Panel1.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ComboBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"FCFS", "SJF"})
        Me.ComboBox1.Location = New System.Drawing.Point(252, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(116, 500)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 38)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "STOP"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Controls.Add(Me.arv_labl0)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.burst0)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(627, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(154, 453)
        Me.Panel2.TabIndex = 7
        '
        'arv_labl0
        '
        Me.arv_labl0.AutoSize = True
        Me.arv_labl0.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.arv_labl0.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.arv_labl0.Location = New System.Drawing.Point(48, 33)
        Me.arv_labl0.Name = "arv_labl0"
        Me.arv_labl0.Size = New System.Drawing.Size(22, 13)
        Me.arv_labl0.TabIndex = 4
        Me.arv_labl0.Text = "0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(10, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "P1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(78, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BURST TIME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROCESS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 500)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "CRITERION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(326, 500)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 38)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "TRANSITIONING"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.labl_cpu)
        Me.Panel3.Controls.Add(Me.labl_sched)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.t_count)
        Me.Panel3.Controls.Add(Me.ShapeContainer2)
        Me.Panel3.ForeColor = System.Drawing.Color.Red
        Me.Panel3.Location = New System.Drawing.Point(872, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(422, 481)
        Me.Panel3.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.arrow_right
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(162, 419)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 31)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        't_count
        '
        Me.t_count.AutoSize = True
        Me.t_count.ForeColor = System.Drawing.Color.Black
        Me.t_count.Location = New System.Drawing.Point(183, 7)
        Me.t_count.Name = "t_count"
        Me.t_count.Size = New System.Drawing.Size(13, 13)
        Me.t_count.TabIndex = 1
        Me.t_count.Text = "0"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(422, 481)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 4
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 155
        Me.LineShape3.X2 = 36
        Me.LineShape3.Y1 = 455
        Me.LineShape3.Y2 = 455
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 4
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 37
        Me.LineShape2.X2 = 37
        Me.LineShape2.Y1 = 26
        Me.LineShape2.Y2 = 455
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 4
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 153
        Me.LineShape1.X2 = 153
        Me.LineShape1.Y1 = 26
        Me.LineShape1.Y2 = 453
        '
        'Timer2
        '
        '
        'Timer4
        '
        Me.Timer4.Interval = 40
        '
        'labl_sched
        '
        Me.labl_sched.AutoSize = True
        Me.labl_sched.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labl_sched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labl_sched.ForeColor = System.Drawing.Color.Red
        Me.labl_sched.Location = New System.Drawing.Point(303, 440)
        Me.labl_sched.Name = "labl_sched"
        Me.labl_sched.Size = New System.Drawing.Size(100, 16)
        Me.labl_sched.TabIndex = 3
        Me.labl_sched.Text = "SCHEDULER"
        '
        'labl_cpu
        '
        Me.labl_cpu.AutoSize = True
        Me.labl_cpu.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labl_cpu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labl_cpu.ForeColor = System.Drawing.Color.Red
        Me.labl_cpu.Location = New System.Drawing.Point(368, 20)
        Me.labl_cpu.Name = "labl_cpu"
        Me.labl_cpu.Size = New System.Drawing.Size(51, 16)
        Me.labl_cpu.TabIndex = 4
        Me.labl_cpu.Text = "CPU..."
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.simulator_panel2
        Me.ClientSize = New System.Drawing.Size(1306, 597)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CONFIRM)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.start)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents start As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents burst0 As System.Windows.Forms.TextBox
    Friend WithEvents CONFIRM As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents arv_labl0 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents t_count As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents labl_cpu As System.Windows.Forms.Label
    Friend WithEvents labl_sched As System.Windows.Forms.Label
End Class

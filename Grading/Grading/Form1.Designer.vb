<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grading))
        Me.leave = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtclass = New System.Windows.Forms.TextBox()
        Me.txtmathematics = New System.Windows.Forms.TextBox()
        Me.txtenglish = New System.Windows.Forms.TextBox()
        Me.txtkiswahili = New System.Windows.Forms.TextBox()
        Me.txtaverage = New System.Windows.Forms.TextBox()
        Me.txtgrade = New System.Windows.Forms.TextBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.grade = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'leave
        '
        Me.leave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.leave.FlatAppearance.BorderSize = 0
        Me.leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.leave.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.leave.Location = New System.Drawing.Point(892, 0)
        Me.leave.Margin = New System.Windows.Forms.Padding(0)
        Me.leave.Name = "leave"
        Me.leave.Size = New System.Drawing.Size(114, 39)
        Me.leave.TabIndex = 17
        Me.leave.Text = "Exit"
        Me.leave.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1201, 620)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student's Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student's Class:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(170, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mathematics:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(424, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "English:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(674, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kiswahili:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Average:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Grade:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(175, 87)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(384, 29)
        Me.txtname.TabIndex = 7
        '
        'txtclass
        '
        Me.txtclass.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclass.Location = New System.Drawing.Point(175, 136)
        Me.txtclass.Name = "txtclass"
        Me.txtclass.Size = New System.Drawing.Size(181, 29)
        Me.txtclass.TabIndex = 8
        '
        'txtmathematics
        '
        Me.txtmathematics.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmathematics.Location = New System.Drawing.Point(138, 212)
        Me.txtmathematics.Name = "txtmathematics"
        Me.txtmathematics.Size = New System.Drawing.Size(181, 29)
        Me.txtmathematics.TabIndex = 9
        '
        'txtenglish
        '
        Me.txtenglish.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtenglish.Location = New System.Drawing.Point(378, 212)
        Me.txtenglish.Name = "txtenglish"
        Me.txtenglish.Size = New System.Drawing.Size(181, 29)
        Me.txtenglish.TabIndex = 10
        '
        'txtkiswahili
        '
        Me.txtkiswahili.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkiswahili.Location = New System.Drawing.Point(627, 212)
        Me.txtkiswahili.Name = "txtkiswahili"
        Me.txtkiswahili.Size = New System.Drawing.Size(181, 29)
        Me.txtkiswahili.TabIndex = 11
        '
        'txtaverage
        '
        Me.txtaverage.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaverage.Location = New System.Drawing.Point(107, 328)
        Me.txtaverage.Name = "txtaverage"
        Me.txtaverage.ReadOnly = True
        Me.txtaverage.Size = New System.Drawing.Size(181, 29)
        Me.txtaverage.TabIndex = 12
        '
        'txtgrade
        '
        Me.txtgrade.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrade.Location = New System.Drawing.Point(106, 365)
        Me.txtgrade.Name = "txtgrade"
        Me.txtgrade.ReadOnly = True
        Me.txtgrade.Size = New System.Drawing.Size(181, 29)
        Me.txtgrade.TabIndex = 13
        '
        'calculate
        '
        Me.calculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.calculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calculate.FlatAppearance.BorderSize = 0
        Me.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate.Location = New System.Drawing.Point(413, 257)
        Me.calculate.Margin = New System.Windows.Forms.Padding(0)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(111, 47)
        Me.calculate.TabIndex = 14
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = False
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reset.FlatAppearance.BorderSize = 0
        Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reset.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(663, 413)
        Me.reset.Margin = New System.Windows.Forms.Padding(0)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(111, 47)
        Me.reset.TabIndex = 15
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'grade
        '
        Me.grade.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grade.FlatAppearance.BorderSize = 0
        Me.grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grade.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.Location = New System.Drawing.Point(176, 413)
        Me.grade.Margin = New System.Windows.Forms.Padding(0)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(111, 47)
        Me.grade.TabIndex = 16
        Me.grade.Text = "Grade"
        Me.grade.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.grade)
        Me.GroupBox1.Controls.Add(Me.reset)
        Me.GroupBox1.Controls.Add(Me.calculate)
        Me.GroupBox1.Controls.Add(Me.txtgrade)
        Me.GroupBox1.Controls.Add(Me.txtaverage)
        Me.GroupBox1.Controls.Add(Me.txtkiswahili)
        Me.GroupBox1.Controls.Add(Me.txtenglish)
        Me.GroupBox1.Controls.Add(Me.txtmathematics)
        Me.GroupBox1.Controls.Add(Me.txtclass)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(112, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1012, 554)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grading System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.leave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 39)
        Me.Panel1.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "MAKINI SCHOOLS"
        '
        'grading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 620)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "grading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grading"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leave As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtclass As System.Windows.Forms.TextBox
    Friend WithEvents txtmathematics As System.Windows.Forms.TextBox
    Friend WithEvents txtenglish As System.Windows.Forms.TextBox
    Friend WithEvents txtkiswahili As System.Windows.Forms.TextBox
    Friend WithEvents txtaverage As System.Windows.Forms.TextBox
    Friend WithEvents txtgrade As System.Windows.Forms.TextBox
    Friend WithEvents calculate As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents grade As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class

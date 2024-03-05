<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grade))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.lblaverage = New System.Windows.Forms.Label()
        Me.lblclass = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.back)
        Me.GroupBox1.Controls.Add(Me.lblgrade)
        Me.GroupBox1.Controls.Add(Me.lblaverage)
        Me.GroupBox1.Controls.Add(Me.lblclass)
        Me.GroupBox1.Controls.Add(Me.lblname)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 386)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Grade"
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.BackColor = System.Drawing.Color.Transparent
        Me.lblgrade.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrade.Location = New System.Drawing.Point(259, 238)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(109, 38)
        Me.lblgrade.TabIndex = 3
        Me.lblgrade.Text = "Label4"
        '
        'lblaverage
        '
        Me.lblaverage.AutoSize = True
        Me.lblaverage.BackColor = System.Drawing.Color.Transparent
        Me.lblaverage.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaverage.Location = New System.Drawing.Point(92, 184)
        Me.lblaverage.Name = "lblaverage"
        Me.lblaverage.Size = New System.Drawing.Size(99, 38)
        Me.lblaverage.TabIndex = 2
        Me.lblaverage.Text = "Label3"
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.BackColor = System.Drawing.Color.Transparent
        Me.lblclass.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclass.Location = New System.Drawing.Point(90, 127)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(99, 38)
        Me.lblclass.TabIndex = 1
        Me.lblclass.Text = "Label2"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(92, 77)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(97, 38)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Label1"
        '
        'back
        '
        Me.back.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.FlatAppearance.BorderSize = 0
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Font = New System.Drawing.Font("Segoe UI Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(492, 20)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(111, 47)
        Me.back.TabIndex = 4
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'Grade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 490)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Grade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblgrade As System.Windows.Forms.Label
    Friend WithEvents lblaverage As System.Windows.Forms.Label
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents back As System.Windows.Forms.Button
End Class

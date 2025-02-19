<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Acess = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Textip = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextSenha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextData = New System.Windows.Forms.TextBox()
        Me.TextUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout
        Me.Acess.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.SuspendLayout
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(19, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 23)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox2.Location = New System.Drawing.Point(19, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(329, 23)
        Me.TextBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Local"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(16, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(313, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Acess)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(386, 277)
        Me.TabControl1.TabIndex = 8
        '
        'Acess
        '
        Me.Acess.Controls.Add(Me.TextBox1)
        Me.Acess.Controls.Add(Me.Button1)
        Me.Acess.Controls.Add(Me.Button2)
        Me.Acess.Controls.Add(Me.TextBox2)
        Me.Acess.Controls.Add(Me.Label2)
        Me.Acess.Controls.Add(Me.Label1)
        Me.Acess.Location = New System.Drawing.Point(4, 22)
        Me.Acess.Name = "Acess"
        Me.Acess.Padding = New System.Windows.Forms.Padding(3)
        Me.Acess.Size = New System.Drawing.Size(378, 251)
        Me.Acess.TabIndex = 0
        Me.Acess.Text = "Acess"
        Me.Acess.UseVisualStyleBackColor = true
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextData)
        Me.TabPage2.Controls.Add(Me.TextUser)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Textip)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.TextSenha)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(378, 251)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SQL"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'Textip
        '
        Me.Textip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Textip.Location = New System.Drawing.Point(21, 58)
        Me.Textip.Name = "Textip"
        Me.Textip.Size = New System.Drawing.Size(140, 23)
        Me.Textip.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 37)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'TextSenha
        '
        Me.TextSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextSenha.Location = New System.Drawing.Point(21, 128)
        Me.TextSenha.Name = "TextSenha"
        Me.TextSenha.Size = New System.Drawing.Size(140, 23)
        Me.TextSenha.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(18, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(18, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "IP"
        '
        'TextData
        '
        Me.TextData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextData.Location = New System.Drawing.Point(216, 58)
        Me.TextData.Name = "TextData"
        Me.TextData.Size = New System.Drawing.Size(140, 23)
        Me.TextData.TabIndex = 13
        '
        'TextUser
        '
        Me.TextUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextUser.Location = New System.Drawing.Point(216, 128)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.Size = New System.Drawing.Size(140, 23)
        Me.TextUser.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(213, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(213, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "DataTable"
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 300)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Config"
        Me.Text = "d"
        Me.TabControl1.ResumeLayout(false)
        Me.Acess.ResumeLayout(false)
        Me.Acess.PerformLayout
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage2.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Acess As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Textip As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextSenha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextData As TextBox
    Friend WithEvents TextUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

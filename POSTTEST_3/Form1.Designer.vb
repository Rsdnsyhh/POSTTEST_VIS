<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        gbJenisKelamin = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        gbHobi = New GroupBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        btnPilihGambar = New Button()
        btnCetakKartu = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        gbJenisKelamin.SuspendLayout()
        gbHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(186, 227)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(216, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(216, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 2
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(216, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 3
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(216, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 15)
        Label4.TabIndex = 4
        Label4.Text = "No Telpon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(216, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 5
        Label5.Text = "Alamat"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(326, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(344, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(326, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(344, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(326, 146)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(344, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(326, 182)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(344, 23)
        TextBox4.TabIndex = 9
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(326, 105)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(344, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' gbJenisKelamin
        ' 
        gbJenisKelamin.Controls.Add(RadioButton2)
        gbJenisKelamin.Controls.Add(RadioButton1)
        gbJenisKelamin.Location = New Point(216, 211)
        gbJenisKelamin.Name = "gbJenisKelamin"
        gbJenisKelamin.Size = New Size(200, 203)
        gbJenisKelamin.TabIndex = 11
        gbJenisKelamin.TabStop = False
        gbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(22, 98)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(86, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(26, 42)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(70, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki Laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(CheckBox10)
        gbHobi.Controls.Add(CheckBox9)
        gbHobi.Controls.Add(CheckBox8)
        gbHobi.Controls.Add(CheckBox7)
        gbHobi.Controls.Add(CheckBox6)
        gbHobi.Controls.Add(CheckBox5)
        gbHobi.Controls.Add(CheckBox4)
        gbHobi.Controls.Add(CheckBox3)
        gbHobi.Controls.Add(CheckBox2)
        gbHobi.Controls.Add(CheckBox1)
        gbHobi.Location = New Point(450, 253)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(320, 161)
        gbHobi.TabIndex = 12
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(141, 127)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(73, 19)
        CheckBox10.TabIndex = 9
        CheckBox10.Text = "Ngoding"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(141, 102)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(78, 19)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "Menyanyi"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(141, 77)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(68, 19)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Menulis"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(141, 52)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(74, 19)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Fotografi"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(141, 27)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(90, 19)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Memancing"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(16, 127)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(98, 19)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Menggambar"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(16, 102)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(49, 19)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Film"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(16, 77)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(74, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Olahraga"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(16, 52)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(58, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Musik"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(16, 27)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(68, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Gaming"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnPilihGambar
        ' 
        btnPilihGambar.Location = New Point(12, 275)
        btnPilihGambar.Name = "btnPilihGambar"
        btnPilihGambar.Size = New Size(186, 23)
        btnPilihGambar.TabIndex = 13
        btnPilihGambar.Text = "Pilih Gambar"
        btnPilihGambar.UseVisualStyleBackColor = True
        ' 
        ' btnCetakKartu
        ' 
        btnCetakKartu.Location = New Point(216, 420)
        btnCetakKartu.Name = "btnCetakKartu"
        btnCetakKartu.Size = New Size(554, 23)
        btnCetakKartu.TabIndex = 14
        btnCetakKartu.Text = "Cetak Kartu"
        btnCetakKartu.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCetakKartu)
        Controls.Add(btnPilihGambar)
        Controls.Add(gbHobi)
        Controls.Add(gbJenisKelamin)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        gbJenisKelamin.ResumeLayout(False)
        gbJenisKelamin.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnPilihGambar As Button
    Friend WithEvents btnCetakKartu As Buttonf
End Class
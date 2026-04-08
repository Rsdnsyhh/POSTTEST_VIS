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
        lblIpSemester = New Label()
        txtIP = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        lblIpKumulatif = New Label()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' lblIpSemester
        ' 
        lblIpSemester.AutoSize = True
        lblIpSemester.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblIpSemester.Location = New Point(165, 86)
        lblIpSemester.Name = "lblIpSemester"
        lblIpSemester.Size = New Size(88, 20)
        lblIpSemester.TabIndex = 0
        lblIpSemester.Text = "IP Semester"
        ' 
        ' txtIP
        ' 
        txtIP.Location = New Point(330, 79)
        txtIP.Name = "txtIP"
        txtIP.Size = New Size(228, 27)
        txtIP.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(330, 129)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(464, 129)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblIpKumulatif
        ' 
        lblIpKumulatif.AutoSize = True
        lblIpKumulatif.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblIpKumulatif.Location = New Point(165, 185)
        lblIpKumulatif.Name = "lblIpKumulatif"
        lblIpKumulatif.Size = New Size(93, 20)
        lblIpKumulatif.TabIndex = 4
        lblIpKumulatif.Text = "IP Kumulatif"
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(330, 182)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(228, 27)
        txtIPK.TabIndex = 5
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(330, 229)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(15, 20)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(lblIpKumulatif)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIP)
        Controls.Add(lblIpSemester)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIpSemester As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblIpKumulatif As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label

End Class

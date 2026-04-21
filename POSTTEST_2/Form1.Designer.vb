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
        lblJudulBuku = New Label()
        lblGenre = New Label()
        btnTambah = New Button()
        txtJudulBuku = New TextBox()
        txtGenre = New TextBox()
        gbTambahBuku = New GroupBox()
        gbHapusBuku = New GroupBox()
        btnHapus = New Button()
        TextBox1 = New TextBox()
        lblJudulBuku2 = New Label()
        dgvHasil = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        gbTambahBuku.SuspendLayout()
        gbHapusBuku.SuspendLayout()
        CType(dgvHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulBuku
        ' 
        lblJudulBuku.AutoSize = True
        lblJudulBuku.ForeColor = Color.Black
        lblJudulBuku.Location = New Point(18, 36)
        lblJudulBuku.Name = "lblJudulBuku"
        lblJudulBuku.Size = New Size(79, 20)
        lblJudulBuku.TabIndex = 1
        lblJudulBuku.Text = "Judul Buku"
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(18, 79)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(48, 20)
        lblGenre.TabIndex = 2
        lblGenre.Text = "Genre"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.SpringGreen
        btnTambah.Location = New Point(170, 130)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtJudulBuku
        ' 
        txtJudulBuku.Location = New Point(118, 36)
        txtJudulBuku.Name = "txtJudulBuku"
        txtJudulBuku.Size = New Size(202, 27)
        txtJudulBuku.TabIndex = 4
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(118, 79)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(202, 27)
        txtGenre.TabIndex = 5
        ' 
        ' gbTambahBuku
        ' 
        gbTambahBuku.BackColor = Color.Green
        gbTambahBuku.Controls.Add(txtGenre)
        gbTambahBuku.Controls.Add(lblGenre)
        gbTambahBuku.Controls.Add(lblJudulBuku)
        gbTambahBuku.Controls.Add(btnTambah)
        gbTambahBuku.Controls.Add(txtJudulBuku)
        gbTambahBuku.ForeColor = SystemColors.ActiveCaptionText
        gbTambahBuku.Location = New Point(12, 24)
        gbTambahBuku.Name = "gbTambahBuku"
        gbTambahBuku.Size = New Size(363, 188)
        gbTambahBuku.TabIndex = 6
        gbTambahBuku.TabStop = False
        gbTambahBuku.Text = "Tambah Buku"
        ' 
        ' gbHapusBuku
        ' 
        gbHapusBuku.BackColor = Color.Maroon
        gbHapusBuku.Controls.Add(btnHapus)
        gbHapusBuku.Controls.Add(TextBox1)
        gbHapusBuku.Controls.Add(lblJudulBuku2)
        gbHapusBuku.ForeColor = Color.White
        gbHapusBuku.Location = New Point(12, 227)
        gbHapusBuku.Name = "gbHapusBuku"
        gbHapusBuku.Size = New Size(363, 197)
        gbHapusBuku.TabIndex = 7
        gbHapusBuku.TabStop = False
        gbHapusBuku.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Crimson
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(170, 121)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(110, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(212, 27)
        TextBox1.TabIndex = 1
        ' 
        ' lblJudulBuku2
        ' 
        lblJudulBuku2.AutoSize = True
        lblJudulBuku2.ForeColor = Color.White
        lblJudulBuku2.Location = New Point(25, 36)
        lblJudulBuku2.Name = "lblJudulBuku2"
        lblJudulBuku2.Size = New Size(79, 20)
        lblJudulBuku2.TabIndex = 0
        lblJudulBuku2.Text = "Judul Buku"
        ' 
        ' dgvHasil
        ' 
        dgvHasil.BackgroundColor = Color.Yellow
        dgvHasil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHasil.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvHasil.Location = New Point(410, 24)
        dgvHasil.Name = "dgvHasil"
        dgvHasil.RowHeadersWidth = 51
        dgvHasil.Size = New Size(337, 400)
        dgvHasil.TabIndex = 8
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul Buku"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Genre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(800, 450)
        Controls.Add(dgvHasil)
        Controls.Add(gbHapusBuku)
        Controls.Add(gbTambahBuku)
        Name = "Form1"
        Text = "Posttest 2"
        gbTambahBuku.ResumeLayout(False)
        gbTambahBuku.PerformLayout()
        gbHapusBuku.ResumeLayout(False)
        gbHapusBuku.PerformLayout()
        CType(dgvHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblJudulBuku As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents gbTambahBuku As GroupBox
    Friend WithEvents gbHapusBuku As GroupBox
    Friend WithEvents lblJudulBuku2 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvHasil As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class

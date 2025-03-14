<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.nip = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.fakultas = New System.Windows.Forms.Label()
        Me.jurusan = New System.Windows.Forms.Label()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.cbofakultas = New System.Windows.Forms.ComboBox()
        Me.cbojurusan = New System.Windows.Forms.ComboBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbGRADE = New System.Windows.Forms.Label()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.lbUAS = New System.Windows.Forms.Label()
        Me.lbUTS = New System.Windows.Forms.Label()
        Me.lbTugas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'nip
        '
        Me.nip.AutoSize = True
        Me.nip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nip.Location = New System.Drawing.Point(17, 31)
        Me.nip.Name = "nip"
        Me.nip.Size = New System.Drawing.Size(30, 16)
        Me.nip.TabIndex = 0
        Me.nip.Text = "NIP"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(17, 71)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(45, 16)
        Me.nama.TabIndex = 1
        Me.nama.Text = "Nama"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.Location = New System.Drawing.Point(17, 123)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(91, 16)
        Me.gender.TabIndex = 2
        Me.gender.Text = "Jenis Kelamin"
        '
        'fakultas
        '
        Me.fakultas.AutoSize = True
        Me.fakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fakultas.Location = New System.Drawing.Point(17, 169)
        Me.fakultas.Name = "fakultas"
        Me.fakultas.Size = New System.Drawing.Size(59, 16)
        Me.fakultas.TabIndex = 3
        Me.fakultas.Text = "Fakultas"
        '
        'jurusan
        '
        Me.jurusan.AutoSize = True
        Me.jurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jurusan.Location = New System.Drawing.Point(17, 209)
        Me.jurusan.Name = "jurusan"
        Me.jurusan.Size = New System.Drawing.Size(55, 16)
        Me.jurusan.TabIndex = 4
        Me.jurusan.Text = "Jurusan"
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(165, 31)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(307, 20)
        Me.txtnip.TabIndex = 5
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(165, 71)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(458, 20)
        Me.txtnama.TabIndex = 6
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(165, 122)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(68, 17)
        Me.rb1.TabIndex = 7
        Me.rb1.TabStop = True
        Me.rb1.Text = "Laki-Laki"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(337, 123)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(79, 17)
        Me.rb2.TabIndex = 8
        Me.rb2.TabStop = True
        Me.rb2.Text = "Perempuan"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'cbofakultas
        '
        Me.cbofakultas.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cbofakultas.FormattingEnabled = True
        Me.cbofakultas.Items.AddRange(New Object() {"FMIPA", "FP", "FT", "FEB", "FKIP", "FK", "FISIP"})
        Me.cbofakultas.Location = New System.Drawing.Point(165, 169)
        Me.cbofakultas.Name = "cbofakultas"
        Me.cbofakultas.Size = New System.Drawing.Size(307, 21)
        Me.cbofakultas.TabIndex = 9
        '
        'cbojurusan
        '
        Me.cbojurusan.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cbojurusan.FormattingEnabled = True
        Me.cbojurusan.Items.AddRange(New Object() {"ILMU KOMPUTER", "BIOLOGI", "BIOLOGI TERAPAN", "KIMIA", "FISIKA", "MANAJEMEN INFORMATIKA"})
        Me.cbojurusan.Location = New System.Drawing.Point(165, 209)
        Me.cbojurusan.Name = "cbojurusan"
        Me.cbojurusan.Size = New System.Drawing.Size(458, 21)
        Me.cbojurusan.TabIndex = 10
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(6, 19)
        Me.btn.Name = "btn"
        Me.btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn.Size = New System.Drawing.Size(88, 28)
        Me.btn.TabIndex = 11
        Me.btn.Text = "Process"
        Me.btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbGRADE)
        Me.GroupBox1.Controls.Add(Me.txtUTS)
        Me.GroupBox1.Controls.Add(Me.txtUAS)
        Me.GroupBox1.Controls.Add(Me.txtTugas)
        Me.GroupBox1.Controls.Add(Me.lbUAS)
        Me.GroupBox1.Controls.Add(Me.lbUTS)
        Me.GroupBox1.Controls.Add(Me.lbTugas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nip)
        Me.GroupBox1.Controls.Add(Me.nama)
        Me.GroupBox1.Controls.Add(Me.cbojurusan)
        Me.GroupBox1.Controls.Add(Me.gender)
        Me.GroupBox1.Controls.Add(Me.cbofakultas)
        Me.GroupBox1.Controls.Add(Me.fakultas)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.jurusan)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Controls.Add(Me.txtnip)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 325)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'lbGRADE
        '
        Me.lbGRADE.AutoSize = True
        Me.lbGRADE.Location = New System.Drawing.Point(566, 291)
        Me.lbGRADE.Name = "lbGRADE"
        Me.lbGRADE.Size = New System.Drawing.Size(57, 13)
        Me.lbGRADE.TabIndex = 19
        Me.lbGRADE.Text = "--GRADE--"
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(325, 285)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(84, 20)
        Me.txtUTS.TabIndex = 18
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(461, 284)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(76, 20)
        Me.txtUAS.TabIndex = 17
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(203, 284)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(81, 20)
        Me.txtTugas.TabIndex = 16
        '
        'lbUAS
        '
        Me.lbUAS.AutoSize = True
        Me.lbUAS.Location = New System.Drawing.Point(415, 287)
        Me.lbUAS.Name = "lbUAS"
        Me.lbUAS.Size = New System.Drawing.Size(29, 13)
        Me.lbUAS.TabIndex = 15
        Me.lbUAS.Text = "UAS"
        '
        'lbUTS
        '
        Me.lbUTS.AutoSize = True
        Me.lbUTS.Location = New System.Drawing.Point(290, 287)
        Me.lbUTS.Name = "lbUTS"
        Me.lbUTS.Size = New System.Drawing.Size(29, 13)
        Me.lbUTS.TabIndex = 14
        Me.lbUTS.Text = "UTS"
        '
        'lbTugas
        '
        Me.lbTugas.AutoSize = True
        Me.lbTugas.Location = New System.Drawing.Point(160, 284)
        Me.lbTugas.Name = "lbTugas"
        Me.lbTugas.Size = New System.Drawing.Size(37, 13)
        Me.lbTugas.TabIndex = 13
        Me.lbTugas.Text = "Tugas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nilai"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 65)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 426)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nip As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents gender As System.Windows.Forms.Label
    Friend WithEvents fakultas As System.Windows.Forms.Label
    Friend WithEvents jurusan As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents cbofakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cbojurusan As System.Windows.Forms.ComboBox
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbUAS As System.Windows.Forms.Label
    Friend WithEvents lbUTS As System.Windows.Forms.Label
    Friend WithEvents lbTugas As System.Windows.Forms.Label
    Friend WithEvents lbGRADE As System.Windows.Forms.Label
    Friend WithEvents txtUTS As System.Windows.Forms.TextBox
    Friend WithEvents txtUAS As System.Windows.Forms.TextBox
    Friend WithEvents txtTugas As System.Windows.Forms.TextBox

End Class

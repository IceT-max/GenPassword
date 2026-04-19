<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.chkMaiuscole = New System.Windows.Forms.CheckBox()
        Me.chkMinuscole = New System.Windows.Forms.CheckBox()
        Me.chkNumeri = New System.Windows.Forms.CheckBox()
        Me.chkSimboli = New System.Windows.Forms.CheckBox()
        Me.lblLunghezza = New System.Windows.Forms.Label()
        Me.numLunghezza = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantita = New System.Windows.Forms.Label()
        Me.numQuantita = New System.Windows.Forms.NumericUpDown()
        Me.btnGenera = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnCopia = New System.Windows.Forms.Button()
        Me.lblTitolo = New System.Windows.Forms.Label()
        CType(Me.numLunghezza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQuantita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' lblTitolo
        Me.lblTitolo.AutoSize = True
        Me.lblTitolo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitolo.Location = New System.Drawing.Point(75, 20)
        Me.lblTitolo.Name = "lblTitolo"
        Me.lblTitolo.Text = "Generatore di Password"

        ' chkMaiuscole
        Me.chkMaiuscole.AutoSize = True
        Me.chkMaiuscole.Checked = True
        Me.chkMaiuscole.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMaiuscole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.chkMaiuscole.Location = New System.Drawing.Point(40, 70)
        Me.chkMaiuscole.Name = "chkMaiuscole"
        Me.chkMaiuscole.Text = "Maiuscole (A-Z)"

        ' chkMinuscole
        Me.chkMinuscole.AutoSize = True
        Me.chkMinuscole.Checked = True
        Me.chkMinuscole.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMinuscole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.chkMinuscole.Location = New System.Drawing.Point(40, 100)
        Me.chkMinuscole.Name = "chkMinuscole"
        Me.chkMinuscole.Text = "Minuscole (a-z)"

        ' chkNumeri
        Me.chkNumeri.AutoSize = True
        Me.chkNumeri.Checked = True
        Me.chkNumeri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNumeri.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.chkNumeri.Location = New System.Drawing.Point(40, 130)
        Me.chkNumeri.Name = "chkNumeri"
        Me.chkNumeri.Text = "Numeri (0-9)"

        ' chkSimboli
        Me.chkSimboli.AutoSize = True
        Me.chkSimboli.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.chkSimboli.Location = New System.Drawing.Point(40, 160)
        Me.chkSimboli.Name = "chkSimboli"
        Me.chkSimboli.Text = "Simboli  ( , . ; : - + * ? ! $ % & ( ) [ ] )"

        ' lblLunghezza
        Me.lblLunghezza.AutoSize = True
        Me.lblLunghezza.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLunghezza.Location = New System.Drawing.Point(40, 205)
        Me.lblLunghezza.Name = "lblLunghezza"
        Me.lblLunghezza.Text = "Lunghezza:"

        ' numLunghezza
        Me.numLunghezza.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.numLunghezza.Location = New System.Drawing.Point(140, 203)
        Me.numLunghezza.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numLunghezza.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
        Me.numLunghezza.Value = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numLunghezza.Name = "numLunghezza"
        Me.numLunghezza.Width = 65

        ' lblQuantita
        Me.lblQuantita.AutoSize = True
        Me.lblQuantita.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblQuantita.Location = New System.Drawing.Point(40, 237)
        Me.lblQuantita.Name = "lblQuantita"
        Me.lblQuantita.Text = "Quantità:"

        ' numQuantita
        Me.numQuantita.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.numQuantita.Location = New System.Drawing.Point(140, 235)
        Me.numQuantita.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQuantita.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numQuantita.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQuantita.Name = "numQuantita"
        Me.numQuantita.Width = 65

        ' btnGenera
        Me.btnGenera.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenera.Location = New System.Drawing.Point(40, 272)
        Me.btnGenera.Name = "btnGenera"
        Me.btnGenera.Size = New System.Drawing.Size(320, 36)
        Me.btnGenera.Text = "Genera Password"
        Me.btnGenera.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGenera.ForeColor = System.Drawing.Color.White
        Me.btnGenera.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        ' lblPassword
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPassword.Location = New System.Drawing.Point(40, 325)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Text = "Password generate:"

        ' txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.txtPassword.Location = New System.Drawing.Point(40, 348)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Multiline = True
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPassword.Size = New System.Drawing.Size(320, 130)

        ' btnCopia
        Me.btnCopia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCopia.Location = New System.Drawing.Point(40, 492)
        Me.btnCopia.Name = "btnCopia"
        Me.btnCopia.Size = New System.Drawing.Size(320, 32)
        Me.btnCopia.Text = "Copia negli Appunti"
        Me.btnCopia.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCopia.ForeColor = System.Drawing.Color.White
        Me.btnCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        ' Form1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 542)
        Me.Controls.Add(Me.lblTitolo)
        Me.Controls.Add(Me.chkMaiuscole)
        Me.Controls.Add(Me.chkMinuscole)
        Me.Controls.Add(Me.chkNumeri)
        Me.Controls.Add(Me.chkSimboli)
        Me.Controls.Add(Me.lblLunghezza)
        Me.Controls.Add(Me.numLunghezza)
        Me.Controls.Add(Me.lblQuantita)
        Me.Controls.Add(Me.numQuantita)
        Me.Controls.Add(Me.btnGenera)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnCopia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenPassword"
        CType(Me.numLunghezza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQuantita, System.ComponentModel.ISupportInitialize).EndInit()
        ' Icona chiave embedded
        Dim icoStream As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GenPassword.app.ico")
        If icoStream IsNot Nothing Then Me.Icon = New System.Drawing.Icon(icoStream)

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents chkMaiuscole As System.Windows.Forms.CheckBox
    Friend WithEvents chkMinuscole As System.Windows.Forms.CheckBox
    Friend WithEvents chkNumeri As System.Windows.Forms.CheckBox
    Friend WithEvents chkSimboli As System.Windows.Forms.CheckBox
    Friend WithEvents lblLunghezza As System.Windows.Forms.Label
    Friend WithEvents numLunghezza As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblQuantita As System.Windows.Forms.Label
    Friend WithEvents numQuantita As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnGenera As System.Windows.Forms.Button
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCopia As System.Windows.Forms.Button
    Friend WithEvents lblTitolo As System.Windows.Forms.Label

End Class

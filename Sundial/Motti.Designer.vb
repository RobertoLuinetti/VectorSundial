<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Motti
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBoxMotti = New System.Windows.Forms.ListBox()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxMotti
        '
        Me.ListBoxMotti.FormattingEnabled = True
        Me.ListBoxMotti.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxMotti.Name = "ListBoxMotti"
        Me.ListBoxMotti.Size = New System.Drawing.Size(776, 394)
        Me.ListBoxMotti.TabIndex = 0
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Location = New System.Drawing.Point(362, 415)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSelect.TabIndex = 1
        Me.ButtonSelect.Text = "Select"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'Motti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSelect)
        Me.Controls.Add(Me.ListBoxMotti)
        Me.Name = "Motti"
        Me.Text = "Motti"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxMotti As ListBox
    Friend WithEvents ButtonSelect As Button
End Class

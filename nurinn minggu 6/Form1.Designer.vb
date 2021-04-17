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
        Me.lblNamaHari = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstjawab = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblNamaHari
        '
        Me.lblNamaHari.AutoSize = True
        Me.lblNamaHari.Location = New System.Drawing.Point(268, 159)
        Me.lblNamaHari.Name = "lblNamaHari"
        Me.lblNamaHari.Size = New System.Drawing.Size(0, 17)
        Me.lblNamaHari.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstjawab
        '
        Me.lstjawab.FormattingEnabled = True
        Me.lstjawab.ItemHeight = 16
        Me.lstjawab.Location = New System.Drawing.Point(381, 79)
        Me.lstjawab.Name = "lstjawab"
        Me.lstjawab.Size = New System.Drawing.Size(120, 84)
        Me.lstjawab.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstjawab)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNamaHari)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNamaHari As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lstjawab As ListBox
End Class

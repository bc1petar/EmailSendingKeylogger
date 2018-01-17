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
        Me.components = New System.ComponentModel.Container()
        Me.logs = New System.Windows.Forms.TextBox()
        Me.emailTimer = New System.Windows.Forms.Timer(Me.components)
        Me.keyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'logs
        '
        Me.logs.Location = New System.Drawing.Point(12, 12)
        Me.logs.Multiline = True
        Me.logs.Name = "logs"
        Me.logs.Size = New System.Drawing.Size(260, 237)
        Me.logs.TabIndex = 0
        '
        'emailTimer
        '
        Me.emailTimer.Enabled = True
        Me.emailTimer.Interval = 60000
        '
        'keyTimer
        '
        Me.keyTimer.Enabled = True
        Me.keyTimer.Interval = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.logs)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logs As TextBox
    Friend WithEvents emailTimer As Timer
    Friend WithEvents keyTimer As Timer
End Class

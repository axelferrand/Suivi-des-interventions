<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
   Inherits System.Windows.Forms.Form

   'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

   'Requise par le Concepteur Windows Form
   Private components As System.ComponentModel.IContainer

   'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
   'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
   'Ne la modifiez pas à l'aide de l'éditeur de code.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.bt_End = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'bt_End
      '
      Me.bt_End.Location = New System.Drawing.Point(308, 326)
      Me.bt_End.Name = "bt_End"
      Me.bt_End.Size = New System.Drawing.Size(239, 23)
      Me.bt_End.TabIndex = 0
      Me.bt_End.Text = "Quitter"
      Me.bt_End.UseVisualStyleBackColor = True
      '
      'frmPrincipal
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(914, 361)
      Me.Controls.Add(Me.bt_End)
      Me.Name = "frmPrincipal"
      Me.Text = "Form1"
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents bt_End As Button
End Class

Imports MyTool = Suivis_des_Interventions.ThisProject.Globals.Utilities.Tools





Public Class frmPrincipal

   ''' <summary>
   ''' <para>Effectue les derniers process avant la fin du programme</para>
   ''' 
   ''' <note type = "calledby">
   ''' <p>Utilisé dans : </p>
   ''' <ul style="list-style-type:square;">
   ''' <li><para>this.<see cref="bt_End_Click" autoUpgrade="true"><b><c>bt_End_Click(...)</c></b></see></para></li>
   ''' 
   ''' <note type="calling">
   ''' <ul style="list-style-type:disc;">
   ''' <li><para>Appel à la fonction this.<see cref="Dispose()" autoUpgrade="true"><b><c>Dispose()</c></b></see> de la classe de base</para></li>
   ''' <li><para>Puis fermeture de la feuille : this.<see cref="Close()" autoUpgrade="true"><b><c>Close()</c></b></see> de la classe de base</para></li>
   ''' <li><para>Et enfin, termine le process en mémoire : ThisProject.Globals.Utilities.Tools.Application.<see cref="ThisProject.Globals.Utilities.Tools.Application.EndProcess()" autoUpgrade="true"><b><c>EndProcess()</c></b></see> de la classe de base</para></li>
   ''' </ul>
   ''' </note> 
   '''  
   ''' </ul>
   ''' </note>
   '''   
   ''' </summary>
   Private Sub BeforeTerminate()

      Me.Dispose()
      Me.Close()

      MyTool.Application.EndProcess()
   End Sub

   Private Sub bt_End_Click(sender As Object, e As EventArgs) Handles bt_End.Click, Me.FormClosing

   End Sub
End Class

Imports System.IO
Imports Internal = Suivis_des_Interventions.ThisProject.Globals


Namespace ThisProject.Globals.Enum


   Public Enum RichTextBoxMessageMode
      NotAttrib = 0
      ErrorMode = 1
      WarningMode = 2
      OperatingMode = 3
      ResultingMode = 4
   End Enum






End Namespace



Namespace ThisProject.Globals.Utilities


   Public Class Tools

      ''' <summary>
      ''' <para>Recense toutes les procédures globalisées à l'application</para>
      ''' </summary>
      Public Class Application

         ''' <summary>
         ''' <para>Décharge totalement le process en mémoire</para>
         ''' 
         ''' <note type = "calledby">
         ''' <ul style="list-style-type:square;">
         ''' <li><para>frmPrincipal.<see cref="frmPrincipal.BeforeTerminate" autoUpgrade="true"><b><c>BeforeTerminate</c></b></see></para></li>
         ''' </ul>
         ''' 
         ''' <note type="calling">
         ''' <ul style="list-style-type:disc;">
         ''' <li><para>Liste tous les process chargés en mémoire : Process.<see cref="Process.GetProcesses()" autoUpgrade="true"><b><c>GetProcesses()</c></b></see> de la classe de base</para></li>
         ''' <li><para>Recherche dedans celui dont le nom contient la chaine de caractères <b>GoogleDrive</b></para></li>
         ''' <li><para>Si celui-ci a été trouvé, le termine par Process.<see cref="Process.Kill" autoUpgrade="true"><b><c>Kill()</c></b></see></para></li>
         ''' </ul>
         ''' </note> 
         '''   
         ''' </note>
         ''' </summary> 
         Public Shared Sub EndProcess()

            Try
               Dim myProcess As Process
               Dim All As List(Of Process) = Process.GetProcesses().ToList()
               Dim name As String = IIf(Not All.Any(Function(o) o.ProcessName.Contains("Memento Accès")), Nothing, All.Where(Function(o) o.ProcessName.Contains("Memento Accès")).First().ProcessName)


               If String.IsNullOrEmpty(name) Or String.IsNullOrEmpty(name) Then Return
               'Sinon...
               myProcess = Process.GetProcessesByName(name).First()

               If Not myProcess.HasExited Then
                  myProcess.Kill()
               End If
            Catch ex As Exception

            End Try

         End Sub

      End Class




      Public Class Display
         ''' <summary>
         ''' <para>Variable de type <b><i>RichTextBox</i></b></para>
         ''' 
         ''' <note type = "calledby" >
         ''' <ul style="list-style-type:square;">
         ''' <li><para>this.<see cref="RTB" autoUpgrade="true"><b><c>RTB</c></b></see></para></li>
         ''' </ul>
         ''' </note>
         '''  
         ''' </summary>
         Private Shared _RTB As RichTextBox


         Public Shared Property RTB As RichTextBox
            Get
               Return _RTB
            End Get

            Set(ByVal value As RichTextBox)
               _RTB = value
            End Set
         End Property


         Public Shared Sub Msg(Msg As String, ModeShowing As Internal.Enum.RichTextBoxMessageMode, IsPresentationText As Boolean)

            _RTB.SelectedText = String.Empty

            Dim _FontStyle As FontStyle = IIf(IsPresentationText, FontStyle.Bold, FontStyle.Regular)
            _RTB.SelectionFont = New Font(_RTB.SelectionFont, _FontStyle)

            Select Case ModeShowing  '_type
               Case Internal.Enum.RichTextBoxMessageMode.NotAttrib
                  _RTB.SelectionColor = Color.Black
               Case Internal.Enum.RichTextBoxMessageMode.ErrorMode
                  _RTB.SelectionColor = Color.Red
               Case Internal.Enum.RichTextBoxMessageMode.WarningMode
                  _RTB.SelectionColor = Color.OrangeRed
               Case Internal.Enum.RichTextBoxMessageMode.OperatingMode
                  _RTB.SelectionColor = Color.DarkBlue
               Case Internal.Enum.RichTextBoxMessageMode.ResultingMode
                  _RTB.SelectionColor = Color.DarkGreen
            End Select

            _RTB.AppendText(Msg + vbCrLf)
            _RTB.ScrollToCaret()

         End Sub

         Public Shared Sub Msg(MsgTitle As String, MsgSecond As String, ModeShowingFirst As Internal.Enum.RichTextBoxMessageMode, ModeShowingSecond As Internal.Enum.RichTextBoxMessageMode)

            _RTB.SelectedText = String.Empty

            Dim _FontStyle As FontStyle = FontStyle.Bold
            _RTB.SelectionFont = New Font(_RTB.SelectionFont, _FontStyle)
            Msg(MsgTitle, ModeShowingFirst, True)

            _FontStyle = FontStyle.Regular
            _RTB.SelectionFont = New Font(_RTB.SelectionFont, _FontStyle)
            Msg(MsgSecond & vbCrLf, ModeShowingSecond, False)

         End Sub

         Public Shared Sub Msg(MsgTitle As String, MsgSecond As String, ModeShowingBoth As Internal.Enum.RichTextBoxMessageMode)

            _RTB.SelectedText = String.Empty

            Dim _FontStyle As FontStyle = FontStyle.Bold
            _RTB.SelectionFont = New Font(_RTB.SelectionFont, _FontStyle)
            MsgBox(MsgTitle, ModeShowingBoth, True)

            _FontStyle = FontStyle.Regular
            _RTB.SelectionFont = New Font(_RTB.SelectionFont, _FontStyle)
            Msg(MsgSecond & vbCrLf, ModeShowingBoth, False)

         End Sub

         Public Shared Sub Msg(MsgTitle As String, ModeShowingFirst As Internal.Enum.RichTextBoxMessageMode)

            _RTB.SelectedText = String.Empty

            Dim _FontStyle As FontStyle = FontStyle.Bold
            _RTB.SelectionFont = New Font(_RTB.SelectionFont, _FontStyle)
            Msg(MsgTitle & vbCrLf, ModeShowingFirst, True)

         End Sub



      End Class



   End Class







End Namespace

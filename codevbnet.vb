'
' @ ANNEE    : 2018 / 2019
' @ ECOLE    : ESIAC
' @ FILIERE  : GENIE INFORMATIQUE
' @ OPTION   : GENIE LOGICIEL
' @ MATIERE  : MINI PROJETS AVEC VB.NET
' @ FICHE 01 : TP01 - EXERCICE 03
' @ AUTEUR   : NGAI NYEMB Alain Fils
' @ EMAIl    : alainfngai@gmail.com
' @ Linkedin : https://www.linkedin.com/in/alain-fils-ngai-nyemb-84982714a/
'
' Fonction pour calculer la somme de 2 nombres
 Function somme(ByVal val1 As Double, ByVal val2 As Double)
	Return (val1 + val2)
End Function
'
' Fonction pour calculer la soustraction de 2 nombres
Function soustraire(ByVal val1 As Double, ByVal val2 As Double)
	Return (val1 - val2)
End Function
'
' Fonction pour calculer le produit de 2 nombres
Function multiplier(ByVal val1 As Double, ByVal val2 As Double)
	Return (val1 * val2)
End Function
'
' Fonction pour calculer la division de 2 nombres
Function diviser(ByVal val1 As Double, ByVal val2 As Double)
	If (val2 <> 0) Then
		Return (val1 / val2)
	Else
		Return 0
	End If
End Function
'
' Fonction pour tester le contenu des "TextBox" uniquement valeurs numériques
Function TesterValPositives() As Boolean
	' Tester si les champs sont vides
	If ((txtNombre1.Text = "") Or (txtNombre2.Text = "")) Then
		MsgBox("Merci saisir valeurs des nombres svp!!!",, "Vides")
		Return False
		Exit Function
	ElseIf (Not IsNumeric(txtNombre1.Text) Or Not IsNumeric(txtNombre2.Text)) Then
		MsgBox("Merci saisir valeurs numériques svp!!! ",, "Numériques")
		Return False
		Exit Function
	Else
		Return True
	End If
End Function 
'
'
' Bouton "+" ou "Addition"
 Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If (TesterValPositives() = True) Then
            Me.txtResultat.Text = somme(Me.txtNombre1.Text, Me.txtNombre2.Text)
        End If
End Sub
'
' Bouton "-" ou "Soustraction"
Private Sub btnMoins_Click(sender As Object, e As EventArgs) Handles btnMoins.Click
	If (TesterValPositives() = True) Then
		Me.txtResultat.Text = soustraire(Me.txtNombre1.Text, Me.txtNombre2.Text)
	End If
End Sub
'
' Bouton "*" ou "Multiplication"
Private Sub btnFois_Click(sender As Object, e As EventArgs) Handles btnFois.Click
	If (TesterValPositives() = True) Then
		Me.txtResultat.Text = multiplier(Me.txtNombre1.Text, Me.txtNombre2.Text)
	End If
End Sub
'
' Bouton "/" ou "Division"
Private Sub btnDivise_Click(sender As Object, e As EventArgs) Handles btnDivise.Click
	If (TesterValPositives() = True) Then
		Me.txtResultat.Text = diviser(Me.txtNombre1.Text, Me.txtNombre2.Text)
	End If
End Sub
'
' Bouton "Quitter"
Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
	If MsgBox("Voulez-vous quitter ?", vbInformation + vbYesNo, "Quitter") = vbYes Then
		Me.Close()
	End If
End Sub
'
' Bouton nouveau
Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
	Me.txtNombre1.Text = ""
	Me.txtNombre2.Text = ""
	Me.txtResultat.Text = ""
End Sub
'
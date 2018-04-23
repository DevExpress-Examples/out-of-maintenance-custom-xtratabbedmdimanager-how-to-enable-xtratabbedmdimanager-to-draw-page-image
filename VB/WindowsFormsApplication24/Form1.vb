Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication24
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To 3
				Dim xtraForm As New XtraForm()
				xtraForm.Text = "Doc " & (i + 1)
				xtraForm.MdiParent = Me
				xtraForm.Show()
			Next i
		End Sub
	End Class
End Namespace
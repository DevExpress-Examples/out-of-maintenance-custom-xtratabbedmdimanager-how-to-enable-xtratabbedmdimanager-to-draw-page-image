Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraTabbedMdi

Namespace WindowsFormsApplication24
	Public Class MyXtraTabbedMdiManager
		Inherits XtraTabbedMdiManager
		Private useDefaultImageSize As Boolean
        Private _pageImageSize As Size

        Public Sub New(ByVal container As IContainer)
            Me.New()
            container.Add(Me)
        End Sub
        Public Sub New()
            useDefaultImageSize = True
            _pageImageSize = New Size(16, 16)
        End Sub

        Protected Overrides Function CreateNewPage(ByVal child As Form) As XtraMdiTabPage
            Dim createdPage As XtraMdiTabPage = MyBase.CreateNewPage(child)
            If (Not useDefaultImageSize) AndAlso createdPage.Image IsNot Nothing Then
                If PageImageSize.IsEmpty OrElse createdPage.Image.Size = PageImageSize Then
                    Return createdPage
                End If

                Dim scaledImage As New Bitmap(PageImageSize.Width, PageImageSize.Height)
                scaledImage.SetResolution(createdPage.Image.HorizontalResolution, createdPage.Image.VerticalResolution)
                Using gr As Graphics = Graphics.FromImage(scaledImage)
                    gr.Clear(Color.Transparent)
                    Dim dstRect As New Rectangle(0, 0, PageImageSize.Width, _pageImageSize.Height)
                    Dim srcRect As New Rectangle(0, 0, createdPage.Image.Width, createdPage.Image.Height)
                    gr.DrawImage(createdPage.Image, dstRect, srcRect, GraphicsUnit.Pixel)
                End Using

                createdPage.Image = scaledImage
            End If

            Return createdPage
        End Function

        <DefaultValue(GetType(Size), "16,16")> _
        Public Property PageImageSize() As Size
            Get
                Return _pageImageSize
            End Get
            Set(ByVal value As Size)
                If _pageImageSize = value Then
                    Return
                End If

                _pageImageSize = value
            End Set
        End Property

		<DefaultValue(True)> _
		Public Property UseDefaultPageImageSize() As Boolean
			Get
				Return useDefaultImageSize
			End Get
			Set(ByVal value As Boolean)
				If useDefaultImageSize = value Then
					Return
				End If

                useDefaultImageSize = value
			End Set
		End Property
	End Class
End Namespace

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;

namespace WindowsFormsApplication24
{
	public class MyXtraTabbedMdiManager : XtraTabbedMdiManager
	{
		private bool useDefaultImageSize;
		private Size pageImageSize;

		public MyXtraTabbedMdiManager(IContainer container)
			: this()
		{
			container.Add(this);
		}
		public MyXtraTabbedMdiManager()
		{
			useDefaultImageSize = true;
			pageImageSize = new Size(16, 16);
		}

		protected override XtraMdiTabPage CreateNewPage(Form child)
		{
			XtraMdiTabPage createdPage = base.CreateNewPage(child);
			if ( !useDefaultImageSize && createdPage.Image != null )
			{
				if ( PageImageSize.IsEmpty || createdPage.Image.Size == PageImageSize )
					return createdPage;

				Bitmap scaledImage = new Bitmap(PageImageSize.Width, PageImageSize.Height);
				scaledImage.SetResolution(createdPage.Image.HorizontalResolution, createdPage.Image.VerticalResolution);
				using ( Graphics gr = Graphics.FromImage(scaledImage) )
				{
					gr.Clear(Color.Transparent);
					Rectangle dstRect = new Rectangle(0, 0, PageImageSize.Width, pageImageSize.Height);
					Rectangle srcRect = new Rectangle(0, 0, createdPage.Image.Width, createdPage.Image.Height);
					gr.DrawImage(createdPage.Image, dstRect, srcRect, GraphicsUnit.Pixel);
				}

				createdPage.Image = scaledImage;
			}

			return createdPage;
		}

		[DefaultValue(typeof(Size), "16,16")]
		public Size PageImageSize
		{
			get { return pageImageSize; }
			set
			{
				if ( pageImageSize == value )
					return;

				pageImageSize = value;
			}
		}

		[DefaultValue(true)]
		public bool UseDefaultPageImageSize
		{
			get { return useDefaultImageSize; }
			set
			{
				if ( useDefaultImageSize == value )
					return;
				
				useDefaultImageSize = value;
			}
		}
	}
}

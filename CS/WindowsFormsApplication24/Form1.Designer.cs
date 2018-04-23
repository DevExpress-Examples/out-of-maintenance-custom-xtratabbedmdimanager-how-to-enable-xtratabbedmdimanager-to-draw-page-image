namespace WindowsFormsApplication24
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.myXtraTabbedMdiManager1 = new WindowsFormsApplication24.MyXtraTabbedMdiManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.myXtraTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// myXtraTabbedMdiManager1
			// 
			this.myXtraTabbedMdiManager1.MdiParent = this;
			this.myXtraTabbedMdiManager1.UseDefaultPageImageSize = false;
			this.myXtraTabbedMdiManager1.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.True;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 262);
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.myXtraTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MyXtraTabbedMdiManager myXtraTabbedMdiManager1;


	}
}


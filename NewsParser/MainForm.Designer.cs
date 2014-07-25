
namespace NewsParser
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.newsAddress = new System.Windows.Forms.TextBox();
			this.fetchNews = new System.Windows.Forms.Button();
			this.articleBrowser = new System.Windows.Forms.WebBrowser();
			this.parseNews = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textTitle = new System.Windows.Forms.TextBox();
			this.textArticle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textInternalSource = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textAuthor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textPublished = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.textSource = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// newsAddress
			// 
			this.newsAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.newsAddress.Location = new System.Drawing.Point(12, 12);
			this.newsAddress.Name = "newsAddress";
			this.newsAddress.Size = new System.Drawing.Size(466, 20);
			this.newsAddress.TabIndex = 0;
			this.newsAddress.Text = "http://www.theregister.co.uk/2013/05/08/youtube_trends_map/";
			this.newsAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
			// 
			// fetchNews
			// 
			this.fetchNews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fetchNews.Location = new System.Drawing.Point(484, 9);
			this.fetchNews.Name = "fetchNews";
			this.fetchNews.Size = new System.Drawing.Size(75, 23);
			this.fetchNews.TabIndex = 1;
			this.fetchNews.Text = "Fetch";
			this.fetchNews.UseVisualStyleBackColor = true;
			this.fetchNews.Click += new System.EventHandler(this.FetchNewsClick);
			// 
			// articleBrowser
			// 
			this.articleBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.articleBrowser.Location = new System.Drawing.Point(12, 38);
			this.articleBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.articleBrowser.Name = "articleBrowser";
			this.articleBrowser.Size = new System.Drawing.Size(628, 612);
			this.articleBrowser.TabIndex = 2;
			this.articleBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.enableParse);
			// 
			// parseNews
			// 
			this.parseNews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.parseNews.Enabled = false;
			this.parseNews.Location = new System.Drawing.Point(565, 10);
			this.parseNews.Name = "parseNews";
			this.parseNews.Size = new System.Drawing.Size(75, 23);
			this.parseNews.TabIndex = 3;
			this.parseNews.Text = "Parse";
			this.parseNews.UseVisualStyleBackColor = true;
			this.parseNews.Click += new System.EventHandler(this.ParseNewsClick);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(646, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Title";
			// 
			// textTitle
			// 
			this.textTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textTitle.Location = new System.Drawing.Point(732, 9);
			this.textTitle.Name = "textTitle";
			this.textTitle.Size = new System.Drawing.Size(240, 20);
			this.textTitle.TabIndex = 5;
			// 
			// textArticle
			// 
			this.textArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textArticle.Location = new System.Drawing.Point(732, 38);
			this.textArticle.MaxLength = 32767000;
			this.textArticle.Multiline = true;
			this.textArticle.Name = "textArticle";
			this.textArticle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textArticle.Size = new System.Drawing.Size(240, 479);
			this.textArticle.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(646, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 40);
			this.label2.TabIndex = 6;
			this.label2.Text = "Text";
			// 
			// textInternalSource
			// 
			this.textInternalSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textInternalSource.Location = new System.Drawing.Point(732, 549);
			this.textInternalSource.Name = "textInternalSource";
			this.textInternalSource.Size = new System.Drawing.Size(240, 20);
			this.textInternalSource.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(646, 549);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Internal Source";
			// 
			// textAuthor
			// 
			this.textAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textAuthor.Location = new System.Drawing.Point(732, 575);
			this.textAuthor.Name = "textAuthor";
			this.textAuthor.Size = new System.Drawing.Size(240, 20);
			this.textAuthor.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(646, 575);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Author";
			// 
			// textPublished
			// 
			this.textPublished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textPublished.Location = new System.Drawing.Point(732, 601);
			this.textPublished.Name = "textPublished";
			this.textPublished.Size = new System.Drawing.Size(240, 20);
			this.textPublished.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(646, 601);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Published";
			// 
			// btnCopy
			// 
			this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopy.Enabled = false;
			this.btnCopy.Location = new System.Drawing.Point(732, 627);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 14;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.BtnCopyClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(897, 627);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 15;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// textSource
			// 
			this.textSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textSource.Location = new System.Drawing.Point(732, 523);
			this.textSource.Name = "textSource";
			this.textSource.Size = new System.Drawing.Size(240, 20);
			this.textSource.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(646, 523);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Source";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 662);
			this.Controls.Add(this.textSource);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.textPublished);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textAuthor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textInternalSource);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textArticle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.parseNews);
			this.Controls.Add(this.articleBrowser);
			this.Controls.Add(this.fetchNews);
			this.Controls.Add(this.newsAddress);
			this.Name = "MainForm";
			this.Text = "NewsParser";
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Label label5;
		protected System.Windows.Forms.TextBox textPublished;
		private System.Windows.Forms.Label label4;
		protected System.Windows.Forms.TextBox textAuthor;
		private System.Windows.Forms.Label label3;
		protected System.Windows.Forms.TextBox textInternalSource;
		private System.Windows.Forms.Label label2;
		protected System.Windows.Forms.TextBox textArticle;
		protected System.Windows.Forms.TextBox textTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button parseNews;
		private System.Windows.Forms.WebBrowser articleBrowser;
		private System.Windows.Forms.Button fetchNews;
		private System.Windows.Forms.TextBox newsAddress;
		protected System.Windows.Forms.TextBox textSource;
        private System.Windows.Forms.Label label6;
	}
}

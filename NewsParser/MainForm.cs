using System;
using System.Windows.Forms;

namespace NewsParser
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			articleBrowser.ScriptErrorsSuppressed = true;
		}

		/*
		  * Fetches the webpage for an article
		  * Disable the buttons Copy and Parse to hinder missclicks
		  * Empties the textboxes
		  * */
		void FetchNewsClick(object sender, EventArgs e)
		{
			btnCopy.Enabled  = false;
			parseNews.Enabled = false;
			if(!newsAddress.Text.Equals(""))
			{
				articleBrowser.Navigate(newsAddress.Text);
				Uri u = new Uri(newsAddress.Text);
				this.Text = u.Host;
			}
			textSource.Text = "";
			textArticle.Text = "";
			textTitle.Text = "";
			textInternalSource.Text = "";
			textAuthor.Text = "";
			textPublished.Text = "";
		}

		/*
		  * Parse the article.
		  * */
		void ParseNewsClick(object sender, EventArgs e)
		{
			Article art;

			if(newsAddress.Text.Contains("slashdot.com"))
			{
				Slashdot s = new Slashdot(articleBrowser.Document);
				art = s.slashdot();
				textArticle.Text = art.articleText;
				textAuthor.Text = art.articleAuthor;
				textPublished.Text = art.articlePublished;
				textSource.Text = art.articleSource;
				textTitle.Text = art.articleTitle;
				textInternalSource.Text = art.articleWikiInternalSource;
            }
			else if(newsAddress.Text.Contains("theregister.co.uk"))
			{
				TheRegister r = new TheRegister(articleBrowser.Document);
				art = r.theRegister();
				textArticle.Text = art.articleText;
				textAuthor.Text = art.articleAuthor;
				textPublished.Text = art.articlePublished;
				textSource.Text = art.articleSource;
				textTitle.Text = art.articleTitle;
				textInternalSource.Text = art.articleWikiInternalSource;
			}

			btnCopy.Enabled = true;
		}

		/*
		  * Closes the application.
		  * */
		void BtnCloseClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/*
		  * Selects all text in the adress-textbox.
		  * */
		void newsAddressMark(object sender, EventArgs e)
		{
			newsAddress.SelectAll();
		}
		
		/*
		  * Used to enable the button used to start the parsing of the article
		  * */
		void enableParse(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			parseNews.Enabled = true;
		}
		
		/*
		  * Copies the text in the textboxes to the Clipboard.
		  * */
		void BtnCopyClick(object sender, EventArgs e)
		{
			string text;
			
			text = "======" + textTitle.Text + "======" + "\n\n"
				+ textArticle.Text + "\n\n"
				+ textSource.Text + " ";
			if (textAuthor.Text == null)
			{
				text = text + textPublished.Text;
			} else {
				text = text + " av " + textAuthor.Text + " "
				+ textPublished.Text;
			}
			
			Clipboard.SetText(text);
		}

		/*
		  * Catches if the Enter-key have been pressed; if so, fetches the article.
		  * Same as pressing the 'Fetch-key'.
		  * */
        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FetchNewsClick(null, null);
            }
        }
	}
}

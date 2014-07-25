using System;
using System.Windows.Forms;

namespace NewsParser
{
	public class TheRegister : MainForm
	{
		HtmlDocument articleDocument;
		HtmlElement articleElement;
		HtmlElementCollection articleElementParts;
		HtmlElementCollection articleElementCollection;
		Article article;

		public TheRegister(HtmlDocument a)
		{
			articleDocument = a;
		}

		public Article theRegister()
		{
			article = new Article();

			setArticle();
			setAuthor();
			setPublished();
			setSource();
			setTitle();
			setInternalSource();
			getImages();

			return article;
		}

		void setSource()
		{
			int i = articleDocument.Url.ToString().LastIndexOf("/");

			article.articleSource = "Source: [[" + articleDocument.Url.ToString().Substring(0,i+1) + "]] ";
		}

		void setArticle()
		{
			//articleElement = articleDocument.GetElementById("body");
			//articleElementParts = articleElement.Children;
			
			foreach (HtmlElement articleElementParts in articleDocument.GetElementById("body"))
			{
				/**
				 * TODO 
				 * write text
				 * remove first child with link
				 * remove first bold text if present
				 * cleanup text
				 * 		replace ‘ and ’ with '
				 * 		replace “ and ” with "
				 * 		replace ® if present
				 * 		replace $ with \$
				 * check for citation/twitter
				 * check for image
				 * check for pre (kod)
				 * check for <del>
				 * insert links
				 * 		replace [ and ] with ( ) if present in link text
				 * if : ? present in title
				 * 		remove, and create extended internal link
				 * 		replace ‘ and ’ with '
				 * 		replace “ and ” with "
				 * */
				
				String text = articleElement.InnerText;
				int[] x = new int[2];
	
	            HtmlElementCollection eLinks = articleElement.GetElementsByTagName("a");
				String[] linksHtml = new String[eLinks.Count],
					linksText = new String[eLinks.Count];

				
				/*
				  * Get all links, insert to array
				  * */
	            for(int a = 0; a < eLinks.Count; a++)
	            {
	            	linksHtml[a] = eLinks[a].OuterHtml;
	            	linksText[a] = eLinks[a].InnerText;
	            }
	
				//Clean up linkcode
	            for(int b = 0; b < linksHtml.Length; b++)
	            {
		            linksHtml[b] = linksHtml[b].Replace("target=\"_blank\"", "");
		            linksHtml[b] = linksHtml[b].Replace("target=_blank", "");
		            x[0] = linksHtml[b].IndexOf('\"')+1;
		            x[1] = linksHtml[b].LastIndexOf('\"');
		            linksHtml[b] = linksHtml[b].Substring(x[0],x[1]-x[0]);
	            }
	
	            /*
	              * Insert link-URLs in articletext to create wikilinks 
	              * */
	            for(int c = 0; c < linksText.Length; c++)
	            {
	            	if(linksText[c] != null)
	            	{
		           		text = text.Insert(text.IndexOf(linksText[c], 0),"[[" + linksHtml[c] + "|");
		           		text = text.Insert(text.IndexOf(linksText[c], 0)+linksText[c].Length,"]]");
	            	}
	            }
	
	            text = anchorHandling(text);
				text = textCleanup(text);
	
	           	//text = text.Replace(" ®", "");
	            article.articleText = text;
			}
		}

		String textCleanup(String text)
		{
			// Replace ‘ and ’ with '
			// Replace “ and ” with "
			return null;
		}

        /*
         * Remove any anchor configurations
        * */
		String anchorHandling(String text)
		{
            //Replace text formating
            text = text.Replace("<i>", "//"); text = text.Replace("</i>", "//");
            text = text.Replace("<I>", "//"); text = text.Replace("</I>", "//");
            text = text.Replace("<b>", "**"); text = text.Replace("</b>", "**");
            text = text.Replace("[", "("); text = text.Replace("]", ")");
            text = text.Replace("<strike>", "<del>"); text = text.Replace("</strike>", "</del>");

            return text;
		}

		/*
		  * Get the author of the article
		  * 
		  * Name is contained in link with href containing '/Author/'
		  * Loop through all links, find the correct link and extract OuterHtml (the link text)
		  * */
		void setAuthor()
		{
			articleElement=null;
			articleElementCollection = articleDocument.GetElementsByTagName("a");

			foreach(HtmlElement el in articleElementCollection)
			{
				if(el.OuterHtml.ToString().Contains("Author"))
				{
					article.articleAuthor = el.InnerHtml.ToString();
					break;
				} else {
					article.articleAuthor = null;
				}
			}
		}

		/*
		  * Get the title of the article
		  * 
		  * Copy the document title, exclude the trailing site name
		  * */
		void setTitle()
		{
			article.articleTitle = articleDocument.Title.Substring(0,(articleDocument.Title.Length+1)-16);
		}

		/*
		  * Get publicationdate of the article
		  * 
		  * Date is contained in article URL, split the string and fetch the numbers
		  * */
		void setPublished()
		{
			string date;
			string[] urlSplit;

			urlSplit = articleDocument.Url.ToString().Split('/');
			date = urlSplit[3] + "-" + urlSplit[4] + "-" + urlSplit[5];

			article.articlePublished = date;
		}

		/*
		  * Defining wiki-internalsource to the article
		  * 
		  * Ask the user of article category through InternalLinkCategory
		  * */
        void setInternalSource()
        {
            WikiInternalLinkCategory category = new WikiInternalLinkCategory();
            DialogResult res = category.ShowDialog();

            if (res == DialogResult.OK)
            {
            	string title = articleDocument.Title.ToString();

            	title = title.Replace(":","");
            	title = title.Replace("?","");
            	article.articleWikiInternalSource = category.getCategory() + ":" + article.articleTitle;
            }
        }

        void getImages()
        {
			articleElement = articleDocument.GetElementById("body");
			HtmlElement tempElement;
			articleElementCollection = articleElement.GetElementsByTagName("img");

            if(articleElementCollection.Count > 0)
			{
				ListImages imageList = new ListImages(articleElementCollection);
				DialogResult result = imageList.ShowDialog();

				articleElementCollection = articleElement.GetElementsByTagName("div");
				string[,] captions = new string[articleElementCollection.Count,2];	//0 = Caption 1 = Internaladdress

				for(int i = 0; i < articleElementCollection.Count;i++)
				{
					tempElement = articleElementCollection[i];
					string t = tempElement.OuterHtml.ToString();
					if(t.Contains("CaptionedImage"))
					{
						captions[i,0] = articleElementCollection[i].InnerText;
						//captions[i,1] = article.gsInternalSource + 
						MessageBox.Show(articleElementCollection[i].InnerText);
					}
				}
			}
        }
    }
}

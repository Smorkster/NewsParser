using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NewsParser
{
	public class Slashdot
	{
		private HtmlDocument document;
		private Article article;

		public Slashdot(HtmlDocument a)
		{
			document = a;
		}

		public Article slashdot()
		{
			article = new Article();

			setSource();
			setArticle();
			setAuthor();
			setTitle();
			setInternalSource();
			setPublished();
			
			return article;
		}
		void setSource()
		{
			int i = document.Url.ToString().LastIndexOf("/");

			article.articleSource = "Source: [[" + document.Url.ToString().Substring(0,i+1) + "]] ";
		}
		
		void setArticle()
		{
            HtmlElement he=null;
            HtmlElementCollection heC = document.GetElementsByTagName("div");
            
            for (int i = 0; i < heC.Count; i++)
            {
                he = heC[i];

                if(he.Id != null)
                    if (he.Id.Contains("fhbody"))
                        article.articleText =  he.InnerText;
            }

            article.articleText = "";
        }
		
		void setAuthor()
		{
			article.articleAuthor = "";
		}
		
		void setTitle()
		{
			article.articleTitle = document.Title.Substring(0,(document.Title.Length+1)-12);
		}
		
		void setPublished()
		{
			HtmlElement el=null;
			HtmlElementCollection elC = document.GetElementsByTagName("time");
			int hour, minute;
			string[] date;

			el = elC[0];
			hour = Convert.ToInt16(el.InnerText.Substring(el.InnerText.Length-7, 2));
			if(el.InnerText.Substring(el.InnerText.Length-2, 2).Equals("PM"))
				hour += 12;
			minute = Convert.ToInt16(el.InnerText.Substring(el.InnerText.Length-4, 2));
			
			date = document.Url.ToString().Split('/');

			article.articlePublished = "20" + date[4] + "-" + date[5] + "-" + date[6] + " " + hour + ":" + minute;
		}
        void setInternalSource()
        {
            string url = document.Url.ToString();
            WikiInternalLinkCategory a = new WikiInternalLinkCategory();
            DialogResult res = a.ShowDialog();
            if (res == DialogResult.OK)
                article.articleWikiInternalSource =  a.getCategory();
            else
                article.articleWikiInternalSource =  "Error";
        }
    }
}

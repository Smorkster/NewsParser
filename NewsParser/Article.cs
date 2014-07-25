using System;

namespace NewsParser
{
	public class Article
	{
		private string title, article, source, internalsource, published, author;

		public string articleTitle
		{
			get { return title; }
			set { title = value; }
		}
		
		public string articleText
		{
			get
			{
				return article;
			}
			set
			{
				article = value;
			}
		}
		
		public string articleSource
		{
			get
			{
				return source;
			}
			set
			{
				source = value;
			}
		}
		
		public string articleWikiInternalSource
		{
			get
			{
				return internalsource;
			}
			set
			{
				internalsource = value;
			}
		}
		
		public string articlePublished
		{
			get
			{
				return published;
			}
			set
			{
				published = value;
			}
		}
		
		public string articleAuthor
		{
			get
			{
				return author;
			}
			set
			{
				author = value;
			}
		}
	}
}

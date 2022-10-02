using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemsida
{
    public class WebsiteGenerator
    {
        protected string topHTML = "<!DOCTYPE>\n<html>\n<body>\n<main>\n";
        protected string endHTML = "\n</main>\n</body>\n</html>";
        protected string[] techniques, messageToClass;
        protected string className;

        public WebsiteGenerator(string className, string[] messageToClass, string[] techniques)
        {
            this.className = className;
            this.messageToClass = messageToClass;
            this.techniques = Courses(techniques);
        }

        virtual public void PrintWebsite()
        {
			Console.Clear();
			PrintHtmlTop();
            PrintWelcomeClass(className);
            PrintMessages(messageToClass);
            PrintCourses();
            PrintHtmlEnd();
        }

        virtual public void SaveWebsiteToFile()
        {
            FileInfo fi = new FileInfo(@"website.txt");
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(this.topHTML);
            sw.Write($"<h1>Välkomna {className}!</h1>");
			foreach (string message in messageToClass)
            {
                sw.Write(message);
            }
            foreach (string course in this.techniques)
            {
                sw.Write(course);
            }
            sw.Write(this.endHTML);
            sw.Close();
		}


		virtual protected void PrintHtmlTop()
        {
            Console.WriteLine(this.topHTML);
        }

        protected void PrintHtmlEnd()
        {
            Console.WriteLine(this.endHTML);
        }
        protected void PrintWelcomeClass(string className)
        {
			Console.WriteLine($"<h1>Välkomna {className}!</h1>");
        }
		
		protected string[] Courses(string[] techniques)
        {
            string[] temp = new string[techniques.Length];
            for (int i = 0; i < techniques.Length; i++)
            {
                temp[i] = "<p> " + techniques[i].Trim().ToUpper().Substring(0, 1) + techniques[i].Trim().Substring(1).ToLower() + " <p/>";
            }
            return temp;
        }

        protected void PrintCourses()
        {
            foreach (var course in this.techniques)
            {
                Console.WriteLine(course);
            }
        }

        protected void PrintMessages(string[] messageToClass)
        {
            foreach (string message in messageToClass)
            {
                Console.WriteLine($"<p> Meddelande: {message} </p>");
            }
        }
    }

    public class StyledWebsiteGenerator : WebsiteGenerator
    {
        protected new string topHTML = "<!DOCTYPE>\n<html>\n<head>";
		protected string midHTML = "</head>\n<body>\n<main>\n";
        protected new string endHTML = "\n</main>\n</body>\n</html>";
        string color;

        public StyledWebsiteGenerator(string className, string[] messageToClass, string[] techniques, string colour) 
                                    : base(className, messageToClass, techniques)
        {
            this.color = colour;
        }

        override public void PrintWebsite()
        {
            Console.Clear();
            PrintHtmlTop();
            PrintHtmlStyle();
            PrintHtmlMid();
            PrintWelcomeClass(className);
            PrintMessages(messageToClass);
            PrintCourses();
            PrintHtmlEnd();
        }
            
		override public void SaveWebsiteToFile()
		{
			FileInfo fi = new FileInfo(@"website.txt");
			FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
			StreamWriter sw = new StreamWriter(fs);
			sw.WriteLine(this.topHTML);
            sw.WriteLine($"<style>\np {{ color: {color}; }}\n</style>");
            sw.WriteLine(this.midHTML);
			sw.Write($"<h1>Välkomna {className}!</h1>");
			foreach (string message in messageToClass)
			{
				sw.WriteLine(message);
			}
			foreach (string course in this.techniques)
			{
				sw.WriteLine(course);
			}
			sw.WriteLine(this.endHTML);
			sw.Close();
		}

		override protected void PrintHtmlTop()
        {
            Console.WriteLine(this.topHTML);
        }
        private void PrintHtmlStyle()
        {
            string style = $"<style>\np {{ color: {color}; }}\n</style>";
			Console.WriteLine(style);
        }

        private void PrintHtmlMid()
        {
            Console.WriteLine(this.midHTML);
        }

    }
}

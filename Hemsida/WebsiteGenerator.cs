using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemsida
{
    abstract public class WebsiteGeneratorBlueprint
    {
		protected string topHTML = "<!DOCTYPE>\n<html>\n<body>\n<main>\n";
		protected string endHTML = "\n</main>\n</body>\n</html>";
		protected string[] techniques, messageToClass;
		protected string className;

		public abstract void PrintWebsite();
        protected abstract void PrintHtmlTop();
        protected abstract void PrintHtmlEnd();
        protected abstract void PrintWelcomeClass(string className);
        protected abstract string[] Courses(string[] techniques);
        protected abstract void PrintCourses();
        protected abstract void PrintMessages(string[] messageToClass);
	}

    public class WebsiteGenerator : WebsiteGeneratorBlueprint
	{
        public WebsiteGenerator(string className, string[] messageToClass, string[] techniques)
        {
            this.className = className;
            this.messageToClass = messageToClass;
            this.techniques = Courses(techniques);
        }

        override public void PrintWebsite()
        {
            PrintHtmlTop();
            PrintWelcomeClass(className);
            PrintMessages(messageToClass);
            PrintCourses();
            PrintHtmlEnd();
        }

        override protected void PrintHtmlTop()
        {
            Console.WriteLine(this.topHTML);
        }

		override protected void PrintHtmlEnd()
        {
            Console.WriteLine(this.endHTML);
        }
		override protected void PrintWelcomeClass(string className)
        {
            Console.WriteLine($"<h1>Välkomna {className}!</h1>");
        }

		override protected string[] Courses(string[] techniques)
        {
            string[] temp = new string[techniques.Length];
            for (int i = 0; i < techniques.Length; i++)
            {
                temp[i] = "<p> " + techniques[i].Trim().ToUpper().Substring(0, 1) + techniques[i].Trim().Substring(1).ToLower() + " <p/>";
            }
            return temp;
        }

		override protected void PrintCourses()
        {
            foreach (var course in this.techniques)
            {
                Console.WriteLine(course);
            }
        }

		override protected void PrintMessages(string[] messageToClass)
        {
            foreach (string message in messageToClass)
            {
                Console.WriteLine($"<p> Meddelande: {message} </p>");
            }
        }
    }

    public class StyledWebsiteGenerator : WebsiteGenerator
    {
        protected new string topHTML = "<!DOCTYPE>\n<html>";        
        protected string midHTML = "<body>\n<main>\n";
        protected new string endHTML = "\n</main>\n</body>\n</html>";
        string Colour;

        public StyledWebsiteGenerator(string className, string[] messageToClass, string[] techniques, string colour) 
                                    : base(className, messageToClass, techniques)
        {
            this.Colour = colour;
        }

        override public void PrintWebsite()
        {
            PrintHtmlTop();
            PrintHtmlStyle();
            PrintHtmlMid();
            PrintWelcomeClass(className);
            PrintMessages(messageToClass);
            PrintCourses();
            PrintHtmlEnd();
        }
        override protected void PrintHtmlTop()
        {
            Console.WriteLine(this.topHTML);
        }
        private void PrintHtmlStyle()
        {
            Console.WriteLine($"<head>\n<style>\np {{ color: {Colour}; }}\n</style>\n</head>");
        }

        private void PrintHtmlMid()
        {
            Console.WriteLine(this.midHTML);
        }

    }
}

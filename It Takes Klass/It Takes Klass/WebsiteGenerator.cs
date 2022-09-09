using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_Takes_Klass
{
    internal class WebsiteGenerator
    {
        public string HTMLtop = "<!DOCTYPE>\n<html>\n<body>\n<main>";
        public string HTMLbottom = "</main>\n</body>\n</html>";
        public string[] techniques = {" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code "};

        public void HTMLbuilder(string className, List<string> classMessages)
        {
            Console.Clear();
            Console.WriteLine(HTMLtop);
            WelcomeClass(className);
            foreach(string message in classMessages)
            {
                Console.WriteLine(message);
            }
            Courses(techniques);
            Console.WriteLine(HTMLbottom);
        }

        public void WelcomeClass(string className)
        {
            Console.WriteLine($"<h1>Välkomna {className}!</h1>");
        }

        public void Courses(string[] techniques)
        {
            Console.WriteLine("<p>Ni kommer att läsa följande kurser:</p>");                                    
            foreach (string s in techniques)
            {
                string k;
                k = s.Trim().ToLower();
                k = k.First().ToString().ToUpper() + k.Substring(1);
                Console.WriteLine($"<p>Kurs om {k}</p>");
            }
        }
        public List<string> Messages(int classMessages)
        {
            Console.Clear();
            List<string> messages = new List<string>();
            for (int i = 0; i < classMessages; i++)
            {
                Console.WriteLine($"Meddelande {i + 1}: ");
                string j = Console.ReadLine();
                messages.Add($"<p>{j}</p>");
            }
            return messages;
        }

        //public void HTMLtop()
        //{
        //    Console.WriteLine("<!DOCTYPE>\n<html>\n<body>\n<main>");
        //}

        //public void HTMLbottom()
        //{
        //    Console.WriteLine("</main>\n</body>\n</html>");
        //}
    }
}

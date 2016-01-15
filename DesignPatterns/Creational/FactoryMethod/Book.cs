namespace DesignPatterns.Creational.FactoryMethod
{
    public class Book
    {
        protected Book()
        {
        }

        public string Author { get; protected set; }
        public string Title { get; set; }
        public string Subject { get; protected set; }
    }

    public class PhpBook : Book
    {
        protected PhpBook()
        {
            Subject = "PHP";
        }
    }

    public class OReillyPhpBook : PhpBook
    {
        private static int _counter;

        public OReillyPhpBook()
        {
            if (_counter++%2 == 0)
            {
                Author = "Rasmus Lerdorf and Kevin Tatroe";
                Title = "Programming PHP";
            }
            else
            {
                Author = "David Sklar and Adam Trachtenberg";
                Title = "PHP Cookbook";
            }
        }
    }

    public class SamsPhpBook : PhpBook
    {
        private static int _counter;

        public SamsPhpBook()
        {
            if (_counter++%2 == 0)
            {
                Author = "George Schlossnagle";
                Title = "Advanced PHP Programming";
            }
            else
            {
                Author = "Christian Wenz";
                Title = "PHP Phrasebook";
            }
        }
    }

    public class VisualQuickstartPhpBook : PhpBook
    {
        public VisualQuickstartPhpBook()
        {
            Author = "Larry Ullman";
            Title = "PHP for the World Wide Web";
        }
    }
}
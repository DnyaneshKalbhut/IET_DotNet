namespace _09Notepad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpellCheckerFactory factory = new SpellCheckerFactory();
            ISpellChecker someChecker = factory.GetSomeSpellChecker("gr");
            Notepad notepad = new Notepad(someChecker);
            notepad.SpellCheck();
        
        }
    }

    public class Notepad {

        ISpellChecker _checker;
        SpellCheckerFactory factory = new SpellCheckerFactory();
        public Notepad(ISpellChecker checker)
        {
            if (checker == null)
            {
                _checker = factory.GetSomeSpellChecker("en");
            }
            else {
                _checker = checker;
            }
        }
        public void SpellCheck()
        {
            _checker.DoSpellCheck();
        }
        public void Cut()
        {
        }
        public void Copy()
        {
        }
        public void Paste()
        {
        }

    }

    public interface ISpellChecker
    {
        void DoSpellCheck();
    }

    public class EnglishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        { 
            Console.WriteLine("English Spell Check Done");
        }
    }
    public class GermanSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        { 
            Console.WriteLine("German Spell Check Done");
        }
    }

    public class SpanishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("SpanishSpell Check Done");
        }
    }

    public class SpellCheckerFactory
    {
        public ISpellChecker GetSomeSpellChecker(string lang)
        {
            ISpellChecker _checker = null;
            switch (lang)
            {
                case "en":
                    _checker = new EnglishSpellChecker();
                    break;
                case "gr":
                    _checker = new GermanSpellChecker();
                    break;
                case "sp":
                    _checker = new SpanishSpellChecker();
                    break;
                default:
                    _checker = new EnglishSpellChecker();
                    break;
            }
            return _checker;
        }
    }
}

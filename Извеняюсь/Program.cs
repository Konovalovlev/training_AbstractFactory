using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_
{

    abstract public class Apptication
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }

        class WinFactory : GUIFactory
        {
            public Button CreateButton()
            {
                Console.WriteLine("Создалась win кнопка");
                return new WinButton();
            }
            public Checkbox CreateCheckbox()
            {
                Console.WriteLine("Закрылась win кнопка");
                return new WinCheckbox();
            }
        }
        class MacFactory : GUIFactory
        {
            public Button CreateButton()
            {
                Console.WriteLine("Создалась mac кнопка");
                return new MacButton();
            }
            public Checkbox CreateCheckbox()
            {
                Console.WriteLine("Закрылась mac кнопка");
                return new MacCheckbox();
            }
        }
        public interface GUIFactory
        {
            Button CreateButton();
            Checkbox CreateCheckbox();
        }
        public class Button
        {
        }
        public class Checkbox
        {
        }
        public class WinCheckbox : Checkbox
        {
        }
        public class WinButton : Button
        {
        }
        public class MacButton : Button
        {
        }
        public class MacCheckbox : Checkbox
        {

        }
    }
    
}


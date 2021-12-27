using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque_de_estacionamento
{
    public class AllOtherMenus
    {
        //private static int userInput = int.Parse(Console.ReadLine());
        public static void MainMenu(int userInput) 
        {
            Console.WriteLine("MainMenu selected!");
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("MainMenu select 1");
                    break;
               case 2:
                    Console.WriteLine("MainMenu select 2");
                    break;
               default:
                    CloseApp(true);
                    break;
            }
        }

        public static void ClientMenu()
        {
            Console.WriteLine("ClientMenu selected!");
        }

        public static void AdminMenu() 
        {
            Console.WriteLine("AdminMenu selected!");
        }
        
        public static void OptionsMenu () 
        {
            Console.WriteLine("OptionsMenu selected!");
        }
        public static bool CloseApp(bool setMenuOff)
        {
            return false;
        }
    }


}

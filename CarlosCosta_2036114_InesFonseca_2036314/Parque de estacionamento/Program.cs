// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8; //para tornar o simbolo do euro em € ref:https://www.codeproject.com/Questions/455766/Euro-symbol-does-not-show-up-in-Console-WriteLine
System.Console.Out.WriteLine("œil");

Console.Title = "A Car Slot! -  Parking agency"; //Console Tittle
Console.ForegroundColor = ConsoleColor.Yellow; //Console Ink Color
//Console.BackgroundColor = ConsoleColor.DarkCyan; //Console Write Color

//================ Main Menu User Interface ================//
bool activeMenu = true; //Bool to Mantain the menu always active
while (activeMenu)
{
    Console.WriteLine("Welcome to CarSlot Parking Agency!");
    Console.WriteLine(DateTime.Now); //Display date and time
    Console.WriteLine("Navigate through the Menus by presseing the representative number!");
    Console.WriteLine("Client Menu [1]");
    Console.WriteLine("Admin Menu [2]");
    Console.WriteLine("Options [3]");
    Console.WriteLine("Leave Application [4]");

    int userSelection = int.Parse(Console.ReadLine()); //user input to navigate through the Main Menu

    switch (userSelection) //Ref: https://stackoverflow.com/questions/43484523/switch-statements-for-a-menu-c
    {
        case 0:
            //call Main Menu
            MainMenu(userSelection);

            break;
        case 1:
            //Call client Menu
            ClientMenu();
            break;
        case 2:
            //Call Admin Menu
            AdminMenu();
            break;
        case 3:
            //Call Option Menu
            OptionsMenu();
            break;
        case 4:
            activeMenu = CloseApp(activeMenu); //Closing Application
            break;
        default:
            //Unnexpected action from the user. What should it happen in this case? // shows the main menu whatever happends
            break;
    }
    break;


    static void MainMenu(int userInput)  //why?
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


    static void ClientMenu() //client menu has to have, date, schedual, (3)zones, back to main menu and
    {
        Console.WriteLine("ClientMenu selected!");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("     >Schedule<    ");
        Console.WriteLine("----working days----");
        Console.WriteLine(" 9:00 am - 8:00 pm ");
        Console.WriteLine("-----saturdays------");
        Console.WriteLine(" 9:00 am - 2:00 pm ");
        Console.WriteLine(">Choose a zone number<");
        Console.WriteLine("_zone 1");
        Console.WriteLine("_zone 2");
        Console.WriteLine("_zone 3");


        int zone = int.Parse(Console.ReadLine());
        int backMainMenu = int.Parse(Console.ReadLine());

        if (zone == 1) {
            Console.WriteLine("Zone 1 selected");
            Console.WriteLine("---Price/max.Hour---");
            Console.WriteLine("1.15€/h - max.45 min");


        }

        if (zone == 2)
        {
            Console.WriteLine("Zone 2 selected");
            Console.WriteLine("---Price/max.Hour---");
            Console.WriteLine("1€/h - max.2 hours");

        }

        if (zone == 3)
        {
            Console.WriteLine("Zone 3 selected");
            Console.WriteLine("---Price/max.Hour---");
            Console.WriteLine("0.62€/h - no max.hours");


        }
        
    }

    static void AdminMenu()
    {
        Console.WriteLine("AdminMenu selected!");
    }

    static bool CloseApp(bool setMenuOff)
    {
        return false;
    }
}
public class Zones () {

        int CarPlate = int.Parse(Console.ReadLine()); // allow client to insert Car plate


        Console.WriteLine("Please insert your car plate: "); // to ask for a car plate
        // colocar aqui um array para memorizar a placa? ou apenas usa-la para o ticket


        Console.WriteLine("Insert the coins until you achive the time you need: ");
        //aqui colocar a formula de contar moedas e juntá-las ao tempo delimitar que moedas podem entrar


        Console.WriteLine("Back to main menu [0]"); //to come back to main menu
        int backMainMenu = int.Parse(Console.ReadLine());

        
        
    }



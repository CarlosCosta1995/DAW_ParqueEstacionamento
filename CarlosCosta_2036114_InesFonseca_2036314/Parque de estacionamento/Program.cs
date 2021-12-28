// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8; //para tornar o simbolo do euro em € ref:https://www.codeproject.com/Questions/455766/Euro-symbol-does-not-show-up-in-Console-WriteLine
System.Console.Out.WriteLine();

Console.Title = "A Car Slot! -  Parking agency"; //Console Tittle
Console.ForegroundColor = ConsoleColor.Yellow; //Console Ink Color
//Console.BackgroundColor = ConsoleColor.DarkCyan; //Console Write Color

//================ Main Menu User Interface ================//



bool activeMenu = true; //Bool to Mantain the menu always active
while (activeMenu)

{

    Console.WriteLine("start [0]");



    int userSelection = int.Parse(Console.ReadLine()); //user input to navigate through the Main Menu

    switch (userSelection) //Ref: https://stackoverflow.com/questions/43484523/switch-statements-for-a-menu-c
    {
        case 0:
            //call Main Menu - go back buttons
            //MainMenu(0);
            Console.WriteLine("Welcome to CarSlot Parking Agency!");
            Console.WriteLine(DateTime.Now); //Display date and time
            Console.WriteLine("Navigate through the Menus by presseing the representative number!");
            Console.WriteLine("Client Menu [1]");
            Console.WriteLine("Admin Menu [2]");
            Console.WriteLine("Leave Application [5]"); //é mesmo necessário?

            break;
        case 1:
            //Call client Menu
            //ClientMenu();
            
            Console.WriteLine("ClientMenu selected!");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("     >Schedule<    ");
            Console.WriteLine("----working days----");
            Console.WriteLine(" 9:00 am - 8:00 pm ");
            Console.WriteLine("-----saturdays------");
            Console.WriteLine(" 9:00 am - 2:00 pm ");
            Console.WriteLine(">Choose a zone number<");
            Console.WriteLine("_zone [1]");
            Console.WriteLine("_zone [2]");
            Console.WriteLine("_zone [3]");
            Console.WriteLine("back to main menu [0]");
            
           

            int choiceZone = int.Parse(Console.ReadLine()); //choice of the number of the zone

                if (choiceZone == 1)
                {
                Console.WriteLine("Zone 1 selected");
                Console.WriteLine("---Price/max.Hour---");
                Console.WriteLine("1.15€/h - max.45 min");
                Zones();


                }

                if (choiceZone == 2)
                {
                Console.WriteLine("Zone 2 selected");
                Console.WriteLine("---Price/max.Hour---");
                Console.WriteLine("1€/h - max.2 hours");
                Zones();

                }

                if (choiceZone == 3)
                {
                Console.WriteLine("Zone 3 selected");
                Console.WriteLine("---Price/max.Hour---");
                Console.WriteLine("0.62€/h - no max.hours");
                Zones();
                }
               
            break;
        case 2:
            //Call Admin Menu
            //AdminMenu();
            break;
        case 5:
            activeMenu = true/*CloseApp(activeMenu)*/; //return to Main Menu
            break;
        default:
            Console.WriteLine("Please, choose only the numbers available in the script");
            activeMenu = true;
            //Unnexpected action from the user. What should it happen in this case? // shows the main menu whatever happends
            break;
    }
}




static void Zones() {

    Console.WriteLine("Insert your car plate:");
    Console.WriteLine("You can be parked for x hours.");
    Console.WriteLine("Go back to Client menu [6]");

    int backClientMenu = int.Parse(Console.ReadLine()); //choice to go back to the client menu
    if (backClientMenu == 6)
    {
       //code to come back to client menu

    }
    
    /*int backMainMenu = int.Parse(Console.ReadLine());

    if (backMainMenu == 0)
    {
        activeMenu = CloseApp(activeMenu); //como chamar para activar o backMAinMenu*/



    }













/*static void MainMenu(int userInput)
 {
 Console.WriteLine("Welcome to CarSlot Parking Agency!");
 Console.WriteLine(DateTime.Now); //Display date and time
 Console.WriteLine("Navigate through the Menus by presseing the representative number!");
 Console.WriteLine("Refresh Main Menu [0]");
 Console.WriteLine("Client Menu [1]");
 Console.WriteLine("Admin Menu [2]");
 Console.WriteLine("Leave Application [5]");
 }*/

/*static void AdminMenu()
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



    }*/




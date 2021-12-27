// See https://aka.ms/new-console-template for more information

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
    Console.WriteLine("Client Menu [0]");
    Console.WriteLine("Admin Menu [1]");
    Console.WriteLine("Options [2]");
    Console.WriteLine("Leave Application [3]");

    int userSelection = int.Parse(Console.ReadLine()); //user input to navigate through the Main Menu

    switch (userSelection) //Ref: https://stackoverflow.com/questions/43484523/switch-statements-for-a-menu-c
    {
        case 0:
            //Call client Menu
            //ClientMenu();
            break;
        case 1:
            //Call Admin Menu
            //AdminMenu();
            break;
        case 2:
            //Call Option Menu
            //OptionsMenu();
            break;
        case 3:
            activeMenu = false; //Closing Application
            break;
        default:
            //Unnexpected action from the user. What should it happen in this case?
            break;
    }
}
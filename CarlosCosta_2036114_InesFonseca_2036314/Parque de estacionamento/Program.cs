// See https://aka.ms/new-console-template for more information

Console.Title = "A Car Slot! -  Parking agency"; //Console Tittle
Console.ForegroundColor = ConsoleColor.Yellow; //Console Ink Color
//Console.BackgroundColor = ConsoleColor.DarkCyan; //Console Write Color

//================ Main Menu User Interface ================//
bool activeMenu = true; //Bool to Mantain the menu always active
while (activeMenu)
{
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
            //Unnexpected action from the user. What should it happen in this case?
            break;
    }


    static void MainMenu(int userInput)
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

    static void ClientMenu()
    {
        Console.WriteLine("ClientMenu selected!");
    }

    static void AdminMenu()
    {
        Console.WriteLine("AdminMenu selected!");
    }

    static void OptionsMenu()
    {
        Console.WriteLine("OptionsMenu selected!");
    }
    static bool CloseApp(bool setMenuOff)
    {
        return false;
    }
}

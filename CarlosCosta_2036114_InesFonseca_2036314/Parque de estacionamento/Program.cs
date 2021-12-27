// See https://aka.ms/new-console-template for more information


//================ Main Menu User Interface ================//
bool activeMenu = true;
while (activeMenu)
{
    Console.WriteLine("Welcome to StopCar agency Parking Slots!");
    Console.WriteLine("Welcome to StopCar agency Parking Slots!"); //Colocar Data e hora

    int userSelection = int.Parse(Console.ReadLine()); //user input to navigate through the Main Menu

    switch (userSelection)
    {
        case 0:
            //Call client Menu
            break;
        case 1:
            //Call Admin Menu
            break;
        case 2:
            //Call Option Menu
            break;
        case 3:
            activeMenu = false; //Closing Application
            break;
        default:
            //Unnexpected action from the user. What should it happen in this case?
            break;

    }

}

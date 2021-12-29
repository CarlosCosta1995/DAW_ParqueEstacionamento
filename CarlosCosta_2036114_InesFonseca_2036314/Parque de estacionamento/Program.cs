// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8; //para tornar o simbolo do euro em € ref:https://www.codeproject.com/Questions/455766/Euro-symbol-does-not-show-up-in-Console-WriteLine
System.Console.Out.WriteLine();

Console.Title = "A Car Slot! -  Parking agency"; //Console Tittle
Console.ForegroundColor = ConsoleColor.Yellow; //Console Ink Color


//================ Main Menu User Interface ================//

//loading
Console.WriteLine("Loading...");


//Menu

bool activeMenu = true; //Bool to Mantain the menu always active
while (activeMenu)

    {
        Console.WriteLine("start [0]"); //stand by and also a home button in all the menu
        int userSelectionMenu = int.Parse(Console.ReadLine()); //user input to navigate through the Menu
    
    switch (userSelectionMenu) //to be able to choose a number, Ref: https://stackoverflow.com/questions/43484523/switch-statements-for-a-menu-c
        {
            case 0: //Main Menu

                Console.WriteLine("Welcome to CarSlot Parking Agency!");
                Console.WriteLine(DateTime.Now); //display date and time
                Console.WriteLine("Navigate through the Menus by presseing the representative number!");
                Console.WriteLine("Client Menu [1]");
                Console.WriteLine("Admin Menu [2]");               
                break; //to prevent the other options from appering ate the same time

            case 1: //Client Menu
                                
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
                Console.WriteLine("back to main menu [5]");
                
                        
                        int userSelectionClientMenu = int.Parse(Console.ReadLine()); //choice of the number of the zone

                        if (userSelectionClientMenu == 5)
                        {
                            goto case 0; //ref. https://www.xsprogram.com/content/how-to-jump-to-another-case-statement-in-a-switch-case-condition-with-the-value.html
                        }

                        /*int backClientMenu = int.Parse(Console.ReadLine()); //choice to go back to the client menu*/
                        /*if (userSelectionClientMenu == 6)
                        {
                            return; //ref. https://www.xsprogram.com/content/how-to-jump-to-another-case-statement-in-a-switch-case-condition-with-the-value.html
                            
                        }*/


                        if (userSelectionClientMenu == 1)
                        {
                            Console.WriteLine("Zone 1 selected");
                            Console.WriteLine("---Price/max.Hour---");
                            Console.WriteLine("1.15€/h - max.45 min");
                            Zones();
                            

                            string ticket = Console.ReadLine();
                            if (ticket == "y")
                            {
                                Console.WriteLine("ticket");
                                Console.WriteLine("----zone 1----");
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine("You can be parked for x time.");
                                Console.WriteLine("I want to print another ticket [choiceZone]");
                                Console.WriteLine("done [X]");

                                    string done = Console.ReadLine();
                                    if (done == "x")
                                    {
                                        Console.WriteLine("thank you, BYE");
                                        //CloseApp();
                                    }
                            }

                            if (ticket == "n")
                            {
                                Console.WriteLine("Colect your money back and start again");
                            }

                        }


                        if (userSelectionClientMenu == 2)
                        {
                            Console.WriteLine("Zone 2 selected");
                            Console.WriteLine("---Price/max.Hour---");
                            Console.WriteLine("1€/h - max.2 hours");
                            Zones();

                            string ticket = Console.ReadLine();
                            if (ticket == "y")
                            {
                                Console.WriteLine("ticket");
                                Console.WriteLine("----zone 1----");
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine("You can be parked for x time.");
                                Console.WriteLine("I want to print another ticket");
                                Console.WriteLine("done [X]");

                                string done = Console.ReadLine();
                                if (done == "x")
                                {
                                    Console.WriteLine("thank you, BYE");
                                    //CloseApp();
                                }

                            if (ticket == "n")
                            {
                                Console.WriteLine("Colect your money back and start again");
                            }

                        }


                        /*if (userSelectionClientMenu == 3)
                        {
                            Console.WriteLine("Zone 3 selected");
                            Console.WriteLine("---Price/max.Hour---");
                            Console.WriteLine("0.62€/h - no max.hours");
                            Zones();

                            string ticket = Console.ReadLine();
                            if (ticket == "y")
                            {
                                Console.WriteLine("ticket");
                                Console.WriteLine("----zone 1----");
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine("You can be parked for x time.");
                                Console.WriteLine("I want to print another ticket [choiceZone]");
                                Console.WriteLine("done [X]");

                                string done = Console.ReadLine();
                                if (done == "x")
                                {
                                    Console.WriteLine("thank you, BYE");
                                    //goto case 5;
                                    //CloseApp();
                                }   

                        if (ticket == "n")
                        {
                            Console.WriteLine("Colect your money back and start again");
                        }
                        }
                    
                        }*/
                
            }
            break;

            case 2: //Call Admin Menu
                //AdminMenu();
                break;

            case 5://back to main menu from the client menu, cant be here because when we start and choose 6 it goes do client menu
            goto case 0;
                break;

            case 6: //back to client menu from any zone, cant be here because when we start and choose 6 it goes do client menu
            goto case 1;
            break;


            default: //what happends if the client chooses a letter/number that is not on the script, doesn´t work on client menu
                Console.WriteLine("Please, choose only the numbers available in the script");
                break;
    }
}










static void Zones()
{

    Console.WriteLine("Insert your car plate:");
    Console.WriteLine("You can be parked for x hours.");
    Console.WriteLine("Do you agree? type [y] or [n].");
    Console.WriteLine("Go back to Client menu [6]");
    Console.WriteLine("start [0]");
    
}

static bool CloseApp (bool setMenuOff)
{
    return false;
}




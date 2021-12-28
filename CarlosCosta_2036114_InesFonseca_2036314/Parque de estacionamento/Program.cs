// See https://aka.ms/new-console-template for more information

using Menus;
using Functionalities;

Console.Title = "A Car Slot! -  Parking agency"; //Console Tittle
Console.ForegroundColor = ConsoleColor.Yellow; //Console Ink Color
//Console.BackgroundColor = ConsoleColor.DarkCyan; //Console Write Color

//================ Main Menu User Interface ================//
/*bool activeMenu = true; //Bool to Mantain the menu always active
while (activeMenu)
{
    AllMenus.MainMenu();
    
}*/


Console.WriteLine("Insira a sua matricula");
string carPlateZone1 = Console.ReadLine();
CarPlate newCarPlate = new CarPlate(carPlateZone1, carPlateZone1, carPlateZone1);

Console.WriteLine(newCarPlate.occupiedSlotsZone1(carPlateZone1));
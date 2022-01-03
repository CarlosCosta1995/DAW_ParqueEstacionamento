// See https://aka.ms/new-console-template for more information

using Menus;
using Functionalities;
using ConsolePrint;

Console.OutputEncoding = System.Text.Encoding.UTF8; //para tornar o simbolo do euro em € ref:https://www.codeproject.com/Questions/455766/Euro-symbol-does-not-show-up-in-Console-WriteLine
System.Console.Out.WriteLine(); //does a \n in the beginning

Console.Title = "A Car Slot! -  Parking agency"; //Console Tittle
Console.ForegroundColor = ConsoleColor.Yellow; //Console Ink Color
                                               //Console.BackgroundColor = ConsoleColor.DarkCyan; //Console Write Color
Console.WriteLine("Loading...");
//================ Main Menu User Interface ================//
bool activeMenu = true; //Bool to Mantain the menu always active
while (activeMenu)
{
    AllMenus.Start();
}
  

/*
Console.WriteLine("Insira a sua matricula");
string carPlateZone1 = Console.ReadLine();
CarPlate newCarPlate = new CarPlate(carPlateZone1, carPlateZone1, carPlateZone1);

Console.WriteLine(newCarPlate.occupiedSlotsZone1(carPlateZone1));*/

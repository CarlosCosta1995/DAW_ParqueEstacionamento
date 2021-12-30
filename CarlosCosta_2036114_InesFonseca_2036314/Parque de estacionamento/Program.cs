// See https://aka.ms/new-console-template for more information

using Menus;
using Functionalities;
using ConsolePrint;

Console.Title = "A Car Slot! -  Parking agency"; //Console Tittle
Console.ForegroundColor = ConsoleColor.Yellow; //Console Ink Color
                                               //Console.BackgroundColor = ConsoleColor.DarkCyan; //Console Write Color

//================ Main Menu User Interface ================//
bool activeMenu = true; //Bool to Mantain the menu always active
while (activeMenu)
{
    AllMenus.MainMenu();
  
}

/*
Console.WriteLine("Insira a sua matricula");
string carPlateZone1 = Console.ReadLine();
CarPlate newCarPlate = new CarPlate(carPlateZone1, carPlateZone1, carPlateZone1);

Console.WriteLine(newCarPlate.occupiedSlotsZone1(carPlateZone1));*/


/*//Criar um do while e vai addicionando os valores e enviar para o method o valor total
bool stop = true;
MoneyMachine moneyMachine = new MoneyMachine();
do {
    Console.WriteLine("\nInsira o seu dinheiro:");
    moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));
    if (moneyMachine._cash == 0) { stop = false; moneyMachine.refundCash(); }
}while ( stop == true );*/

/*
int hour = DateTime.Now.Hour;
int minute = DateTime.Now.Minute;
Console.WriteLine("{0}h:{1}min",hour, minute);*/

//TimeSlpit.DateTimeNow(DateTime.ToString());

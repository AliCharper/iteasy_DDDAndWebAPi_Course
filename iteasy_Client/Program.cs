// See https://aka.ms/new-console-template for more information

using CommandPattern.Data;
using CommandPattern.Infra.Commands;
using CommandPattern.Infra.Invoker;
using CompositeDesignPattern.Infra;
using CompositeDesignPattern.Interface;


#region CommandDesignPattern

var dataReceiver = new DataReceiver();
var invoker = new DataCommandInvoker();

invoker.SetCommand(new UpsertCommand("item1", "value1", dataReceiver));
invoker.ExecuteCommand();

invoker.SetCommand(new DeleteCommand("item1", dataReceiver));
invoker.ExecuteCommand();

Console.ReadKey();



#endregion




#region CompositeDesignPattern

//Console.WriteLine("****** Asset Price *******");


////Creating Leaf Objects
//ICustomComponent cpu = new Leaf("CPU", 10);
//ICustomComponent ram = new Leaf("RAM", 10);
//ICustomComponent hardDisk = new Leaf("Hard Disk", 10);
//ICustomComponent mouse = new Leaf("Mouse", 10);
//ICustomComponent keyboard = new Leaf("Keyboard", 50);

////Creating composite objects
//ICustomComponent motherBoard = new Composite("Board");
//ICustomComponent cabinet = new Composite("cabinet");
//ICustomComponent peripherals = new Composite("Peripherals");

////Whole Device
//ICustomComponent computer = new Composite("Computer");


////Creating tree structure

////Ading CPU and RAM in Mother board
//motherBoard.AddComponent(cpu);
//motherBoard.AddComponent(ram);
////Ading mother board and hard disk in Case
//cabinet.AddComponent(motherBoard);
//cabinet.AddComponent(hardDisk);
////Ading mouse and keyborad in peripherals
//peripherals.AddComponent(mouse);
//peripherals.AddComponent(keyboard);
////Ading cabinet and peripherals in computer
//computer.AddComponent(cabinet);
//computer.AddComponent(peripherals);

////To display the Price of the Computer
//var Price = computer.CalculatePrice();

//Console.WriteLine(Price.ToString());
//Console.WriteLine();




#endregion

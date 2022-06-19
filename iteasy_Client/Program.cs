// See https://aka.ms/new-console-template for more information

using CommandPattern.Data;
using CommandPattern.Infra.Commands;
using CommandPattern.Infra.Invoker;
using CompositeDesignPattern.Infra;
using CompositeDesignPattern.Interface;
using Eshop_DataAccess.Infra;
using Eshop_DataAccess.Infra.Commands;
using Eshop_DataAccess.Infra.Enums;
using Eshop_DataAccess.Repositories;
using MediatorDesignPattern.Infra.Concrete;
using MediatorDesignPattern.Infra.Concrete.Mediator;
using SingletonPattern;


#region wrapper
//static void PrintCart(ShoppingCartRepository shoppingCartRepository)
//{
//    var totalPrice = 0m;
//    foreach (var lineItem in shoppingCartRepository.LineItems)
//    {
//        var price = lineItem.Value.Product.Price * lineItem.Value.Quantity;

//        Console.WriteLine($"{lineItem.Key} " +
//            $"${lineItem.Value.Product.Price} x {lineItem.Value.Quantity} = ${price}");

//        totalPrice += price;
//    }

//    Console.WriteLine($"Total price:\t${totalPrice}");
//}
#endregion


#region SingletonPattern

var object1 = SingletonObject.GetInstance();
Console.WriteLine($"Data of object 1: {object1.Data}");

var object2 = SingletonObject.GetInstance();
Console.WriteLine($"Data of object 2: {object2.Data}");

Console.WriteLine($"Are objects equal? {object.Equals(object1, object2)}");

Console.ReadKey();

#endregion




#region MediatorDesignPattern

//var networkMediator = new NetworkMediator();

//var desktopComputer = new DesktopComputer("computer-1", networkMediator);

//var server = new Server("server-1", networkMediator);

//networkMediator.Register("computer-1", desktopComputer);
//networkMediator.Register("server-1", server);

//desktopComputer.SendCommand("server-1", "reboot");
//server.SendCommand("computer-1", "trigger-updates");

//Console.ReadKey();


#endregion




#region Eshop_DataAccess_Executer 

//var shoppingCartRepository = new ShoppingCartRepository();
//var productsRepository = new ProductsRepository();

//var product = productsRepository.FindBy("SM7B");

//var addToCartCommand = new AddToCartCommand(shoppingCartRepository,
//    productsRepository,
//    product);

//var increaseQuantityCommand = new ChangeQuantityCommand(
//    Operation.Increase,
//    shoppingCartRepository,
//    productsRepository,
//    product);

//var manager = new CommandManager();
//manager.Invoke(addToCartCommand);
//manager.Invoke(increaseQuantityCommand);
//manager.Invoke(increaseQuantityCommand);
//manager.Invoke(increaseQuantityCommand);
//manager.Invoke(increaseQuantityCommand);

//PrintCart(shoppingCartRepository);

//manager.Undo();

//PrintCart(shoppingCartRepository);


#endregion






#region CommandDesignPattern

//var dataReceiver = new DataReceiver();
//var invoker = new DataCommandInvoker();

//invoker.SetCommand(new UpsertCommand("item1", "value1", dataReceiver));
//invoker.ExecuteCommand();

//invoker.SetCommand(new DeleteCommand("item1", dataReceiver));
//invoker.ExecuteCommand();

//Console.ReadKey();



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

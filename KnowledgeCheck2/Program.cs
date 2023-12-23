using KnowledgeCheck2;


Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Product>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()

    var CatFood = new CatFood();

    Console.WriteLine("Enter the name of the cat food: ");
    CatFood.Name = Console.ReadLine();

    Console.WriteLine("Enter the price of the cat food: ");
    CatFood.Price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter the quantity of the cat food: ");
    CatFood.Quantity = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the description of the cat food: ");
    CatFood.Description = Console.ReadLine();

    Console.WriteLine("Enter the cat food's flavor: ");
    CatFood.Flavor = Console.ReadLine();

    recordList.Add(CatFood);

    // Print out the list of records using Console.WriteLine()

    foreach (var record in recordList)

    {
        Console.WriteLine(record.ToString());

        Console.WriteLine();
    }
}





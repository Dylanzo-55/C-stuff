string[] pallets =["B14","A11","B12","A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (string pallet in pallets) // pallet is a variable that represents each element in the pallets array
{
    Console.WriteLine(pallet);
}

//* resize the array to hold 6 elements 

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}




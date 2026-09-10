string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second); // Output: World Hello!
Console.WriteLine("{0} {0} {0}!", first, second); // Output: Hello Hello Hello!


decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C}, (Save {discount}%!)"); // Output: Price: $123.45, (Save 50%!)
// to use rands instead of dollars use system.Globalization.CultureInfo

// formatting numbers with more readability
decimal largeNumber = 1234567890.213412m;
Console.WriteLine($"Large number: {largeNumber:N6}"); // Output: Large number: 1,234,567,890.213412 (N is used for number formatting with commas and decimal places)

decimal tax = 0.075m;
Console.WriteLine($"Tax: {tax:P2}"); // Output: Tax: 7

// formatting numbers with currency and percentage
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"\t Shares: {productShares:N3} Product");
Console.WriteLine($"\t\t Sub Total: {subtotal:C}");
Console.WriteLine($"\t\t\t Tax: {taxPercentage:P2}");
Console.WriteLine($"\t\t Total Billed: {total:C}");











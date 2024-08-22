// See https://aka.ms/new-console-template for more information

// Console.WriteLine("a" == "a ");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quich brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// Console.WriteLine(pangram.Contains("fox" == false));
// Console.WriteLine(!pangram.Contains("fox"));

// string pangram = "The quick brown fox jumps over the lazy dog.";

// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// int a = 7;
// int b = 6;
// Console.WriteLine(a != b);
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2);

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// int saleAmount = 1001;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Random coin = new Random();

// int flip = coin.Next(0, 2); // el rango superior es exclusivo
// Console.WriteLine((flip == 0) ? "heads" : "tails");

string permission = "Manager";
int level = 10;

if (permission.ToLower().Contains("admin"))
    if (level > 55)
    Console.WriteLine("Welcome, Super Admin user.");
    else if (level <= 55)
    Console.WriteLine("Welcome, Admin user");
if (permission.ToLower().Contains("manager"))
    if (level > 20)
    Console.WriteLine("Contact an Admin for acces.");
    else if (level < 20)
    Console.WriteLine("You do not have sufficient privileges.");
else 
    Console.WriteLine("You do not have sufficient privileges");







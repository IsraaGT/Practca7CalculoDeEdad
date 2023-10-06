Console.WriteLine("En qué año naciste? ");
int AñoN = int.Parse(Console.ReadLine());

int AñoA = DateTime.Now.Year;
int edad = AñoA - AñoN;

Console.WriteLine("Tu edad es " + edad + " años.");

Console.ReadKey();
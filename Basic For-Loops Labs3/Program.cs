int i, n, sum = 0;

Console.WriteLine("Enter a number:");

n = Convert.ToInt32(Console.ReadLine());


for (i = 1; i <= n; i++) {
    sum += i;

}
    Console.WriteLine("Total sum: " + sum);

 Console.WriteLine("Would you like to continue (y/n)? ");
if (Console.ReadLine() == "n")
{
  
Console.WriteLine("Goodbye!");
}








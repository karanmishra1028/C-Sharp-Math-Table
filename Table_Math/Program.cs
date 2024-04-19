// See https://aka.ms/new-console-template for more information

//Code to ask for input from user and write time table for the same

bool success = true;


int num2 = 0;
while (success)
{
    Console.Write("Enter a number: ");
    string num2Input = Console.ReadLine();

    
    if (int.TryParse(num2Input, out num2)) //try convert string entered by user to int
    {
        success = false;
        Console.WriteLine("Selected number is {0}",num2);
    }
    else
    {
        Console.WriteLine("Failed to convert");
    }
}



for (int i = 1; i < 11; i++)
{
    int table = num2 * i;

    Console.WriteLine("{0} x {1} = {2}", i,num2,table);
}

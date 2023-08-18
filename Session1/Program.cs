// See https://aka.ms/new-console-template for more information
using Session1;

while (true)
{


    Console.WriteLine("Request : \n 1-Factorial\n 2-Binary Search\n 3-Fast Searcher\n 4-Linear Searcher\n 5-Bianry Insertion Sorter\n 6-Bubble Sorter\n 7-Clear");
    int code;
    while (!int.TryParse(Console.ReadLine(), out code))
    {
        Console.WriteLine("Request : \n 1-Factorial\n 2-Binary Search\n 3-Fast Searcher\n 4-Linear Searcher\n 5-Bianry Insertion Sorter\n 6-Bubble Sorter\n 7-Clear");
    }
    switch (code)
    {
        case 1:
            Factorial();
            break;
        case 2:
            BinarySearcher();
            break;
        case 3:
            Factorial();
            break;
        case 4:
            LinearSearcher();
            break;
        case 5:
            Binery_InsertionSorter();
            break;
        case 6:
            BubbleSorter();
            break;
        case 7:
            Console.Clear();
            break;
        default:
            Console.WriteLine("Pleaze Enter Correct Code.");
            break;
    }
}
void Factorial()
{
    int Number = GetNumber();
    Console.WriteLine(Algorithms.Factorial(Number)); ;
}
void BinarySearcher()
{
    int[] Arry = GetArray();
    Arry = Algorithms.BubbleSorter(Arry);
    int Number = GetNumber();
    int index = Algorithms.BinarySearcher(Arry,Number,0,Arry.Length-1);
    if(index >=0)
    {
        Console.WriteLine("Your Input Founded And Index is: {0}",index);
    }
    else
    {
        Console.WriteLine("Your Input Not Found.");
    }
    
}
void LinearSearcher()
{
    int[] Arry = GetArray();
    Arry = Algorithms.BubbleSorter(Arry);
    int Number = GetNumber();
    int index = Algorithms.LinearSearcher(Arry, Number);
    if (index >= 0)
    {
        Console.WriteLine("Your Input Founded And Index is: {0}", index);
    }
    else
    {
        Console.WriteLine("Your Input Not Found.");
    }

}
void Binery_InsertionSorter()
{
    int[] Arry = GetArray();
    Arry = Algorithms.Binery_InsertionSorter(Arry);
    foreach (int Number in Arry)
    {
        Console.Write(" " + Number + " ");
    }
    Console.WriteLine();
}
void BubbleSorter()
{
    int[] Arry = GetArray();
    Arry = Algorithms.BubbleSorter(Arry);
    foreach (int Number in Arry)
    {
        Console.Write(" "+Number+" ");
    }
    Console.WriteLine();
}
int[] GetArray()
{
    bool create = false;
    int number;
    List<int> numbers = new List<int>();
    while (!create)
    {
        Console.WriteLine("Enter You Array : \n Enter E For Create Array");
        string input = Console.ReadLine();
        if (input == "E")
        {
            create = true;
            continue;
        }
        else
        {
            if (int.TryParse(input, out number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Pleaze Enter Correct Input.");
                continue;
            }
        }
    }
    int[] numbersArry = new int[numbers.Count];
    for (int i = 0; i < numbers.Count; i++)
    {
        numbersArry[i] = numbers[i];
    }
    return numbersArry;
}
int GetNumber()
{
    int Number;
    Console.WriteLine("Input Number :");
    while (!int.TryParse(Console.ReadLine(), out Number))
    {
        Console.WriteLine("Input Number :");
    }
    return Number;
}


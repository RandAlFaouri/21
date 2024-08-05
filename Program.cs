//5 public delegate bool Filter<in T>(T n);
internal class Program
{
   //4 public delegate bool Filter(int n);
    private static void Main(string[] args)
    {
        Action<string> action = Print;
        action("Rand");
        Func<int, int, int> addD = Add;
        Console.WriteLine(addD(2,2));
        Predicate<int> predicate = IsEven;
        Console.WriteLine(predicate(3));
            ;



      /*//5  IEnumerable<decimal> list2 = new decimal[] { 2.5m, 5.3m, 6.33m, 7.1m, 6.44m, 1.75m, 3.4m, 4.2m, 8.7m };
        Console.WriteLine("Number Greater than equal 6.33");
        PrintNumber(list2, n => n >= 6.33m);*/
       /* //4 IEnumerable<int> list1 = new int[] { 2, 5, 6, 7, 9, 1, 3, 4, 8 };
        Console.WriteLine("Numbers Less than 6");
        PrintNumber(list1, n => n < 6);
        Console.WriteLine("Numbers Less than 7");
        PrintNumber(list1, n => n < 7);
        Console.WriteLine("Even Numbers");
        PrintNumber(list1, n => n % 2 == 0);*/
        /*Console.WriteLine("Numbers Less than 6");
                PrintNumberLessThanSix(list1);
                Console.WriteLine("Numbers Less than 7");
                PrintNumberLessThanSeven(list1);*/
        //3 Console.WriteLine("Even Numbers ");
        //3PrintEvenNumber(list1);

        //2  PrintNumberLessThan(list1, 7);
    }
    // static void PrintNumber<T>(IEnumerable<T> numbers, Predicate<T> filter){
    static void PrintNumber<T>(IEnumerable<T> numbers, Func<T,bool> filter)
    {
        foreach (var n in numbers)
        {
            if (filter(n))
            {
                Console.WriteLine(n);
            }
        }
        }
    static void Print(string name) => Console.WriteLine(name);
    static int Add(int n1, int n2) => n1 + n2;
    static bool IsEven(int n) => n % 2 == 0;
    /*//4static void PrintNumber(IEnumerable<int> numbers,Filter filter)
    {
        foreach (var n in numbers)
        {
            if (filter(n))
            {
                Console.WriteLine(n);
            }

        }
    }*/
  /*//5  static void PrintNumber<T>(IEnumerable< T> numbers , Filter<T> filter)
   {
       foreach (var n in numbers)
       {
           if (filter(n))
           {
               Console.WriteLine(n);
           }

       }
   }*/
   /* //3 static void PrintEvenNumber(IEnumerable<int> numbers)
   {
       foreach (var n in numbers)
       {
           if (n % 2 == 0)
           {
               Console.WriteLine(n);
           }

       }
   }*/
    /* //2 static void PrintNumberLessThan(IEnumerable<int> numbers,int pivotNumber)
     {
         foreach (var n in numbers)
         {
             if (n <pivotNumber)
             {
                 Console.WriteLine(n);
             }
         }
     }*/
    /*//1 static void PrintNumberLessThanSix(IEnumerable<int> numbers)
     {
         foreach (var n in numbers)
         {
             if (n < 6)
             {
                 Console.WriteLine(n);
             }
         }
     }
     static void PrintNumberLessThanSeven(IEnumerable<int> numbers)
     {
         foreach (var n in numbers)
         {
             if (n < 7)
             {
                 Console.WriteLine(n);
             }
         }
     }*/
}
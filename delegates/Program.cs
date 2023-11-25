namespace Myspace;
delegate int[] Operation(int[] arr); 
delegate string OperationB(int[] arr);
class program
{
    static int[] paired(int[] arr)
    {
        int iterator = 0;
        foreach (int i in arr)
        {
            if(i%2 == 0)
            {
               iterator++;
            }
        }
        int[] pairedArr = new int[iterator];
        int a = 0;
        foreach (int i in arr)
        {
            if (i%2 == 0)
            {
                pairedArr[a] = i;
                a++;
            }
            
        }
        return pairedArr;
    }

    static int[] unpaired(int[] arr)
    {
        int iterator = 0;
        foreach (int i in arr)
        {
            if (i % 2 != 0)
            {
                iterator++;
            }
        }
        int[] unpairedArr = new int[iterator];
        int a = 0;
        foreach (int i in arr)
        {
            if (i % 2 != 0)
            {
                unpairedArr[a] = i;
                a++;
            }

        }
        return unpairedArr;
    }

    static int[] biggerTen(int[] arr)
    {
        int iterator = 0;
        foreach (int i in arr)
        {
            if (i >= 10)
            {
                iterator++;
            }
        }
        int[] biggerTenArr = new int[iterator];
        int a = 0;
        foreach (int i in arr)
        {
            if (i >= 10)
            {
                biggerTenArr[a] = i;
                a++;
            }

        }
        return biggerTenArr;
    }

    static string readArr(int[] arr)
    {
        string array = "";
        foreach (int i in arr)
        {
            array += i.ToString() + " ";
        }
        return array;
    }
    static void Main(string[] args)
    {
        int i = 1;
        int[] arr = new int[10];
        Console.WriteLine("Input ten numbers");
        Thread.Sleep(1000);
        Console.Clear();
        while (i < 11)
        {
            Console.WriteLine("Input " + i + " Number");
            try
            {
                string n = Console.ReadLine();
                arr[i - 1] = int.Parse(n);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            i++;
        }
        Console.Clear();
        Operation operation = paired;
        OperationB read = readArr;

        Console.WriteLine("Your arr:\n"+read(arr));

        int[] pairedArr =  operation (arr);
        Console.WriteLine("Paired:\n" + read(pairedArr));

        operation = unpaired;
        int[] unpairedArr = operation (arr);
        Console.WriteLine("Unpaired:\n" + read(unpairedArr));

        operation = biggerTen;
        int[] biggerTenArr = operation (arr);
        Console.WriteLine("Bigger then ten:\n" +  read(biggerTenArr));

    }

}
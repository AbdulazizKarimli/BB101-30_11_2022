namespace ConsoleApp1;

class Program
{
    //delegate void PrintDelegate<in K>(K str);
    //delegate R CustomFunc<in T,out R>(T s);
    //delegate R CustomF<out R>();

    public static void Main()
    {
        #region Action -17 overload, return type is void
        //Action<string> func1 = delegate (string name)
        //{
        //    Console.WriteLine(name[0]);
        //};
        //Action<string> func2 = name => Console.WriteLine(name[0]);

        //Action<string> func3 = name => Console.WriteLine(name[^1]);

        //Action<string> func4 = str => Console.WriteLine(str[0]);
        //Action intAction = ShowIntMax;
        //intAction += ShowIntMin;
        //intAction();
        #endregion

        #region Func
        //Func<string,int> func = ShowLength;
        //Func<int,string> func1 = ShowType;
        #endregion

        #region Predicate
        //Predicate<int> predicate = num => num > 0;
        #endregion

        //[1,2,3,0]
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.Add(2);
        ints.Add(3);
        Console.WriteLine(ints.Capacity);

        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }
        Dictionary<string, string> contact = new Dictionary<string, string>();
        contact.Add("Muhammed", "0507362872");
        contact.Add("Kamran", "0507362872");

    }

    static int ShowLength(string str)
    {
        return str.Length;
    }

    static string ShowType(int i)
    {
        return i.GetType().ToString();
    }
    static void ShowIntMax()
    {
        Console.WriteLine(Int32.MaxValue);
    }

    static void ShowIntMin()
    {
        Console.WriteLine(Int32.MinValue);
    }
    void Print(int str)
    {
        Console.WriteLine(str);
    }

    void Print(string str)
    {
        Console.WriteLine(str);
    }

}

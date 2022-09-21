
using System.Security.Cryptography;

class Game
{
    private int a = 0;
    private int b1,b2;
    private int c1, c2, c3, c4;
    private int d;
    public int Percent() { return b1 * b2 / 100; }
    public bool Prover(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (!Char.IsDigit(str[i]))
                return false;
        }
        return true;
    }
    public int Summ3()
    {
        int summ = 0;
        summ += c1;
        summ = summ * 10 + c2;
        summ = summ * 10 + c3;
        summ = summ * 10 + c4;

        return summ;
    }
    public int Replace()
    {
        int tmp = 0, tmp2 = 0;
        string str = "adad";

        while (!Prover(str) || int.Parse(str) < 1 || int.Parse(str) > 6)
        {
            Console.Write("Enter 1st position(1-6): ");
            str = Console.ReadLine();
            if (!Prover(str) || int.Parse(str) < 1 || int.Parse(str) > 6)
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                tmp = int.Parse(str) - 1;
        }
        str = "adad";
        while (!Prover(str) || int.Parse(str) < 1 || int.Parse(str)>6)
        {
            Console.Write("Enter 2nd position(1-6): ");
            str = Console.ReadLine();
            if (!Prover(str) || int.Parse(str) < 1 || int.Parse(str) > 6)
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                tmp2 = int.Parse(str) - 1;
        }
        if(tmp != tmp2)
        {
            char t1;
            str = Convert.ToString(d);
            char[] tt = str.ToCharArray();       
            t1 = tt[tmp2];
            tt[tmp2] = tt[tmp];
            tt[tmp] = t1;
            d = int.Parse(tt);
        }

        return d;
    }
    public void Vvod1()
    {
        a = 0;
        string str = "adad";
        while (a < 1 || a > 100)
        {
            Console.Write("Enter number (1 - 100): ");
            str = Console.ReadLine();
            if (!Prover(str) && a < 1 || a > 100 && !Prover(str))
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                a = int.Parse(str);
        }
    }
    public void Vvod2()
    {
        b1 = 0;
        b2 = 0;
        string str = "adad";
        while (!Prover(str))
        {
            Console.Write("Enter number: ");
            str = Console.ReadLine();
            if (!Prover(str))
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                b1 = int.Parse(str);
        }
        str = "dask";
        while (b2 < 1 || b2 > 100)
        {
            Console.Write("Enter number(percent for previous number): ");
            str = Console.ReadLine();
            if (!Prover(str) && b2 < 1 || b2 > 100 && !Prover(str))
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                b2 = int.Parse(str);
        }
        Console.WriteLine(b1 + " " + b2);
    }
    public void Vvod3()
    {
        c1 = 0;
        c2 = 0;
        c3 = 0;
        c4 = 0;
        string str = "adad";
        while (!Prover(str))
        {
            Console.Write("Enter number #1: ");
            str = Console.ReadLine();
            if (!Prover(str))
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                c1 = int.Parse(str);
        }
        str = "adad";
        while (!Prover(str))
        {
            Console.Write("Enter number #2: ");
            str = Console.ReadLine();
            if (!Prover(str))
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                c2 = int.Parse(str);
        }
        str = "adad";
        while (!Prover(str))
        {
            Console.Write("Enter number #3: ");
            str = Console.ReadLine();
            if (!Prover(str))
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                c3 = int.Parse(str);
        }
        str = "adad";
        while (!Prover(str))
        {
            Console.Write("Enter number #4: ");
            str = Console.ReadLine();
            if (!Prover(str))
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                c4 = int.Parse(str);
        }
    }
    public void Vvod4()
    {
        d = 0;
        string str = "adad";
        while (!Prover(str) || str.Length != 6)
        {
            Console.Write("Enter number(6 chisel :D): ");
            str = Console.ReadLine();
            if (!Prover(str) || str.Length != 6)
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                d = int.Parse(str);
        }
    }
    public void Vvod6()
    {
        c1 = 0;
        char vvod = 'a';
        Console.WriteLine("1.faringeit\n2.celsius\nESC - exit");
        while (vvod != '1' && vvod != '2' && vvod != 27)
        {
            
            vvod = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (vvod != '1' && vvod != '2')
            {
                if (vvod != 27)
                {
                    Console.WriteLine("wrong input. try again\n");
                }
            }
            else
                c1 = vvod - 49;
        }
        if(vvod != 27)
        {
            string str = "adad";
            while (!Prover(str))
            {
                Console.Write("Enter temperature");
                if (vvod == '1') Console.Write(" faringeit: ");
                if (vvod == '2') Console.Write(" celsius: ");
                str = Console.ReadLine();
                if (!Prover(str))
                    Console.WriteLine("Wrong input! Enter correct number.");
                else
                    c1 = int.Parse(str);
            }
            if(vvod == '1')
            {
                Console.WriteLine(c1 + " faringeit = " + ((c1 - 32) / 1.8 ) + " celsius");
            }
            if (vvod == '2')
            {
                Console.WriteLine(c1 + " celsius = " + (c1 * 1.8 + 32) + " faringeit");
            }
        }
    }
    public void Vvod7()
    {
        b1 = 0;
        b2 = 0;
        string str = "adad";
        while (!Prover(str))
        {
            Console.Write("Enter number #1: ");
            str = Console.ReadLine();
            if (!Prover(str))
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                b1 = int.Parse(str);
        }
        str = "dask";
        while (b2 < 1 || b2 > 100)
        {
            Console.Write("Enter number #2: ");
            str = Console.ReadLine();
            if (!Prover(str) && b2 < 1 || b2 > 100 && !Prover(str))
                Console.WriteLine("Wrong input! Enter correct number.");
            else
                b2 = int.Parse(str);
        }
        if(b1>b2)
        {
            int s = b1;
            b1 = b2;
            b2 = s;
        }
        for (int i = b1; i < b2; i++)
        {
            if(i%2==0)
                Console.WriteLine(i);
        }
    }
    public void Proverka()
    {
        if (a % 3 == 0 && a % 5 != 0) Console.WriteLine("Fizz");
        else if (a % 5 == 0 && a % 3 != 0) Console.WriteLine("Buzz");
        else if (a % 5 == 0 && a % 3 == 0) Console.WriteLine("Fizz Buzz");
        else Console.WriteLine(a);
    }
}

class Program
{
    static void Main()
    {
        var H = new Game();

        char vvod;
        do
        {
            Console.Clear();
            Console.WriteLine("1.Part 1\n2.Part 2\n3.Part 3\n4.Part 4\n5.Part 5\n6.Part 6\n7.Part 7\n");
            vvod = Console.ReadKey().KeyChar;
            
            switch(vvod)
            {
                case '1':
                    Console.Clear();
                    H.Vvod1();
                    H.Proverka();
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case '2':
                    Console.Clear();
                    H.Vvod2();
                    Console.WriteLine("Percent: " + H.Percent());
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case '3':
                    Console.Clear();
                    H.Vvod3();
                    Console.WriteLine(H.Summ3());
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case '4':
                    Console.Clear();
                    H.Vvod4();
                    Console.WriteLine(H.Replace());
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Kalendar ? opyat ? no thx...");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case '6':
                    Console.Clear();
                    H.Vvod6();
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
                case '7':
                    Console.Clear();
                    H.Vvod7();
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
            }
        } while(vvod != 27);
        H.Vvod1();
        H.Proverka();
    }
}
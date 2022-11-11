using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace TooMuch
{
    public enum AccountType
    {
        Накопительный, Кредитный
    }
    class BankAccount1
    {
        public ulong account_number;
        public decimal balance;
        public AccountType acc_type;
        public BankAccount1(ulong account_number, decimal balance, AccountType acc_type)
        {
            this.account_number = account_number;
            this.balance = balance;
            this.acc_type = acc_type;
        }
        public void increase(ulong account_number, decimal balance, AccountType acc_type)
        {
            this.account_number = account_number;
            this.balance = balance;
            this.acc_type = acc_type;
        }
        public void decrease(ulong account_number, decimal balance, AccountType acc_type)
        {
            this.account_number = account_number;
            this.balance = balance;
            this.acc_type = acc_type;
        }

        public void Print()
        {
            Console.WriteLine($"Номер счета - {account_number}, баланс - {balance} рублей, тип счета - {acc_type}");
        }
    }

    static class BankAccount2
    {
        static public decimal balance = 15000;
    }
    class Song
    {
        string name;
        string author;
        Song prev;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public Song Prev
        {
            get { return prev; }
            set { prev = value; }
        }
        public void Print()
        {
            Console.WriteLine(name + author);
        }
        public string Title()
        {
            string s = name + author;
            return s;
        }
        public bool Equals(Song d)
        {

            if (d.Title() == Title()) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        public static void Task81(BankAccount1 acc1, decimal perevod)
        {
            if (acc1.balance > perevod)
            {
                acc1.balance -= perevod;
                BankAccount2.balance += perevod;
                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Not enought money");
            }
            Console.WriteLine();
            Console.WriteLine("Банк 1");
            Console.WriteLine("Номер: " + acc1.account_number);
            Console.WriteLine("Номер: " + acc1.balance);
            Console.WriteLine("Тип счета: " + acc1.acc_type);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Банк 2");
            Console.WriteLine("Номер: " + BankAccount2.balance);
        }
        public static string Task82(string s)
        {
            string a = "";
            for (int i = s.Length - 1; i > -1; i -= 1)
            {
                a += s[i];
            }
            return a;
        }
        static void Task83(string s)
        {
            string path = @s; 
            if (File.Exists(path) == true)
            {
                StreamReader sr = new StreamReader(path);
                string a = sr.ReadLine();
                string b = a.ToUpper();
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Такого файла нет");
            }
        }
        static void Task84_1(object a)
        {
            if (a is IFormattable)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
        static void Task84_2(object a)
        {
            if (a as IFormattable != null)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
        static void Task85()
        {
            StreamReader x = new StreamReader(@"5.txt");
            string[] a = x.ReadLine().Split('#');
            x.Close();
            string z = a[1];
            StreamWriter f = new StreamWriter(@"5.txt", false);
            f.Write(z);
            Console.WriteLine(z);
            f.Close();
            Console.WriteLine("121");
        }


        static void Main(String[] args)
        {
            BankAccount1 account1 = new BankAccount1(123123, 15000, AccountType.Накопительный);
            Console.WriteLine("Задание 1");
            Console.WriteLine();
            Console.WriteLine("Банк 1");
            Console.WriteLine("Номер: " + account1.account_number);
            Console.WriteLine("Номер: " + account1.balance);
            Console.WriteLine("Тип счета: " + account1.acc_type);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Банк 2");
            Console.WriteLine("Номер: " + BankAccount2.balance);
            Console.WriteLine();
            Console.Write("Введите счет: ");
            decimal x1 = decimal.Parse(Console.ReadLine());
            Task81(account1, x1);
            Console.ReadKey();
            Console.Clear();
            /////////////////////////////////////////////////
            Console.WriteLine("Задание 2");
            Console.Write("Введите строку: ");
            string x2 = Console.ReadLine();
            string x3 = Task82(x2);
            Console.WriteLine("Вот получившаяся строука: " + x3);
            Console.ReadKey();
            Console.Clear();
            //////////////////////////////////////////////////
            Console.WriteLine("Задание 3");
            Console.Write("Введиет название файла, он должнен находиться в 'bin/Debug': ");
            string x4 = Console.ReadLine();
            Task83(x4);
            /////////////////////////////////////////////////////
            Console.WriteLine("Задание 4");
            Task84_1(12);
            Task84_2("qweqwe");
            /////////////////////////////////////////////////////
            Console.WriteLine("Задание 5");
            Task85();
            Console.WriteLine("Задание 6");
            Song p1 = new Song();
            p1.Name = "qwe";
            p1.Author = "asd";
            Song p2 = new Song();
            p2.Name = "qwe";
            p2.Author = "asd";
            Console.WriteLine(p1.Equals(p2));
            
        }
    }
}
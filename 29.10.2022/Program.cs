using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Dev { public string Name { get; set; } public bool Boss; public Dev(string name, bool boss) { Name = name; Boss = boss; } }
    public class Boris : Dev
    {
        public Boris(string name, bool boss) : base(name, boss) { }
    }
    class Rashid : Boris
    {
        public Rashid(string name, bool boss) : base(name, boss) { }
    }
    class OIlham : Boris
    {
        public OIlham(string name, bool boss) : base(name, boss) { }
    }
    class Rashid1 : Dev
    {
        public Rashid1(string name, bool boss) : base(name, boss) { }
    }
    class Lukas : Rashid1
    {
        public Lukas(string name, bool boss) : base(name, boss) { }
    }
    class Lukas1 : Dev
    {
        public Lukas1(string name, bool boss) : base(name, boss) { }
    }
    class Buh : Lukas1
    {
        public Buh(string name, bool boss) : base(name, boss) { }
    }
    public class OIlham1 : Dev
    {
        public OIlham1(string name, bool boss) : base(name, boss) { }
    }
    class Orcadiy : OIlham1
    {
        public Orcadiy(string name, bool boss) : base(name, boss) { }
    }
    class Volodya : Orcadiy
    {
        public Volodya(string name, bool boss) : base(name, boss) { }
    }
    public class Orcadiy1 : Dev
    {
        public Orcadiy1(string name, bool boss) : base(name, boss) { }
    }
    class Volodya1 : Orcadiy1
    {
        public Volodya1(string name, bool boss) : base(name, boss) { }
    }
    class Sergey : Volodya1
    {
        public Sergey(string name, bool boss) : base(name, boss) { }
    }
    public class Sergey1 : Dev
    {
        public Sergey1(string name, bool boss) : base(name, boss) { }
    }
    class Lyaisan : Sergey1
    {
        public Lyaisan(string name, bool boss) : base(name, boss) { }
    }
    public class Lyaisan1 : Dev
    {
        public Lyaisan1(string name, bool boss) : base(name, boss) { }
    }
    class Marat : Lyaisan1
    {
        public Marat(string name, bool boss) : base(name, boss) { }
    }
    class Dina : Lyaisan1
    {
        public Dina(string name, bool boss) : base(name, boss) { }
    }
    class Ildar : Lyaisan1
    {
        public Ildar(string name, bool boss) : base(name, boss) { }
    }
    class Anton : Lyaisan1
    {
        public Anton(string name, bool boss) : base(name, boss) { }
    }
    class Ilshat : Volodya1
    {
        public Ilshat(string name, bool boss) : base(name, boss) { }
    }
    public class Ilshat1 : Dev
    {
        public Ilshat1(string name, bool boss) : base(name, boss) { }
    }
    class Ivanich : Ilshat1
    {
        public Ivanich(string name, bool boss) : base(name, boss) { }
    }
    public class Ivanich1 : Dev
    {
        public Ivanich1(string name, bool boss) : base(name, boss) { }
    }
    class Ilya : Ivanich1
    {
        public Ilya(string name, bool boss) : base(name, boss) { }
    }
    class Vitya : Ivanich1
    {
        public Vitya(string name, bool boss) : base(name, boss) { }
    }
    class Jenya : Ivanich1
    {
        public Jenya(string name, bool boss) : base(name, boss) { }
    }
    internal class Program
    {
        static void Answer(string nameBoss, string nameEmployee, List<Dev> list, string zadacha)
        {
            if (list.Find(i => i.Name == nameBoss && i.Boss == true) != null && list.Find(i => i.Name == nameEmployee && i.Boss == false) != null && list.Find(i => i.Name == nameEmployee && i.Boss == false).GetType().IsSubclassOf(list.Find(i => i.Name == nameBoss && i.Boss == true).GetType()))
            {
                Console.WriteLine($"От {nameBoss} дана задача: {zadacha} сотруднику {nameEmployee}. Ответ сотрудника: Да");
            }
            else
            {
                Console.WriteLine($"От {nameBoss} дана задача: {zadacha} сотруднику {nameEmployee}. Ответ сотрудника: Нет");
            }
        }
        static void Main(string[] args)
        {
            Boris boris = new Boris("Борис", true);
            Rashid rashid = new Rashid("Рашид", false);
            OIlham oIlham = new OIlham("О Ильхам", false);
            Rashid1 rashid1 = new Rashid1("Рашид", true);
            Lukas lukas = new Lukas("Лукас", false);
            Lukas1 lukas1 = new Lukas1("Лкуас", true);
            Buh buh = new Buh("Бухгатерия", false);
            OIlham1 oIlham1 = new OIlham1("О Ильхам", true);
            Orcadiy orcadiy = new Orcadiy("Оркадий", false);
            Volodya volodya = new Volodya("Володя", false);
            Orcadiy1 orcadiy1 = new Orcadiy1("Оркадий", true);
            Volodya1 volodya1 = new Volodya1("Володя", true);
            Sergey sergey = new Sergey("Сергей", false);
            Sergey1 sergey1 = new Sergey1("Сергей", true);
            Lyaisan lyaisan = new Lyaisan("Ляйсан", false);
            Lyaisan1 lyaisan1 = new Lyaisan1("Ляйсан", true);
            Marat marat = new Marat("Марат", false);
            Dina dina = new Dina("Дина", false);
            Ildar ildar = new Ildar("Ильдар", false);
            Anton anton = new Anton("Антон", false);
            Ilshat ilshat = new Ilshat("Ильшат", false);
            Ilshat1 ilshat1 = new Ilshat1("Ильшат", true);
            Ivanich ivanich = new Ivanich("Иваныч", false);
            Ivanich1 ivanich1 = new Ivanich1("Иваныч", true);
            Ilya ilya = new Ilya("Илья", false);
            Vitya vitya = new Vitya("Витя", false);
            Jenya jenya = new Jenya("Женя", false);

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Введите название задачи");
                string nameoftask = Console.ReadLine();
                Console.WriteLine("Укажите в какой отдел хотите адресовать задачу");
                string Direction = Console.ReadLine();
                Console.WriteLine("От кого задача");
                string nameBoss = Console.ReadLine();
                Console.WriteLine("Кому задача");
                string nameEmployee = Console.ReadLine();
                switch (Direction)
                {
                    case "Системщики":
                        List<Dev> System = new List<Dev>();
                        System.Add(orcadiy1);
                        System.Add(volodya1);
                        System.Add(ilshat);
                        System.Add(ilshat1);
                        System.Add(ivanich);
                        System.Add(ivanich1);
                        System.Add(ilya);
                        System.Add(vitya);
                        System.Add(jenya);
                        Answer(nameBoss, nameEmployee, System, nameoftask);
                        break;
                    case "Разработчики":
                        List<Dev> Development = new List<Dev>();
                        Development.Add(orcadiy1);
                        Development.Add(volodya1);
                        Development.Add(sergey);
                        Development.Add(sergey1);
                        Development.Add(lyaisan);
                        Development.Add(lyaisan1);
                        Development.Add(marat);
                        Development.Add(dina);
                        Development.Add(ildar);
                        Development.Add(anton);
                        Answer(nameBoss, nameEmployee, Development, nameoftask);
                        break;
                    case "Начальство":
                        List<Dev> Bosses = new List<Dev>();
                        Bosses.Add(boris);
                        Bosses.Add(rashid);
                        Bosses.Add(oIlham);
                        Bosses.Add(oIlham1);
                        Bosses.Add(rashid1);
                        Bosses.Add(lukas);
                        Bosses.Add(orcadiy);
                        Bosses.Add(volodya);
                        Answer(nameBoss, nameEmployee, Bosses, nameoftask);
                        break;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}

int z = 10;
string? p1;
int p2 = 0;
var pp = new List<p>()
{

};
while (z != 0)
{
    Console.WriteLine("Введите одну из цифр:");
    Console.WriteLine("1 --- создать нового работника");
    Console.WriteLine("2 --- нанять работника");
    Console.WriteLine("3 --- уволить работника");
    Console.WriteLine("4 --- изменить должность работника");
    Console.WriteLine("5 --- перевести работника на другое предприятие");
    Console.WriteLine("6 --- изменить зарплату работника");
    Console.WriteLine("7 --- посмотреть список персонала");
    Console.WriteLine("0 --- стоп");
    z = Convert.ToInt16(Console.ReadLine());
    if (z == 1)
    {
        Console.Write("Введите ФИО нового работника: ");
        pp.Add(new p{fio = Console.ReadLine()});
        Console.WriteLine(pp[pp.Count() - 1].fio + " успешно создан!");
    }
    else if (z == 2)
    {
        Console.WriteLine("Список свободных людей:");
        for (int i = 0; i < pp.Count(); i++)
        {
            if (pp[i].company == "")
            {
                Console.WriteLine(pp[i].fio);
            }
        }
        Console.Write("Введите ФИО человека, которого вы хотите нанять на работу: ");

        p1 = Console.ReadLine();
        for (int i = 0; i <= pp.Count() - 1; i++)
        {
            if (pp[i].fio == p1)
            {
                p2 = i;
            }
        }
        Console.Write("Введите название предприятия, в которое вы хотите нанять работника: ");
        pp[p2].company = Console.ReadLine();
        Console.Write("Введите название должности, на которую вы хотите нанять работника: ");
        pp[p2].work = Console.ReadLine();
        Console.Write("Введите зарплату, на которую вы хотите нанять работника: ");
        pp[p2].zp = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(p1 + " успешно принят на работу в " + pp[p2].company + "!");
    }
    else if (z == 3)
    {
        Console.Write("Введите название предприятия, из которого вы хотите уволить работника: ");
        p1 = Console.ReadLine();
        Console.WriteLine("Список персонала, работающего на данном предприятии:");
        for (int i = 0; i < pp.Count() - 1; i++)
        {
            if (pp[i].company == p1)
            {
                Console.WriteLine(pp[i].fio);
            }
        }
        Console.WriteLine("Введите ФИО работника, которого хотите уволить");
        p1 = Console.ReadLine();
        for (int i = 0; i < pp.Count(); i++)
        {
            if (pp[i].fio == p1)
            {
                p2 = i;
            }
        }
        pp.RemoveAt(p2);
        Console.WriteLine(p1 + " успешно уволен!");
    }
    else if (z == 4)
    {
        Console.Write("Введите название предприятия, в котором работает человек, которого вы хотите перевести на другую должность: ");
        p1 = Console.ReadLine();
        Console.WriteLine("Список персонала, работающего на данном предприятии:");
        for (int i = 0; i < pp.Count() - 1; i++)
        {
            if (pp[i].company == p1)
            {
                Console.WriteLine(pp[i].fio);
            }
        }
        Console.WriteLine("Введите ФИО работника, которого вы хотите перевести на другую должность: ");
        p1 = Console.ReadLine();
        for (int i = 0; i < pp.Count(); i++)
        {
            if (pp[i].fio == p1)
            {
                p2 = i;
            }
        }
        Console.WriteLine("Введите название должности, на которую вы хотите перевести работника: ");
        pp[p2].work = Console.ReadLine();
        Console.WriteLine("Введите новую зарплату работника: ");
        pp[p2].zp = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(p1 + "успешно переведён на должность " + pp[p2].work + '!');
    }
    else if (z == 5)
    {
        Console.WriteLine("Введите название предприятия, на котором сейчас рабатает человек, которого вы хотите перевести на другое предприятие: ");
        p1 = Console.ReadLine();
        Console.WriteLine("Список персонала, работающего на данном предприятии:");
        for (int i = 0; i < pp.Count() - 1; i++)
        {
            if (pp[i].company == p1)
            {
                Console.WriteLine(pp[i].fio);
            }
        }
        Console.WriteLine("Введите ФИО работника, которого вы хотите перевести на другое предприятие: ");
        p1 = Console.ReadLine();
        for (int i = 0; i < pp.Count(); i++)
        {
            if (pp[i].fio == p1)
            {
                p2 = i;
            }
        }
        Console.WriteLine("Введите название предприятия, на которое вы хотите перевести работника: ");
        pp[p2].company = Console.ReadLine();
        Console.WriteLine("Введите новую зарплату работника: ");
        pp[p2].zp = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(p1 + "успешно переведён на предприятие " + pp[p2].work + '!');
    }
    else if (z == 6)
    {
        Console.WriteLine("Введите название предприятия, на котором рабатает человек, которому вы хотите изменить зарплату: ");
        p1 = Console.ReadLine();
        Console.WriteLine("Список персонала, работающего на данном предприятии:");
        for (int i = 0; i < pp.Count() - 1; i++)
        {
            if (pp[i].company == p1)
            {
                Console.WriteLine(pp[i].fio);
            }
        }
        Console.WriteLine("Введите ФИО работника, которому вы хотите изменить зарплату: ");
        p1 = Console.ReadLine();
        for (int i = 0; i < pp.Count(); i++)
        {
            if (pp[i].fio == p1)
            {
                p2 = i;
            }
        }
        Console.WriteLine("Введите новую зарплату работника: ");
        pp[p2].zp = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Зарплата успешно изменена!");
    }
    else if (z == 7)
    {
        Console.WriteLine("Список персонала:");
        for (int i = 0; i <= pp.Count() - 1; i++)
        {
            if (pp[i].zp != 0)
            {
                Console.Write(pp[i].fio + " ");
                Console.Write(pp[i].company + " ");
                Console.Write(pp[i].work + " ");
                Console.WriteLine(pp[i].zp);
            }
        }
    }
    else
    {
        if (z != 0)
        {
            Console.WriteLine("Ошибка 404");
        }
    }
}
class p
{
    public string? fio = "";
    public string? company = "";
    public string? work = "";
    public int zp = 0;
}

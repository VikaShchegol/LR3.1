using System;

class Parent
{
    protected int pole1;

    public Parent(int functions)
    {
        pole1 = functions;
    }

    public void Print()
    {
        Console.WriteLine("Кiлькiсть функцiй: " + pole1);
    }

    public double Metod()
    {
        return pole1 * 100;
    }
}

class Child1 : Parent
{
    private int pole2;

    public Child1(int functions, int year) : base(functions)
    {
        pole2 = year;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine("Рiк виробництва: " + pole2);
    }

    public new double Metod()
    {
        if (DateTime.Now.Year - pole2 < 2)
            return base.Metod() * 1.2;
        else if (DateTime.Now.Year - pole2 > 3)
            return base.Metod() * 0.4;
        else
            return base.Metod();
    }
}

class Child2 : Parent
{
    private string pole3;

    public Child2(int functions, string mobile) : base(functions)
    {
        pole3 = mobile;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine("Мобiльнiсть: " + (pole3 == "переносний" ? "переносний" : "не переносний"));
    }

    public new double Metod()
    {
        if (pole3 == "переносний")
            return base.Metod() * 1.01;
        else
            return base.Metod() * 0.97;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parent parent = new Parent(50);
        parent.Print();
        Console.WriteLine("Телефон: " + parent.Metod() + "\n");

        Child1 child1_1 = new Child1(50, 2020);
        child1_1.Print();
        Console.WriteLine("Мобiльний: " + child1_1.Metod() + "\n");

        Child1 child1_2 = new Child1(50, 2010);
        child1_2.Print();
        Console.WriteLine("Мобiльний: " + child1_2.Metod() + "\n");

        Child2 child2_1 = new Child2(20, "переносний");
        child2_1.Print();
        Console.WriteLine("Стацiонарний: " + child2_1.Metod() + "\n");

        Child2 child2_2 = new Child2(20, "не переносний");
        child2_2.Print();
        Console.WriteLine("Стацiонарний: " + child2_2.Metod());
    }
}






Person p = new Person("Test", 1234);
p.Year = 1;
Console.WriteLine(p.Name + p.Year);

class Person
{
    private string name; // поле
    public string Name // свойство
    {
        get // геттер
        {
            return name + " get";
        }
        set // сеттер
        {
            name = value + " set";
        }
    }

    public int Year { get; set; }

    public Person(string name, int year)
    {
        Name = name;
        Year = year;
    }
}

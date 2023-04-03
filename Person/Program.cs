
public class Person 
{
    private int Id;
    private string PasportID;
    private string Name;
    private string Surname;
    private string PhoneNumber;
    private string Sex;
    private string Address;
    private string BD;

    public Person(int id, string pasportID, string name, string surname, string phoneNumber, string sex, string address, string bD)
    {
        Id = id;
        PasportID = pasportID;
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
        Sex = sex;
        Address = address;
        BD = bD;
    }

    public void info() 
    {
        Console.WriteLine($"Дані про персону:");
        Console.WriteLine($"ID: {Id},");
        Console.WriteLine($"Ідентифікаційний код: {PasportID},");
        Console.WriteLine($"Ім'я: {Name},");
        Console.WriteLine($"Прізвище: {Surname},");
        Console.WriteLine($"Номер телефону: {PhoneNumber},");
        Console.WriteLine($"Стать: {Sex},");
        Console.WriteLine($"Email: {Address},");
        Console.WriteLine($"Дата народження: {BD},");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Person p1 = new Person(0,"12413551361","Дарина","Ковальчук","+380999999999","Жіноча","koval@gmail.com","28.09.2006");
        Person p2 = new Person(1, "12413554661", "Андрій", "Чепишко", "+38088888888", "Чоловіча", "chep@gmail.com", "09.12.2006");
        Person p3 = new Person(2, "12413554761", "Аня", "Якобчук", "+3807777777777", "Жіноча", "annushka@gmail.com", "24.12.2006");
        p1.info();
        Console.WriteLine();
        p2.info();
        Console.WriteLine();
        p3.info();
        Console.WriteLine();
    }
}
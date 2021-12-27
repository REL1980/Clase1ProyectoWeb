public class User
{
    public string Name { get; set; }

    public string Surname{ get;set; }

    public int AnioNacimiento { get; set; }

    public User()
    {
        
    }
    public User(string name,string surname,int anio)
    {
        Name = name;
        Surname = surname;
        AnioNacimiento = anio;
        
    }
    public string Fullname()
    {
        return $"{Name} {Surname}";
    }

    public int Age()
    {
        return 2021-AnioNacimiento;
    }


}
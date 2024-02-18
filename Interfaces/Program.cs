// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//inteface new'lenmez
//interfaceler onu impelemente eden classın  referansını tutar
//IPersonManager customerManager = new CustomerManager();

//IPersonManager employeeManager = new EmployeeManager();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new InternManager());

interface IPersonManager
{
    //unimplement operation
    void Add();
    void Update();
    
}

//inherits - class ------------------implements - interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekeleme kodları
        Console.WriteLine("müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("müşteri güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //personel ekleme kodları
        Console.WriteLine("personel eklendi");
    }

    public void Update()
    {
        Console.WriteLine("personel güncellendi"); ;
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("stajyer eklendi"); ;
    }

    public void Update()
    {
        Console.WriteLine("stajyer güncellendi");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }

    
} 

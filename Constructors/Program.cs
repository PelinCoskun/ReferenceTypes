// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer customer1 = new Customer() { Id=1,FirstName="Pelin",LastName="Coşkun",City="İstanbul"};
Customer customer3 = new Customer();

Customer customer2 = new Customer(2, "Çado", "Pekto", "İstanbul");

Console.WriteLine(customer2.FirstName);
class Customer
{
    public Customer()
    {
        
    }
    //default ctor
    public Customer(int id, string firstName, string lastName,string city)
    {
        Id= id;
        FirstName= firstName;
        LastName= lastName;
        City= city;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//int,decimal,floatenum,boolean,value types
//int sayi1 = 10;
//int sayi2 = 20;
//sayi1 = sayi2;
//sayi2 = 100;
//Console.WriteLine("Sayı1:" + sayi1);

//int[] sayilar1 = new int[] {1,2,3};
//int[] sayilar2= new int[] {10,20,30};

//sayilar1=sayilar2;
//sayilar2[0] = 1000;
//Console.WriteLine("Sayılar1[0]:" + sayilar1[0]);


Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Pelin";

person2 = person1;
person1.FirstName = "Ece";

//Console.WriteLine( person2.FirstName);


Customer customer = new Customer();
customer.FirstName = "İzel";
customer.CreditCardNumber = "21215454123";

Employee employee = new Employee();
employee.FirstName = "Ali";

Person person3 = customer;
customer.FirstName = "Çado";

//Console.WriteLine(((Customer)person3).CreditCardNumber);

PersonManager manager = new PersonManager();
manager.Add(customer);

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer:Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//int,decimal,floatenum,boolean,value types
int sayi1 = 10;
int sayi2 = 20;
sayi1 = sayi2;
sayi2 = 100;
Console.WriteLine("Sayı1:" + sayi1);

int[] sayilar1 = new int[] {1,2,3};
int[] sayilar2= new int[] {10,20,30};

sayilar1=sayilar2;
sayilar2[0] = 1000;
Console.WriteLine("Sayılar1[0]:" + sayilar1[0]);


Person person = new Person();

Customer customer = new Customer();
Employee employee = new Employee();
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}


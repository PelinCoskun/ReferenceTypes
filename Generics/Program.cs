// See https://aka.ms/new-console-template for more information

List<string> sehirler=new List<string>();
sehirler.Add("İstanbul");
Console.WriteLine(sehirler.Count);

MyList<string> sehirler2= new MyList<string>();
sehirler2.Add("İstanbul");
Console.WriteLine(sehirler2.Count);

class MyList<T>//GENERİC CLASS
{
    T[] _array;
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _array=new T[_array.Length+1];
    }


    public int Count
    {
        get { return _array.Length; }
    }

}

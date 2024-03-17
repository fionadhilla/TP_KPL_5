using System;
public class HaloGeneric
{
    public void SapaUser<x>(x nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yagn tersimpan adalah: {0}", data);
    }
}

class program
{
    static void Main(string[] args)
    {
        HaloGeneric generic_1302220002 = new HaloGeneric();
        generic_1302220002.SapaUser("Praktikan 1302220002");

        string nim = "1302220002";
        DataGeneric<String> data = new DataGeneric<string>(nim);
        data.PrintData();
    }

    
}

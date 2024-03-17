using System;
public class HaloGeneric
{
    public void SapaUser<x>(x nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

class program
{
    static void Main(string[] args)
    {
        HaloGeneric generic_1302220002 = new HaloGeneric();
        generic_1302220002.SapaUser("Praktikan 1302220002");
    }
}

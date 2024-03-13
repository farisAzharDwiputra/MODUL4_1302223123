// See https://aka.ms/new-console-template for more information

class program
{
    static void Main()
    {
        KodeBuah variableBuah = new KodeBuah();
        Console.Write("Masukan Nama buah Yang kamu cari : ");
        string inputbuah = Console.ReadLine();
        Console.WriteLine(variableBuah.GetKodeBuah(inputbuah));
    }
}
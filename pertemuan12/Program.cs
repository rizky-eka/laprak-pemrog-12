namespace pertemuan12;
class Program
{
    static void Main(string[] args)
    {
        string[] arrNo = { "1.", "2.", "3." };
        string[] arrNim = { "1234", "1235", "1235" };
        string[] arrMhs = { "erick", "wely", "sony" };
        int[] arrNilai = { 75, 80, 95 };

        Console.WriteLine("No.\tNIM\tNama\tNilai");
        Console.WriteLine("===========================");

        //menampilkan semua elemen
        for (int i = 0; i < arrMhs.Length; i++)
        {
            Console.WriteLine($"{arrNo[i]}\t{arrNim[i]}\t{arrMhs[i]}\t{arrNilai[i]}");
        }

        Console.ReadKey();
    }
}


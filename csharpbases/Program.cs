

using csharpbases;

internal class Program
{
    private static void Main(string[] args)
    {
        funkione_me_array_dhe_lista instanca = new funkione_me_array_dhe_lista();

        Console.WriteLine("Ju lutem jepni nje array me int :");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        // Kemi mbushur arrayn me elemente 
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Jepnieleintin ne pozicionin i" + i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int shuma = instanca.GjejShumenEArray(array);
        int meIMadhi = instanca.GjejMeTeMadhin(array);
        int shumaCift = instanca.GjejShumeNrCift(array);

        Console.WriteLine("Shuma :" + shuma);
        Console.WriteLine("Me i Madhi :" + meIMadhi);
        Console.WriteLine("Gjej Shumen nr Cift " + shumaCift);
    }
}



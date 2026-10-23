namespace AS2627._3F.MarioBuononato.Fratelli;

class Program
{
    static void Main(string[] args)
    {
        int fr1,fr2,fr3;
        int diff,max,min;
        Console.WriteLine("Inserisci l'età del fratello 1: ");
        fr1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci l'età del fratello 2: ");
        fr2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci l'età del fratello 3: ");
        fr3=Convert.ToInt32(Console.ReadLine());
        min=fr1;
        max=fr1;
        if(fr2>max) max=fr2;
        if(fr2<min) min=fr2;
        if(fr3>max) max=fr3;
        if(fr3<min) min=fr3;
        diff=max-min;
        Console.WriteLine($"I fratelli maggiore/minore hanno {max}/{min}");
        Console.WriteLine($"e hanno {diff} anni di differenza");
    }
}

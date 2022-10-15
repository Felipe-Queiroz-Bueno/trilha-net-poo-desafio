using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// DONE
class Program
{
    public static void Main(string[] args)
    {
        Nokia nk123 = new Nokia("000145", "NK123", "305460516516051651", 256);
        nk123.InstalarAplicativo("WhatsApp");
    }
}
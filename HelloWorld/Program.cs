namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Koodi tähän
          
  List<string> autolista = new List<string>();
            int kierrokset = 1;

            Console.WriteLine("Lisää listalle viisi automerkkiä");

            while (true)
            {
                autolista.Add(Console.ReadLine());
                if (kierrokset == 5)
                {
                    break;
                }
                kierrokset++;
            }
            Console.WriteLine("\nsyötit listalle 5 merkkiä, tässä lista:");
            Console.WriteLine(autolista[0]);
            Console.WriteLine(autolista[1]);
            Console.WriteLine(autolista[2]);
            Console.WriteLine(autolista[3]);
            Console.WriteLine(autolista[4]);
        }
    }
}

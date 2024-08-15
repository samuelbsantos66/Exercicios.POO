namespace ConsoleAula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            float A = 0;
            float B = 0;
            float C = 0;
            float D = 0;
            float E = 0;

            float pA = 0;
            float pB = 0;
            float pC = 0;
            float pD = 0;
            float pE = 0;

            do
            {
            Console.WriteLine("Escreva sua idade!");
            idade = Int32.Parse(Console.ReadLine());
                if (idade > 0)
                {
                    if (1 <= idade && idade <= 15) A++;
                    else if (16 <= idade && idade <= 30) B++;
                    else if (31 <= idade && idade <= 45) C++;
                    else if (46 <= idade && idade <= 60) D++;
                    else if (idade >= 61) E++;
                }
                else break;
            }
            while (idade > 0);

            pA = A * 100 / (A + B + C + D + E);
            pB = B * 100 / (A + B + C + D + E);
            pC = C * 100 / (A + B + C + D + E);
            pD = D * 100 / (A + B + C + D + E);
            pE = E * 100 / (A + B + C + D + E);

            Console.WriteLine($"A: {pA}%\n");
            Console.WriteLine($"B: {pB}%\n");
            Console.WriteLine($"C: {pC}%\n");
            Console.WriteLine($"D: {pD}%\n");
            Console.WriteLine($"E: {pE}%\n");


        }
    }
}

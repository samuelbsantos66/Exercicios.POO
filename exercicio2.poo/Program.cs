namespace exercicio2.poo
{
    internal class Program
    {   
        
        static void Main(string[] args)
        {
            float t;
            int op;
            
            double ctof(float c)
            { double f = c * 1.8 + 32;

                return f;
            }
            double ftoc(float f)
            {
                double c = (f - 32)/1.8;

                return c;
            }
            double ctok(float c)
            {
                double k = c + 273.15;

                return k;
            }
            double ktoc(float k)
            {
                double c = k - 273.15 ;

                return c;
            }
            
            Console.WriteLine("0: c para f\n");
            Console.WriteLine("1: f para c\n");
            Console.WriteLine("2: c para k\n");
            Console.WriteLine("3: k para c\n");
            Console.WriteLine("Digite a opção desejada:\n");
            op = int.Parse(Console.ReadLine());
            switch(op){
                case 0:
                    Console.WriteLine("Digite a temperatura\n");
                    t = float.Parse(Console.ReadLine());
                    Console.WriteLine($" Convertendo o resultado será {ctof(t)}°F");
                    break;
                case 1:
                    Console.WriteLine("Digite a temperatura\n");
                    t = float.Parse(Console.ReadLine());
                    Console.WriteLine($" Convertendo o resultado será {ftoc(t)}°C");
                    break;
                case 2:
                    Console.WriteLine("Digite a temperatura\n");
                    t = float.Parse(Console.ReadLine());
                    Console.WriteLine($" Convertendo o resultado será {ctok(t)}K");
                    break;
                case 3:
                    Console.WriteLine("Digite a temperatura\n");
                    t = float.Parse(Console.ReadLine());
                    Console.WriteLine($" Convertendo o resultado será {ktoc(t)}°C");
                    break;
            }


        }
    }
}

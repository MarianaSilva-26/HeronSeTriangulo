using System;

namespace HeronSeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
        double ladoA, ladoB, ladoC, resultadoP, resultadoA;
        double bc, ac, ab;
        bool aValido, bValido, cValido;
        bool operação1 = false, operação2 = false, operação3 = false;
        string sair;

            
        {
            Console.Clear();

            Console.Write("Digite o Valor de A: ");
            aValido = double.TryParse(Console.ReadLine(), out ladoA);

        if (!aValido)
        {
            Console.WriteLine();
            Console.WriteLine("Você digitou um valor invalido!");
            Console.WriteLine("Pressione Enter para sair, e execute novamente");
            Console.ReadKey();
            Environment.Exit(-1);
        }

            Console.Write("Digite o Valor de B: ");
            bValido = double.TryParse(Console.ReadLine(), out ladoB);

        if (!bValido)
        {
            Console.WriteLine();
            Console.WriteLine("Você digitou um valor invalido!");
            Console.WriteLine("Pressione Enter para sair, e execute novamente");
            Console.ReadKey();
            Environment.Exit(-1);
        }

            Console.Write("Digite o Valor de C: ");
            cValido = double.TryParse(Console.ReadLine(), out ladoC);

        if (!cValido)
        {
            Console.WriteLine();
            Console.WriteLine("Você digitou um valor invalido!");
            Console.WriteLine("Pressione Enter para sair, e execute novamente");
            Console.ReadKey();
            Environment.Exit(-1);
        }
            Console.WriteLine();

            bc = Math.Abs(ladoB - ladoC);
            ac = Math.Abs(ladoA - ladoC);
            ab = Math.Abs(ladoA - ladoB);

        if (ab < ladoC && ladoC < ladoA + ladoB)
        {
            operação1 = true;
        }

        if (ac < ladoB && ladoB < ladoA + ladoC)
        {
            operação2 = true;
        }

        if (bc < ladoA && ladoA < ladoB + ladoC)
        {
            operação3 = true;
        }

        if (operação1 && operação2 && operação3)
        {
            resultadoP = (ladoA + ladoB + ladoC) / 2;
            resultadoA = Math.Sqrt(resultadoP * (resultadoP - ladoA) * (resultadoP - ladoB) * (resultadoP - ladoC));

            Console.WriteLine("Semiperímetro = {0}", resultadoP);
            Console.WriteLine("Area = {0}(cm²)", resultadoA);
            Console.WriteLine();

            Console.Write("Seu tipo do triangulo é: ");
        if (ladoA == ladoB && ladoB == ladoC)
        {
            Console.WriteLine("Equilátero");
            DrawEquilatero();
        }
        else if (ladoA != ladoB && ladoB != ladoC)
        {
            Console.WriteLine("Escaleno");
            DrawEscaleno();

        }
        }
        else
        {
            resultadoP = (ladoA + ladoB + ladoC) / 2;
            resultadoA = Math.Sqrt(resultadoP * (resultadoP - ladoA) * (resultadoP - ladoB) * (resultadoP - ladoC));

            Console.WriteLine("Semiperímetro = {0}", resultadoP);
            Console.WriteLine("Area = {0}(cm²)", resultadoA);

            Console.WriteLine("Isósceles");
            DrawIsosceles();
        }

            Console.Write("Deseja Sair? S/N: ");
            sair = Console.ReadLine().ToUpper();
        }
        while (sair != "S" && sair != "SIM");
        }
        static void DrawEquilatero()
        {
            Console.WriteLine();
            Console.WriteLine("\t      /*\\");
            Console.WriteLine("\t     /***\\");
            Console.WriteLine("\t    /*****\\");
            Console.WriteLine("\t   /*******\\");
            Console.WriteLine("\t  /*********\\");
            Console.WriteLine("\t /***********\\");
            Console.WriteLine("\t/-------------\\");
            Console.WriteLine();
        }
        static void DrawEscaleno()
        {
            Console.WriteLine();
            Console.WriteLine("\t*");
            Console.WriteLine("\t***");
            Console.WriteLine("\t*****");
            Console.WriteLine("\t*******");
            Console.WriteLine("\t*********");
            Console.WriteLine("\t***********");
            Console.WriteLine("\t*************");
        }

        static void DrawIsosceles()
        {
            Console.WriteLine();
            Console.WriteLine("\t***");
            Console.WriteLine("\t*****");
            Console.WriteLine("\t*******");
            Console.WriteLine("\t*********");
            Console.WriteLine("\t***********");
            Console.WriteLine("\t************");
            Console.WriteLine("\t**************"); 
            
        }
    }
}

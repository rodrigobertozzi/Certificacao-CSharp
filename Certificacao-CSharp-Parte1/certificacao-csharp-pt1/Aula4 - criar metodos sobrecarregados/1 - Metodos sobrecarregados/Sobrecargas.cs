using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            // Volume do cubo = lado ^3;
            int lado = 3;
            Console.WriteLine("Volume do cubo: " + Volume(lado));

            // Volume do cilindro = altura * PI * raio ^2;
            double raio = 2;
            int altura = 10;
            Console.WriteLine("Volume do cilindro: " + Volume(altura, raio));

            // Volume do prisma = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine("Volume do prisma: " + Volume(largura, profundidade, altura));

        }

        double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        double Volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
    }
}

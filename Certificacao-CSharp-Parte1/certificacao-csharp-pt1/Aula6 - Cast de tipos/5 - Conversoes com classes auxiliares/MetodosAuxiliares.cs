using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosAuxiliares :IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";
            //int numeroConvertido = textoDigitado;
            int numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine(numeroConvertido);

            textoDigitado = "abc";
            //numeroConvertido = int.Parse(textoDigitado);
            int.TryParse(textoDigitado, out numeroConvertido);

            if(int.TryParse(textoDigitado, out numeroConvertido))
            {
                Console.WriteLine(numeroConvertido);
            }
            else
            {
                Console.WriteLine("Texto não é um numero");
            }

            textoDigitado = "R$ 123,45";
            decimal.TryParse(textoDigitado,
                System.Globalization.NumberStyles.Currency, //moeda
                System.Globalization.CultureInfo.CurrentCulture, //pt-br
                out  decimal valorConvertido);
            Console.WriteLine(valorConvertido);
            
        }
    }
}

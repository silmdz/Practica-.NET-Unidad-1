using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1Mendez
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            string apellido = "";
            string edad = "";

            Console.WriteLine("Hola, escribe tu Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Dime tu edad");
            edad = Console.ReadLine();
            Console.WriteLine("La persona: "+nombre+" "+apellido+" tiene "+edad+" años"+Environment.NewLine);

            bool tipoBool = true;
            byte tipoByte =30 ;
            char tipoChar ='F';
            decimal tipoDecimal= 300.5m;
            double tipoDouble= 1245.52;
            float tipoFloat = -1.5f;
            int tipoInt = 3324;
            long tipoLong = 309817453442;
            short tipoShort = 10;
            string tipoString = "Tipos de variables";

            Console.WriteLine(tipoString+ Environment.NewLine + "Bool: "  +tipoBool + Environment.NewLine + "Byte: " + tipoByte
                + Environment.NewLine + "Char: " + tipoChar +Environment.NewLine+"Decimal: "+tipoDecimal+Environment.NewLine+
                "Double: "+tipoDouble+Environment.NewLine+"Float: "+tipoFloat+Environment.NewLine+"Int: "+tipoInt+
                Environment.NewLine+"Long: "+tipoLong+Environment.NewLine+"Short: "+tipoShort);
              ;
        }
    } 
}

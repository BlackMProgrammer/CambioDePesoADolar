using System;

namespace CambioDePesoADolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte Un numero para convertir a Dolar");
            string valor = Console.ReadLine();
            int pesoDom = Convert.ToInt32(valor);

            Console.WriteLine("El numero que Ingreso fue: {0}", pesoDom);

            Console.WriteLine("El Dolar esta a RD$ 58.50 ");

            Console.WriteLine("Su monto en dolares es de {0}", pesoDom * 58.50);
        }
    }
}

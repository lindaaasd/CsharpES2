using System;

namespace Week2.GestioneCopisteria
{
    /**
     * Commento documentazione su più righe
     */
    internal class Program
    {

        static void Main(string[] args)
        {
            bool continua;
            do
            {
                continua = GestoreCopisteria.Menu();
            } while (continua);
        }
    }
}

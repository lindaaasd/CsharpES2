using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.Demo
{
    /// <summary>
    /// Classe che implementa la serie dei numeri di Fibonacci 
    /// </summary>
    internal class Fibonacci
    {
        #region ITERAZIONE VS RISCORSIONE
        //0..1..1..2..3..5..8..13..

        /// <summary>
        /// Calcolo della serie di Fibonacci in maniera iterativa
        /// </summary>
        /// <param name="n">n è l'n-esimo numero della serie</param>
        /// <returns>Restituisce l'intero che rappresenta l'n-esimo numero della serie</returns>
        public static int FibonacciIterativo(int n)
        {
            int primoNumeroSerie = 0;
            int secondoNumeroSerie = 1;
            int risultato = 0;

            if(n == 0)
            {
                return primoNumeroSerie;
            }
            if(n == 1)
            {
                return secondoNumeroSerie;
            }
            for(int i = 2; i <= n; i++)
            {
                risultato = primoNumeroSerie + secondoNumeroSerie;
                primoNumeroSerie = secondoNumeroSerie;
                secondoNumeroSerie = risultato;
            }
            return risultato;
        }
        /// <summary>
        /// Calcolo di Fibonacci ricorsivo
        /// </summary>
        /// <param name="n">n è il numero della serie da calcolare</param>
        /// <returns>Ritorna l'n-esino numero della serie di Fibonacci</returns>
        public static int FibonacciRicorsivo(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }
            return FibonacciRicorsivo(n - 1) + FibonacciRicorsivo(n - 2);
        }


        #endregion

    }
}

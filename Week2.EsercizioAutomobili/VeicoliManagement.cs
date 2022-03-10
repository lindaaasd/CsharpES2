using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Week2.EsercizioAutomobili.Entities;

namespace Week2.EsercizioAutomobili
{
    internal static class VeicoliManagement
    {
        internal static Veicolo InserisciVeicolo()
        {
            Veicolo veicolo = new Veicolo();

            bool success;
            Console.WriteLine("Inserisci marca");
            veicolo.Targa = Console.ReadLine();
            Console.WriteLine("Inserisci i Kilowatt");
            veicolo.Kilowatt = VerificaInputIntero();
            Console.WriteLine("Inserisci anno di immatricolazione");
            veicolo.AnnoImmatricolazione = VerificaInputIntero();
            Console.WriteLine("Inserisci prezzo d'acquisto");
            success = Double.TryParse(Console.ReadLine(), out double costo);

            while (!success)
            {
                Console.WriteLine("Inserisci costo");
                success = Double.TryParse(Console.ReadLine(), out costo);
            }
            veicolo.PrezzoAcquisto = costo;
            Console.WriteLine("Inserisci tipologia");
            string tipo = Console.ReadLine();
            veicolo.Tipologia = tipo;

            return veicolo;
        }

        public static int VerificaInputIntero()
        {
            bool success = Int32.TryParse(Console.ReadLine(), out int value);
            while (!success)
            {
                Console.WriteLine("Inserisci un valore corretto");
                success = Int32.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }

        public static void StampaVeicolo(Veicolo veicolo)
        {
            Console.WriteLine(veicolo);
        }

        public static void StampaVeicoli(ArrayList veicoli)
        {
            foreach(Veicolo veicolo in veicoli)
            {
                StampaVeicolo(veicolo);
            }
        }

        public static void EliminaVeicolo(ArrayList veicoli)
        {
            //Cerco il veciolo da eliminare scrivendo la targa
            Veicolo veicoloDaCancellare = CercaVeicolo(veicoli);
            if(veicoloDaCancellare != null)
            {
                veicoli.Remove(veicoloDaCancellare);
                Console.WriteLine("Cancellazione avvenuta con successo");
            } else
            {
                Console.WriteLine("Veicolo non trovato");
            }
        }

        public static Veicolo CercaVeicolo(ArrayList veicoli)
        {
            Console.Write("Inserisci targa: ");
            string targa = Console.ReadLine(); 
            
            foreach(Veicolo veicolo in veicoli)
            {
                //if(veicolo.Targa == targa)
                if (veicolo.Targa.Equals(targa))
                {
                    return veicolo; //non appena verifico quel veicolo con la targa lo restituisco
                }

            }
            return null;
        }
    }
}

using System;
using System.Collections;
using Week2.Demo.Bollette.Entities;

namespace Week2.Demo.Bollette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utente utente = new Utente()
            //{
            //    Codice = "ABCD123",
            //    Nome = "Mario",
            //    Cognome = "Rossi",
            //    DataNascita = new DateTime(1999, 4, 6)
            //};
            //Bolletta bolletta = new Bolletta()
            //{
            //    ConsumoTotale = 200,
            //    TipoBolletta = "Telefono",
            //    UnitaDiMisura = "Minuti",
            //    DataScadenza = new DateTime(2022, 3, 9),
            //    UtenteBolletta = utente
            //};
            ////Console.WriteLine("Consumo totale: " + bolletta.ConsumoTotale 
            ////    + " - Importo: " + bolletta.Importo + "euro");
            //Console.WriteLine(bolletta);
            Console.WriteLine("Inserisci codice");
            string codice = Console.ReadLine();
            Console.WriteLine("Inserisci nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci data di nascita (dd/MM/yyyy)");
            DateTime.TryParse(Console.ReadLine(), out DateTime dataNascita);
            Utente utente = new Utente()
            {
                Codice = codice,
                Nome = nome,
                Cognome = cognome,
                DataNascita = dataNascita
            };
            Utente[] utenti = new Utente[] { utente };
            ArrayList tantiUtenti = new ArrayList();
            tantiUtenti.Add(utente);
        }
    }
}

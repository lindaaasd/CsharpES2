using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Week2.Demo
{
    internal static class GestioneIO
    {
        public static void StampaPersoneSuFile(ArrayList persone)
        {
            //Mi faccio restituire il percorso desktop con il file persone.txt
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "persone.txt");
            using(StreamWriter sw = File.CreateText(path))
            { 
                foreach(Persona personaDaStampareSuFile in persone)
                {
                    //sw.WriteLine($"Nome: {personaDaStampareSuFile.Nome} - ");
                    sw.WriteLine(personaDaStampareSuFile);
                }
            }
        }

        public static ArrayList CaricaPersoneDaFile()
        {
            ArrayList personeCaricateDaFile = new ArrayList();
            //carichiamo i valori a partire dal file
            //specifico il path del file da cui leggere
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "persone.txt");
            string line; //stringa che conterrà la linea che leggo da file
            //apro il flusso di lettura
            //ATTENZIONE: se il file non esiste non viene creato e il programma si interrompe
            using(StreamReader sr = File.OpenText(path))
            {
                line = sr.ReadLine();
                while(line != null) //finchè c'è qualcosa da leggere nel file vado avanti
                {
                    string[] valoriPersona = line.Split('-');
                    string nome = valoriPersona[0];
                    string nomeCorretto = nome.Substring(6);
                    string dataCorretta = valoriPersona[1].Substring(18);
                    DateTime.TryParse(valoriPersona[1], out DateTime dataNascita);
                    Persona p = new Persona()
                    {
                        Nome = nome,
                        DataNascita = dataNascita
                    };
                    personeCaricateDaFile.Add(p);
                    line = sr.ReadLine();
                }
            }

            return personeCaricateDaFile;
        }

    }
}

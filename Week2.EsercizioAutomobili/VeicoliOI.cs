using System;
using System.Collections;
using System.IO;

namespace Week2.EsercizioAutomobili
{
	internal static class VeicoliOI
	{
        public static void StampaVeicoliSuFile(ArrayList listaVeicoli)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "veicoli.txt");
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (var veicoloDaStampareSuFile in listaVeicoli)
                {
                    //sw.WriteLine($"Nome: {veicoloDaStampareSuFile.Nome} - ");
                    sw.WriteLine(veicoloDaStampareSuFile);
                }
            }
        }

        public static ArrayList CaricaVeicoliDaFile()
        {
            ArrayList veicoliCaricatiDaFile = new ArrayList();
          
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "veicoli.txt");
            string line; 
            using (StreamReader sr = File.OpenText(path))
            {
                line = sr.ReadLine();
                while (line != null) 
                {
                    string[] valoriVeicolo = line.Split('-');
                    string targa = valoriVeicolo[0];
                    Int32.TryParse(valoriVeicolo[1], out int kilowatt);

                    Entities.Veicolo v = new Entities.Veicolo()
                    {
                        Targa = targa,
                        Kilowatt = kilowatt
                    };
                    veicoliCaricatiDaFile.Add(v);
                    line = sr.ReadLine();
                }
            }

            return veicoliCaricatiDaFile;
        }
    }
}


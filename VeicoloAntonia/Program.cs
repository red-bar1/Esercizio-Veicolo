using System;
using System.Collections;

namespace VeicoloAntonia
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList veicoli = new ArrayList();
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();

                switch(scelta)
                {
                    case 1:
                        Veicolo veicoloDaAggiungere = VeicoliManagment.InserisciVeicolo();
                        veicoli.Add(veicoloDaAggiungere);
                        break;
                    case 2:
                        VeicoliManagment.StampaVeicoli(veicoli);
                        break;
                    case 3:
                        Veicolo veicoloDaCancellare = VeicoliManagment.CercaVeicolo(veicoli);
                        try
                        {
                            veicoli.Remove(veicoloDaCancellare);
                        }catch (Exception)
                        {
                            Console.WriteLine("Veicolo non trovato");
                        }
                        break;
                    case 4:
                        GestioneIO.StampaSuFile(veicoli);
                        break;
                    case 0: //caso dell'eccezione
                        break;
                    default: //se inserisce il 5
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                }

            }
        }

        private static int SchermoMenu()
        {
            Console.WriteLine("1. Aggiungi Veicolo\n2. Stampa veicoli\n" +
                       "3. Elimina veicolo\n4. Stampa Dettagli\n 5. Esci");
            int scelta = 0; //quando ho il try devo inizializzare
            try
            {
                scelta = Convert.ToInt32(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("Inserisci un numero corretto");
                scelta = 0;
            }
            return scelta;
        }
    }
}

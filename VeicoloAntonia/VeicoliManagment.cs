using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeicoloAntonia
{
    public class VeicoliManagment
    {
        internal static Veicolo InserisciVeicolo()
        {
            Veicolo veicolo = new Veicolo();
            try
            {
                bool success;
                Console.WriteLine("Inserisci marca");
                veicolo.Marca = Console.ReadLine();
                Console.WriteLine("Inserisci kilowatt");
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
                //stampa valori enum
                int[] values = new int[] { 0, 1, 2, 3 };
                foreach(int enumValue in values)
                {
                    Console.WriteLine(Enum.GetName(typeof(TipoEuro), enumValue));
                }
                success = Enum.TryParse(Console.ReadLine(), out TipoEuro tipo);
                veicolo.Tipologia = tipo;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return veicolo;
        }

        public static int VerificaInputIntero()
        {
            bool success = Int32.TryParse(Console.ReadLine(), out int value);
            while (!success)
            {
                Console.WriteLine("Inserisci un valore numerico");
                success = Int32.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }


        public static void StampaVeicoli(ArrayList veicoli)
        {
            foreach(Veicolo veicolo in veicoli)
            {
                Console.WriteLine(veicolo);
            }
        }

        public static Veicolo CercaVeicolo(ArrayList veicoli)
        {
            Console.WriteLine("Cerca un veicolo inserendo marca e anno di immatricolazione");
            string marca = Console.ReadLine();
            int anno = VerificaInputIntero();
            foreach(Veicolo veicolo in veicoli)
            {
                if (veicolo.Marca==marca && veicolo.AnnoImmatricolazione==anno)
                {
                    return veicolo;
                }
            }
            return null; //se ho ciclato su tutta la lista e non trovo nulla
        }
    }
}

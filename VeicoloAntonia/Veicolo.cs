using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeicoloAntonia
{
    public enum TipoEuro
    {
        EURO1,
        EURO2,
        EURO3,
        EURO4
    }

    public class Veicolo
    {
        public String Marca { get; set; }
        public double Kilowatt { get; set; }
        public int AnnoImmatricolazione { get; set; }
        public double PrezzoAcquisto { get; set; }
        public TipoEuro Tipologia { get; set; }
        public double Bollo { get { return CalcolaBollo(); } } //proprietà calcolata tramite metodo

        public double CalcolaBollo()
        {
            double bollo = 0.0;
            switch(Tipologia)
            {
                case TipoEuro.EURO1:
                    if(Kilowatt > 100)
                    {
                        bollo = 4.35;
                    }
                    else
                    {
                        bollo = 2.90;
                    }
                    break;
                case TipoEuro.EURO2:
                    if (Kilowatt > 100)
                    {
                        bollo = 4.20;
                    }
                    else
                    {
                        bollo = 2.80;
                    }
                    break;
                case TipoEuro.EURO3:
                    if (Kilowatt > 100)
                    {
                        bollo = 4.05;
                    }
                    else
                    {
                        bollo = 2.70;
                    }
                    break;
                default:
                    if (Kilowatt > 100)
                    {
                        bollo = 3.87;
                    }
                    else
                    {
                        bollo = 2.58;
                    }
                    break;

            }
            return bollo;
        }

        public override string ToString()
        {
            return $"Marca: {Marca} Kilowatt: {Kilowatt} Tipologia Euro: {Tipologia} " +
                $"Anno Immatricolazione: {AnnoImmatricolazione} Prezzo: {PrezzoAcquisto}" +
                $"Bollo: {Bollo}"; 
        }
    }
}

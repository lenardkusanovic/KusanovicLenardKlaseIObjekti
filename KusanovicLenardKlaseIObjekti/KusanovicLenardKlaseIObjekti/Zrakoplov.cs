using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KusanovicLenardKlaseIObjekti
{
    class Zrakoplov
    {
        private string naziv;
        private int snagaMotora;
        private int dometLeta;

        public override string ToString()
        {
            string ispis = "Naziv: " + naziv + "\nSnaga: " + snagaMotora
                + "\nDomet leta: " + dometLeta + "km";
            return ispis;

        }
        public Zrakoplov() 
        { 
        
        }

        public Zrakoplov(string naziv, int snagaMotora, int dometLeta) 
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dometLeta = dometLeta;

        }

        public Zrakoplov(string naziv, int snagaMotora)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
        
        }


        public string getNaziv() 
        {
            return naziv;
        }

        public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }

        public int getSnagaMotora()
        {
            return snagaMotora;
        }

        public void setSnagaMotora(int snagaMotora)
        {
            this.snagaMotora = snagaMotora;  
        }

        public int getDometLeta() 
        {
            return dometLeta;     
        }

        public void setDometLeta(int dometLeta)
        {
            this.dometLeta = dometLeta;
        }
    }
}

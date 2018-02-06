using System;
namespace OOP_BS
{
    public class CMitarbeiter
    {
        private string Nachname;
        private string Vorname;

        public CMitarbeiter(string NN, string VN)
        {
            setNachname(NN);
            setVorname(VN);
        }

        public void setNachname(string NN) 
        {
            this.Nachname = NN;
        }

        public void setVorname(string VN) 
        {
            this.Vorname = VN;
        }

        public string getNachname() 
        {
            return this.Nachname;
        }

        public string getVorname() 
        {
            return this.Vorname;
        }
    }
}

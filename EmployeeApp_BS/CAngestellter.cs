using System;
namespace OOP_BS
{
    public class CAngestellter : CMitarbeiter
    {
        private double Bruttogehalt;

        public CAngestellter(string NN, string VN, double brutto) : base(NN, VN)
        {
            setBrutto(brutto);
        }

        public void setBrutto(double brutto) 
        {
            try {
				if(brutto > 0) 
				{
					this.Bruttogehalt = brutto;            
				}
				else 
				{
					throw new Exception("Bitte ein gültiges Gehalt angeben");
				}
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public double getBrutto() 
        {
            return this.Bruttogehalt;
        }
    }
}

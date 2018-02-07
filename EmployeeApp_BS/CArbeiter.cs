using System;
namespace EmployeeApp_BS
{
    public class CArbeiter : CMitarbeiter
    {
        private int Stunden;
        private double Stundenlohn;

        public CArbeiter(string NN, string VN, int std, double stdLohn) : base(NN, VN)
        {
            setStunden(std);
            setStundenlohn(stdLohn);
        }

        public void setStunden(int std) 
        {
            try {
                if(std > 0) {
                    this.Stunden = std;
                }
                else {
                    throw new Exception("Bitte eine gültige Stundenzahl angegeben");
                }
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void setStundenlohn(double stdLohn) 
        {
            try {
                if(stdLohn > 0) {
                    this.Stundenlohn = stdLohn;
                }
                else {
                    throw new Exception("Bitte einen gültigen Stundenlohn angeben");
                }
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public double getBrutto() 
        {
            return this.Stunden * this.Stundenlohn;
        }
    }
}

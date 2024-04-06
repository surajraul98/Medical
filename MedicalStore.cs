using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop
{
    internal class MedicalStore
    {
        /************* Get All Medicines ************/
        public List<Medicine> GetMedicines() {
            List<Medicine> medicines= new List<Medicine>();
            try {
                string[] lines = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\MedicalShop\\medicines.csv");
                foreach (string line in lines)
                {
                    string[] List = line.Split(",");
                    Medicine medicine = new Medicine(int.Parse(List[0]) , List[1], double.Parse(List[2]) , int.Parse(List[3]));
                    if (medicine.Quantity <= 20 || medicine.Price < 500) { 
                        medicines.Add(medicine);
                    }
                }
                if (medicines.Count == 0) {
                    throw new NoMedicineFoundException("No Medicines to Order at Present");
                }
            } catch(FileNotFoundException) {
                Console.WriteLine("File Not Find");
            } catch(Exception e)
            {
                Console.WriteLine("Error: "+ e.Message);
            }
            return medicines ;
        }

        /************* Get Total Purchase Amount ************/
        public double GetPurchaseAmount(List<Medicine> medicines) {
            return medicines.Sum(item => item.Price * item.Quantity);
        }
    }
}

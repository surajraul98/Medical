using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop
{
    internal class Medicine
    {
        public int MedicineId { get; set; }
        public string? MedicineName { get; set; }
        public double Price { get; set; }
        public int  Quantity { get; set; }

        public Medicine(int MedicineId, string? MedicineName, double Price, int Quantity) {
        this.MedicineId = MedicineId;
        this.MedicineName = MedicineName;
        this.Price = Price;
        this.Quantity = Quantity;
        }

    }
}

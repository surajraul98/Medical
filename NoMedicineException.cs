using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop
{
    internal class NoMedicineFoundException : Exception
    {
        public NoMedicineFoundException(string message) : base(message) {
        
        }
    }
}

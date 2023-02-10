using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Pharmacy
    {
        public Medicine[] medicinies = new Medicine[0];

        public void AddMedicine(Medicine md)
        {
            Array.Resize(ref medicinies, medicinies.Length + 1);
            medicinies[medicinies.Length - 1] = md;
        }
    }
}

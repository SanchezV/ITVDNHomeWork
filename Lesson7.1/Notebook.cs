using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._1
{
    public struct Notebook
    {
        string model, manufacturer;
        int price;
        public Notebook(string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public override string ToString()
        {
            string result = $"Model: {model}, manufacturer: {manufacturer}, price: {price}$.";
            return result;
        }
    }
}

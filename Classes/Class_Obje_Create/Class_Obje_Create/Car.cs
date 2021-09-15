using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Obje_Create
{
    class Car:carDetail
    {
        public string colour;
        public int speed ;
        public double engine;
        public char status;
        public int price;
        private int year;
        private string brand;

        public int YEAR
        {
            get { return year; }
            set { year=Math.Abs(value); }

        }

        public string BRAND
        {
            get { return brand; }
            set { brand = value.ToUpper(); }
        }
          
    }
}

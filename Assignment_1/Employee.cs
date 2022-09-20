using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Employee
    {
        private string name;
        private int number;
        private Decimal rate;
        private Double hours;
        private Decimal gross;


        public Employee(String name, int number, Decimal rate, Double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }

        public Decimal GetGross()
        {
            return gross;
        }

        public Double GetHours()
        {
            return hours;
        }

        public String GetName()
        {
            return name;
        }

        public int GetNumber()
        {
            return number;
        }

        public Decimal GetRate()
        {
            return rate;
        }

        public void SetHours(Double hours) { this.hours = hours; }
        public void SetName(String name) { this.name = name; }
        public void SetNumber(int number) { this.number = number; }
        public void SetRate(Decimal rate) { this.rate = rate; }

        public override string ToString()
        {
            return GetName() + ", " + GetGross() + ", " + GetHours() + " , " + GetHashCode() + " , " + GetNumber() + ". ";
        }
    }
}

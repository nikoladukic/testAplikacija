using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAplikacija
{
    internal class Student
    {
        private string ime;
        private int godine;

        public Student(string ime, int godine)
        {
            this.Ime = ime;
            this.Godine = godine;
        }

        public string Ime { get => ime; set => ime = value; }
        public int Godine { get => godine; set => godine = value; }

        public override string? ToString()
        {
            return "Ime: "+Ime+" Godine: "+Godine;
        }


        

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex1
{
    class Tag
    {
        private Guid id { get; set; }
        private string nume { get; set; }
        private double pretNet { get; set; }

        public Tag(Guid id, string nume, double pretNet)
        {
            this.id = id;
            this.nume = nume;
            this.pretNet = pretNet;
        }

        public override string ToString()
        {
            return "id: " + id + "\nnume: " + nume + "\npretNet: " + pretNet + "\n";
        }

        public void Tipareste()
        {
            Console.WriteLine(this);
        }
    }
}

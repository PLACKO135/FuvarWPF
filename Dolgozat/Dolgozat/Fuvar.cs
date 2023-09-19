using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    internal class Fuvar
    {
        int taxi_id;
        string indulas;
        int idotartam;
        double tavolsag;
        double vitel_dij;
        double borravalo;
        string fizetes_modja;

        public Fuvar(int taxi_id, string indulas, int idotartam, double tavolsag, double vitel_dij, double borravalo, string fizetes_modja)
        {
            this.taxi_id = taxi_id;
            this.indulas = indulas;
            this.idotartam = idotartam;
            this.tavolsag = tavolsag;
            this.vitel_dij = vitel_dij;
            this.borravalo = borravalo;
            this.fizetes_modja = fizetes_modja;
        }

        public int Taxi_id { get => taxi_id; set => taxi_id = value; }
        public string Indulas { get => indulas; set => indulas = value; }
        public int Idotartam { get => idotartam; set => idotartam = value; }
        public double Tavolsag { get => tavolsag; set => tavolsag = value; }
        public double Vitel_dij { get => vitel_dij; set => vitel_dij = value; }
        public double Borravalo { get => borravalo; set => borravalo = value; }
        public string Fizetes_modja { get => fizetes_modja; set => fizetes_modja = value; }
    }
}

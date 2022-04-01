using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetPi2Blazor.Pages
{
    public class MatriceR
    {

        public List<Indicateur> Indicateurs { get; set; }
        public double[][] SigmaXY { get; set; }
        public double[] SigmaX { get; set; }
        public int NombrePoints { get; set; }
        public double[][] Covariance { get; set; }
        public double[][] SigmaXY_Centre { get; set; }

    }
}

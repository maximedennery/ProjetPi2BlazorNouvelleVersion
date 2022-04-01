using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetPi2Blazor.Pages
{
    public class Indicateur
    {
        public string Nom { get; set; }
        public bool IsChecked { get; set; }
        public double Moyenne { get; set; }
        public double Variance { get; set; }
        public double Coefficient { get; set; }
        public double BetaValueMR { get; set; }
        public double BetaValueSR { get; set; }
        public double VarMR { get; set; }
        public double VarSR { get; set; }

        public double BetaValueMRModel { get; set; }
        public double BetaValueSRModel { get; set; }
        public double VarMRModel { get; set; }
        public double VarSRModel { get; set; }



        /// <summary>
        /// Définition de la méthode Equals, qui permet de vérifier si deux indicateurs sont égaux (utile lorsque l'on plot
        /// des figures dans la page Graphe.razor)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Indicateur))
            {
                return false;
            }

            Indicateur i = (Indicateur)obj;

            return this.Nom == i.Nom && this.IsChecked == i.IsChecked && this.Moyenne == i.Moyenne &&
                this.Variance == i.Variance && this.Coefficient == i.Coefficient && this.BetaValueMR == i.BetaValueMR &&
                this.BetaValueSR == i.BetaValueSR && this.VarMR == i.VarMR && this.VarSR == i.VarSR &&
                this.BetaValueMRModel == i.BetaValueMRModel && this.BetaValueSRModel == i.BetaValueSRModel &&
                this.VarMRModel == i.VarMRModel && this.VarSRModel == i.VarSRModel;
        }

        /// <summary>
        /// Nécessaire pour le bon fonctionnement de la méthode Equals
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Nom.GetHashCode() ^ IsChecked.GetHashCode() ^ Moyenne.GetHashCode() ^ Variance.GetHashCode() ^
                Coefficient.GetHashCode() ^ BetaValueMR.GetHashCode() ^ BetaValueSR.GetHashCode() ^ VarMR.GetHashCode() ^
                VarSR.GetHashCode() ^ BetaValueMRModel.GetHashCode() ^ BetaValueSRModel.GetHashCode() ^ 
                VarMRModel.GetHashCode() ^ VarMRModel.GetHashCode();
        }
    }
}

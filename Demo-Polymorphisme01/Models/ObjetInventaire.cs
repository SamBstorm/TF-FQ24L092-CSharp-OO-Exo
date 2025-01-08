using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme01.Models
{
    public class ObjetInventaire
    {
        public string Nom { get; set; }
        public virtual void Utiliser()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PhersonalApplication.Models
{
    public class Medlemskonto
    {
        public int ID { get; set; }

        public string Epost { get; set; }

        public string Lösenord { get; set; }

        public int MedlemsID { get; set; }

        public virtual Medlemmar Medlemmar { get; set; }
    }
}

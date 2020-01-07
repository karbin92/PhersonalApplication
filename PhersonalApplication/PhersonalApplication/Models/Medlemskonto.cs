using System;
using System.Collections.Generic;
using System.Text;

namespace PhersonalApplication.Models
{
    public class Medlemskonto
    {
        public int ID { get; set; }

        //[Required]
        //[StringLength(60)]
        public string Epost { get; set; }

        //[Required]
        //[StringLength(100)]
        public string Lösenord { get; set; }

        public int MedlemsID { get; set; }

        public virtual Medlem Medlemmar { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PhersonalApplication.Models
{
    public class Medlemmar
    {
        public Medlemmar()
        {
            Medlemskonto = new HashSet<Medlemskonto>();
        }
        public string SkapadAv { get; set; }
        public int ID { get; set; }

        
        public string Förnamn { get; set; }

        
        public string Efternamn { get; set; }

        
        public string Telefonnummer { get; set; }

       
        public string Institution { get; set; }

      
        public string Epostadress { get; set; }

       
        public DateTime GiltighetsÅr { get; set; }

        
        public DateTime RegistreringsDatum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medlemskonto> Medlemskonto { get; set; }
    }
}

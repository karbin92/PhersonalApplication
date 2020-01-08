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

        //[Required(ErrorMessage = "Ange ett giltigt förnamn")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
        // ErrorMessage = "Characters are not allowed.")]
        public string Förnamn { get; set; }

        //[StringLength(40)]
        //[Required(ErrorMessage = "Ange ett giltigt efternamn")]
        public string Efternamn { get; set; }

        //[Required(ErrorMessage = "Telefonnummer får vara mellan 8 till 12 siffror")]
        //[StringLength(12, MinimumLength = 8, ErrorMessage = "Ej giltig")]
        public string Telefonnummer { get; set; }

        //[StringLength(50)]
        public string Institution { get; set; }

        //[Required]
        //[StringLength(40, MinimumLength = 10)]
        //[EmailAddress(ErrorMessage ="Ogiltig e-postadress")]
        //[RegularExpression(@"^[a-zA-Z0-9._%+-]+([-.]\w+)*@hv.se$",
                                                //ErrorMessage = "E-postadressen har fel format")]
        public string Epostadress { get; set; }

        //[Column(TypeName = "date")]
        public DateTime GiltighetsÅr { get; set; }

        //[Column(TypeName = "date")]
        public DateTime RegistreringsDatum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medlemskonto> Medlemskonto { get; set; }
    }
}

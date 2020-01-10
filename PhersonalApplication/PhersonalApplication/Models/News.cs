using System;
using System.Collections.Generic;
using System.Text;


namespace PhersonalApplication.Models
{
    public class News
    {
        public string BildURL { get; set; }
        public string Link1 { get; set; }
        public string Link2 { get; set; }
        public string SkapadAv { get; set; }
        public int ID { get; set; }

        public string Rubrik { get; set; }

        public string Underrubrik { get; set; }

        public string Beskrivning { get; set; }

        public DateTime PubliceringsDatum { get; set; }
    }
}

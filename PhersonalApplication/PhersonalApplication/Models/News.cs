using System;
using System.Collections.Generic;
using System.Text;


namespace PhersonalApplication.Models
{
    public class News
    {
        public int ID { get; set; }


        public string Rubrik { get; set; }


        public string Underrubrik { get; set; }

        public string Beskrivning { get; set; }

        public DateTime PubliceringsDatum { get; set; }
    }
}

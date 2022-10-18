using System;
using System.Collections.Generic;
using System.Text;

namespace AppConselhoAPI.Model
{
    public class Conselho
    {
        public string id { get; set; }
        public string advice { get; set; }

        public Conselho()
        {
            this.id = " ";
            this.advice = " ";
        }
    }
}

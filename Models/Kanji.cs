using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kanji
    {
        public int Id { get; set; }
        public string Character { get; set; }
        public string Meaning { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Braford_Identity.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string user { get; set; }
        public DateTime time { get; set; }
        public string issue { get; set; }
        public string area_of_issue { get; set; }
        public string resolution { get; set; }
        public string status { get; set; }

    }
}

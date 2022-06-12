using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolowkwiumAPBD.Models
{
    public class Musician
    {
        public int IdMusician { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
    }
}

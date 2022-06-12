using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolowkwiumAPBD.Models
{
    public class MusicTrack
    {
        public int IdTrack;
        public int IdMusician;
        public virtual Musician MusicianNav { get; set; }
        public virtual Track TrackNav { get; set; }
    }
}

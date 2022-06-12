using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KolowkwiumAPBD.Models
{
    public class Track
    {
        public int IdTrack;
        public string TrackName;
        public float Duration;
        public int IdMusicAlbum;

        [ForeignKey("IdMusicAlbum")]
        public virtual Album AlbumNav { get; set; }
        public virtual Track TrackNav { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}

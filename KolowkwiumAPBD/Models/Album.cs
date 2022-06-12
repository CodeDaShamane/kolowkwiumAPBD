using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolowkwiumAPBD.Models
{
    public class Album
    {
        public Album()
        {
            Albums = new HashSet<Album>();
        }
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        //public virtual ICollection<MusicLabel> MusicLabels { get; set; }
        public virtual ICollection<Album> Albums{ get; set; }
    }
}

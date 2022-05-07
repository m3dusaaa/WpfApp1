using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTO
{
    internal class Oplata
    {
        [Column("Price")]
        public string Price { get; set; }
        [Column("datetName")]
        public string Date { get; set; }
        [Column("client_id")]
        public string idclient { get; set; }
        [Column("oplata_id")]
        public int OplataId { get; set; }
    }
}

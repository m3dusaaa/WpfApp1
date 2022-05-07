using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTO
{
    internal class Tour
    {
        [Table("tour")]
        public class Client : BaseDTO
        {
            [Column("country")]
            public string Country { get; set; }
            [Column("city")]
            public string City { get; set; }
            [Column("Time")]
            public string Time { get; set; }
            [Column("Uslugi")]
            public DateTime Uslugi { get; set; }
            [Column("cliend_id")]
            public int ClientId { get; set; }
        }
    }
}

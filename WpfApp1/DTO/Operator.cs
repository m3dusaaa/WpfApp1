using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTO
{
    internal class Operator
    {
        [Table("operator")]
        public class Operators : BaseDTO
        {
            [Column("lastName")]
            public string LastName { get; set; }
            [Column("firstName")]
            public string FirstName { get; set; }
            [Column("patronymicName")]
            public string PatronymicName { get; set; }
            [Column("birthday")]
            public DateTime Birthday { get; set; }
            [Column("client_id")]
            public int ClientId { get; set; }
        }
    }
}

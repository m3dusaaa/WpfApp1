using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTO
{
    internal class Client
    {
        [Table("client")]
        public class Clients : BaseDTO
        {
            [Column("lastName")]
            public string LastName { get; set; }
            [Column("firstName")]
            public string FirstName { get; set; }
            [Column("patronymicName")]
            public string PatronymicName { get; set; }
            [Column("birthday")]
            public DateTime Birthday { get; set; }
            [Column("operator_id")]
            public int OperatorId { get; set; }
        }
    }
}

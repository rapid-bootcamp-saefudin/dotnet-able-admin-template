using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.DataContext
{
    [Table("tbl_client")]
    public class ClientEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("client_name")]
        public String ClientName { get; set; }

        [Column("client_email")]
        public String ClientEmail { get; set; }

        [Column("client_gender")]
        public String ClientGender { get; set; }

        [Column("client_company_name")]
        public String CompanyName { get; set; }
    }
}

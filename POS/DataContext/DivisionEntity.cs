using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.DataContext
{
    [Table("tbl_division")]
    public class DivisionEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("division_name")]
        public String DivisionName { get; set; }

        [Column("division_description")]
        public String DivisionDescription { get; set; }
    }

}

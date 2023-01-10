using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.DataContext
{
    [Table("tbl_product")]
    public class ProductEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("product_name")]
        public String ProductName { get; set; }

        [Column("product_category")]
        public String ProductCategory { get; set; }

        [Column("product_price")]
        public String ProductPrice { get; set; }
    }

}

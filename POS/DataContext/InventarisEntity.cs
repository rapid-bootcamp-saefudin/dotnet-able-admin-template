using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.DataContext
{
    [Table("tbl_inventaris")]
    public class InventarisEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("inventaris_product_name")]
        public String InventarisProductName { get; set; }

        [Column("inventaris_category")]
        public String InventarisCategory { get; set; }

        [Column("inventaris_brand")]
        public String InventarisBrand { get; set; }

        [Column("inventaris_stock")]
        public String InventarisStock { get; set; }
    }
}

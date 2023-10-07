

using System.ComponentModel.DataAnnotations.Schema;

namespace INV.Domain.Entities.InventoryEntity.BasicEntity
{
    public class ProductEntity : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductShortName { get; set; }

        [ForeignKey("Categories")]
        public int CategoryId { get; set; }

        [ForeignKey("SubCategories")]
        public int SubCategoryId { get; set; }
        public int Price { get; set; }

        [ForeignKey("Units")]
        public int UnitId { get; set; }
        public int OpeningQnty { get; set; }

    }
}

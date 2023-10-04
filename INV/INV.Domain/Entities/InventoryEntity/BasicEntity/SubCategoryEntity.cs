
using System.ComponentModel.DataAnnotations.Schema;

namespace INV.Domain.Entities.InventoryEntity.BasicEntity
{
    public class SubCategoryEntity : BaseEntity
    {
        public string SubCategoryName { get; set; }

        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
    }
}

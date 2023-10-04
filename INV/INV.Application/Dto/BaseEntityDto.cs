
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace INV.Application.Dto
{
    public abstract class BaseEntityDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
    }
    public abstract class BaseEntityDtoConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntityDto
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Ignore(b => b.CreatedBy);
            builder.Ignore(b => b.UpdatedDate);
            builder.Ignore(b => b.UpdatedBy);
            builder.Ignore(b => b.IsActive);
            builder.Ignore(b => b.IsDelete);
            builder.Ignore(b => b.DeletedBy);
            builder.Ignore(b => b.DeletedDate);
            ConfigureDerivedEntity(builder);
        }

        protected abstract void ConfigureDerivedEntity(EntityTypeBuilder<T> builder);
    }
}

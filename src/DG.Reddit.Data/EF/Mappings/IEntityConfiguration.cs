using Microsoft.EntityFrameworkCore;

namespace DG.Reddit.Data.EF.Mappings
{
    public interface IEntityConfiguration
    {
        void Configuration(ModelBuilder builder);
    }
}
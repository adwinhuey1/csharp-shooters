using valkyrieIMS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace valkyrieIMS.Data {
    public class valkyrieContext: DbContext {
        public DbSet<Item> Items { get; set; }
    }
}
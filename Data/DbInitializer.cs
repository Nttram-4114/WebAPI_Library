using Microsoft.EntityFrameworkCore;
using Web2_1604.Model;

namespace Web2_1604.Data
{
    internal class DbInitializer
    {
        private ModelBuilder builder;

        public DbInitializer(ModelBuilder builder)
        {
            this.builder = builder;
        }

        public void Seed()
        {
        }
    }
}
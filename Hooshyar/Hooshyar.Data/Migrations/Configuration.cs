using Hooshyar.Model;

namespace Hooshyar.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hooshyar.Data.HooshyarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Hooshyar.Data.HooshyarDbContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			context.CountTypes.AddOrUpdate(
			  p => p.Name,
			  new CountType { Name = "عدد" },
			  new CountType { Name = "کیلو" },
			  new CountType { Name = "تن" }
			);

		}
	}
}

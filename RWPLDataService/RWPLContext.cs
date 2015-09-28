using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using RWPLDataService.Model;
using RWPLEntityModel;
using RWPLEntityModel.ReportView;

namespace RWPLDataService
{
    public class RWPLDBInitializer : CreateDatabaseIfNotExists<RWPLContext>
    {
        protected override void Seed(RWPLContext context)
        {
            var user = new User()
            {
                UserName = "admin",
                Password = "admin",
                UserAccessPageses = GetUserAccessPages()
            };

            context.Users.Add(user);
            base.Seed(context);
        }

        private List<UserAccessPage> GetUserAccessPages()
        {
            return (from object page in Enum.GetValues(typeof(AccessPages))
                    select new UserAccessPage()
                    {
                        PageName = page.ToString(),
                        View = true,
                        Add = true,
                        Edit = true,
                        Delete = true
                    }).ToList();
        }
    }

    public class RWPLContext : DbContext
    {
        public RWPLContext()
        //: base(ConfigurationSettings.AppSettings.Get("RWPLContext"))
        {
            //Database.SetInitializer<RWPLContext>(new CreateDatabaseIfNotExists<RWPLContext>());

            //Database.SetInitializer<RWPLContext>(new DropCreateDatabaseAlways<RWPLContext>());

            Database.SetInitializer<RWPLContext>(new RWPLDBInitializer());
            
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }

        // masters
        public DbSet<Dispatch> Dispatchs { get; set; }

        public DbSet<DispatchItem> DispatchItems { get; set; }

        public DbSet<PaperReelConsumption> PaperReelConsumptions { get; set; }

        public DbSet<AutoStichingPin> AutoStichingPins { get; set; }

        public DbSet<BundlingM1> BundlingM1S { get; set; }



        // basic tables
        public DbSet<User> Users { get; set; }

        public DbSet<UserAccessPage> UserAccessPages { get; set; }

        // views
        //public DbSet<VmPurchaseOrders> VmPurchaseOrderses { get; set; }
    }
}
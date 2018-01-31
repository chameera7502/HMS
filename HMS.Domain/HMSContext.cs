using HMS.Domain.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain
{
    public class HMSContext:DbContext
    {
        
            public HMSContext() : base("name=HotelManagementConnectionString")
            {
                 this.Configuration.LazyLoadingEnabled = false;
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<HMSContext, HMS.Domain.Mi>("SchoolDBConnectionString"));
        }

        public HMSContext(bool EnableLazyLoading): base("name=HotelManagementConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = EnableLazyLoading;
        }

  



        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<RoomManagment> RoomManagement { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Payment> Payment { get; set; }


        /*  public DbSet<Item> Items { get; set; }
          public DbSet<Category> Category { get; set; }
      public DbSet<GRNDetails> GrnDetails { get; set; }
      public DbSet<GRNHeader> GrnHeaders { get; set; }
      public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
      public DbSet<InvoiceHeader> InvoiceHeader { get; set; }
      public DbSet<Debtors> Debtors { get; set; }
      public DbSet<DebtorPayments> DebtorPayments { get; set; }
      public DbSet<CustomerMaster> CustomerMaster { get; set; }
      public DbSet<Test> Testdata { get; set; }*/



    }
}

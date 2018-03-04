using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VLTrack.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public DbSet<Country> Country { get; set; }

 /*       public DbSet<City> City { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Phase> Phase { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }
        public DbSet<Requirement> Requirement { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceLevel> ServiceLevel { get; set; }
        //public DbSet<ServiceLevelDetail> ServiceLevelDetail { get; set; }
        //public DbSet<ServicePhase> ServicePhase { get; set; }
        //public DbSet<ServiceRequirement> ServiceRequirement { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<MediaFile> MediaFile { get; set; }
        public DbSet<OrderPaymentHistory> OrderPaymentHistory { get; set; }
        //public DbSet<OrderItemTransactionHistory> OrderItemTransactionHistory { get; set; }
        //public DbSet<CustomerServiceRequirement> CustomerServiceRequirement { get; set; }*/

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
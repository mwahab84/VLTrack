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

        #region VL Tracking Model Domain Classes

            public DbSet<Country> Countries { get; set; }
            public DbSet<City> Cities { get; set; }
            public DbSet<Phase> Phases { get; set; }
            public DbSet<Service> Services { get; set; }
            public DbSet<ServiceLevel> ServiceLevels { get; set; }
            public DbSet<Transaction> Transactions { get; set; }
            public DbSet<Requirement> Requirements { get; set; }
            public DbSet<PaymentMethod> PaymentMethods { get; set; }
            public DbSet<ServiceLevelDetail> ServiceLevelDetails { get; set; }
            public DbSet<ServicePhase> ServicePhases { get; set; }
            public DbSet<ServiceRequirement> ServiceRequirements { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderItem> OrderItems { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Address> Addresses { get; set; }
            public DbSet<PhoneNumber> PhoneNumbers { get; set; }
            public DbSet<MediaFile> MediaFiles { get; set; }
            public DbSet<OrderPaymentHistory> OrderPaymentHistory { get; set; }
            public DbSet<OrderItemTransactionHistory> OrderItemTransactionHistory { get; set; }
            public DbSet<CustomerServiceRequirement> CustomerServiceRequirements { get; set; }

        #endregion

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
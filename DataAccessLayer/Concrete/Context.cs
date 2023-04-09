using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        public DbSet<About> AboutDbSet { get; set; }
        public DbSet<About2> About2DbSet { get; set; }
        public DbSet<Contact> ContactDbSet { get; set; }
        public DbSet<Destination> DestinationDbSet { get; set; }
        public DbSet<Feature> FeatureDbSet { get; set; }
        public DbSet<Feature2> Feature2DbSet { get; set; }
        public DbSet<Guide> GuideDbSet { get; set; }
        public DbSet<NewsLetter> NewsletterDbSet { get; set; }
        public DbSet<SubAbout> SubAboutDbSet { get; set; }
        public DbSet<Testimonial> TestimonialDbSet { get; set; }
        public DbSet<Comment> CommentDbSet { get; set; }
        public DbSet<Reservation> ReservationDbSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=TripProject;integrated security=true");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace БашкінВаріант17.Models
{
    public class ChallengesContext : DbContext
    {
        public DbSet<Challenge> Challenges { get; set; }
    }
}
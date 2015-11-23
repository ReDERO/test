using Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Core
{
    /// <summary>
    /// Контекст базы данных Системы 5М
    /// </summary>
    public class System5MContext : IdentityDbContext<User>
    {
        public System5MContext()
            : base("System5MConnection", throwIfV1Schema: false)
        {
        }

        /// <summary>
        /// Умения
        /// </summary>
        public DbSet<Skill> Skills { set; get; }

        /// <summary>
        /// Классы умений
        /// </summary>
        public DbSet<SkillClass> ClassesOfSkills { set; get; }

        /// <summary>
        /// Список приобретённых пользователями умений
        /// </summary>
        public DbSet<UserOwnedSkill> UserOwnedSkills { set; get; }

        /// <summary>
        /// Список умений, которые желают приобрести пользователи
        /// </summary>
        public DbSet<UserWishedSkill> UserWishedSkills { set; get; }

        public static System5MContext Create()
        {
            return new System5MContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*modelBuilder.Entity<UserOwnedSkill>().HasKey(x => new { x.UserId, x.SkillId });
            modelBuilder.Entity<UserWishedSkill>().HasKey(x => new { x.UserId, x.SkillId });*/

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<System5MContext, Configuration>());
        }
    }
}

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    // Чтобы добавить данные профиля для пользователя, можно добавить дополнительные свойства в класс ApplicationUser. Дополнительные сведения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=317594.
    public class User : IdentityUser
    {
        public User()
        {
            this.SkillClasses = new HashSet<SkillClass>();
            this.OwnedSkills = new HashSet<UserOwnedSkill>();
            this.WishedSkills = new HashSet<UserWishedSkill>();
        }

        /// <summary>
        /// Список добавленных в систему классов умений
        /// </summary>
        public ICollection<SkillClass> SkillClasses { set; get; }

        /// <summary>
        /// Список умений, которые приобрёл пользователь
        /// </summary>
        public ICollection<UserOwnedSkill> OwnedSkills { set; get; }

        /// <summary>
        /// Список умений, которые пользователь желает приобрести
        /// </summary>
        public ICollection<UserWishedSkill> WishedSkills { set; get; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }
}

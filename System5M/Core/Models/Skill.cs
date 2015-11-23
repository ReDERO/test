using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// Класс "Skill".
    /// Описывает умение.
    /// </summary>
    public class Skill
    {
        public Skill()
        {
            this.UserOwnedSkills = new HashSet<UserOwnedSkill>();
            this.UserWishedSkills = new HashSet<UserWishedSkill>();
        }

        /// <summary>
        /// Содержит идентификатор умения
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// Содержит название умения
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// Содержит описание умения
        /// </summary>
        public string Description { set; get; }

        /// <summary>
        /// Идентификатор класса умений
        /// </summary>
        public int SkillClassId { set; get; }

        /// <summary>
        /// Идентификатор пользователя, который добавил умение
        /// </summary>
        public string UserId { set; get; }

        /// <summary>
        /// Класс умений
        /// </summary>
        public SkillClass SkillClass { set; get; }

        /// <summary>
        /// Пользователь, который добавил умение
        /// </summary>
        public User User { set; get; }

        /// <summary>
        /// Список пользователей, которые приобрели умение
        /// </summary>
        public ICollection<UserOwnedSkill> UserOwnedSkills { set; get; }

        /// <summary>
        /// Список пользователей, которые желают приобрести умение
        /// </summary>
        public ICollection<UserWishedSkill> UserWishedSkills { set; get; }
    }
}

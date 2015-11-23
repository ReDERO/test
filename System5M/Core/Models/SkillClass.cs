using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// Класс "ClassOfSkills".
    /// Описывает класс умений.
    /// </summary>
    public class SkillClass
    {
        public SkillClass()
        {
            this.Skills = new HashSet<Skill>();
        }

        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// Название класса
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// Идентификатор пользователя, который добавил класс в систему
        /// </summary>
        public string UserId { set; get; }

        /// <summary>
        /// Пользователь, который добавил класс в систему
        /// </summary>
        public User User { set; get; }

        /// <summary>
        /// Список умений
        /// </summary>
        public ICollection<Skill> Skills { set; get; }
    }
}

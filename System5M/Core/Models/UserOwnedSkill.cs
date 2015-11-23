using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// Класс "UserOwnedSkill".
    /// Описывает приобретённое пользователем умение.
    /// </summary>
    public class UserOwnedSkill
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public string UserId { set; get; }

        /// <summary>
        /// Идентификатор умения
        /// </summary>
        [Key]
        [Column(Order = 2)]
        public int SkillId { set; get; }
        
        /// <summary>
        /// Дата приобретения умения
        /// </summary>
        public DateTime Date { set; get; }


        /// <summary>
        /// Пользователь, который получил умение
        /// </summary>
        public User User { set; get; }

        /// <summary>
        /// Умение, которое приобёл пользователь
        /// </summary>
        public Skill Skill { set; get; }
    }
}

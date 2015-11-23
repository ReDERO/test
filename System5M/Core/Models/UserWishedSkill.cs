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
    /// Класс "UserWishedSkill".
    /// Описывает желаемое пользователем умение.
    /// </summary>
    public class UserWishedSkill
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
        /// Дата добавления умения в список желаемых умений
        /// </summary>
        public DateTime Date { set; get; }


        /// <summary>
        /// Пользователь, который желает приобрести умение
        /// </summary>
        public User User { set; get; }

        /// <summary>
        /// Умение, которое пользователь желает приобрести
        /// </summary>
        public Skill Skill { set; get; }
    }
}

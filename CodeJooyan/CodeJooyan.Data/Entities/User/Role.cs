using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeJooyan.Data.Entities.User
{
    public class Role
    {
        #region Ctor
        public Role()
        {

        }
        #endregion

        [Key]
        public int RoleId { get; set; }
        [Display(Name = "")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(ErrorMessage ="{0} نمیتواند بیشتر از {1} باشید")]
        public string RoleTitle { get; set; }

        #region Relations

        public virtual List<UserRole> UserRole { get; set; }

        #endregion
    }
}

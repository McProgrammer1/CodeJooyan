using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeJooyan.Data.Entities.User
{
    public class UserRole
    {
        #region Ctor
        public UserRole()
        {

        }
        #endregion

        #region Properties
        
        [Key]
        public int UR_Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        
        #endregion

        #region Relations




        #endregion
    }
}

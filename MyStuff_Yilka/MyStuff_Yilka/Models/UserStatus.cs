﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyStuff_Yilka.Models
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            Users = new HashSet<User>();
        }

        public int UserStatusId { get; set; }
        public string UserStatus1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

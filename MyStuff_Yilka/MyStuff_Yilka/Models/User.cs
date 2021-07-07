﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyStuff_Yilka.Models
{
    public partial class User
    {
        //Copiar el user del API

        public User()
        {
            Brands = new HashSet<Brand>();
            ItemCategories = new HashSet<ItemCategory>();
            ItemLocalizations = new HashSet<ItemLocalization>();
            Items = new HashSet<Item>();
            Suppliers = new HashSet<Supplier>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string UserPassword { get; set; }
        public string Phone { get; set; }
        public string BackupEmail { get; set; }
        public DateTime LastLogin { get; set; }
        public int UserStatusId { get; set; }

        public virtual UserStatus UserStatus { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<ItemCategory> ItemCategories { get; set; }
        public virtual ICollection<ItemLocalization> ItemLocalizations { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}

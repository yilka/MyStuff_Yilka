﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyStuff_Yilka.Models
{
    public partial class ItemCategory
    {
        public ItemCategory()
        {
            Items = new HashSet<Item>();
        }

        public int ItemCategoryId { get; set; }
        public string Category { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    
}
}

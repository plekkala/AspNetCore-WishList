﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class Item
    {
        public int Id;

        [MaxLength(50),Required]
        public string Description;
    }
}

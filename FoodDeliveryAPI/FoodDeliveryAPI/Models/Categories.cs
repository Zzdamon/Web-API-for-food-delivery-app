﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryAPI.Models
{
    public class Categories
    {   [Key]
        public int categId { get; set; }

        public string name { get; set; }

        [ForeignKey("Restaurant")]
        public int restaurantId { get; set; }

        public Restaurants Restaurant { get; set; }
    }
}

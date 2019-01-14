﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelAtr.DAL
{
    public class RoomOptions
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomOptionsId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}

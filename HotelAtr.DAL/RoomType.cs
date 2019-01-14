using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelAtr.DAL
{
    [Table("RoomType", Schema = "Table")]
    public class RoomType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomTypeId { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public List<Room> Room { get; set; }
    }
}

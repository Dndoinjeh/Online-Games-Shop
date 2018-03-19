namespace OnlineShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Game
    {
        public int GameID { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int? Position { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace PatikaFirstDb.Entities;
    public class GameEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }

        [Column(TypeName = "decimal(10,2)")]
    public decimal Rating { get; set; }

    }


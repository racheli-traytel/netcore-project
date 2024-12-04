using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dress_rent.entities
{
    [Table("dress")]
        public class DressEntity
        {
        [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public int Size { get; set; }
            public string Color { get; set; }
            public string Material { get; set; }
            public double Price { get; set; }
            public int NumberOfTimesBorrowed { get; set; }

            public DressEntity(int id, string name, int size, string color, string material, double price, int numberOfTimesBorrowed)
            {
                Id = id;
                Name = name;
                Size = size;
                Color = color;
                Material = material;
                Price = price;
                NumberOfTimesBorrowed = numberOfTimesBorrowed;
            }

            public DressEntity()
            {

            }
            public override string ToString()
            {
                return $"Id:{Id},Name:{Name},Color:{Color},Size:{Size}";
            }
        }
}

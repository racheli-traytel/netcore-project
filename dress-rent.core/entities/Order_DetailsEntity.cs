using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dress_rent.entities
{
    [Table("Order_Details")]
        public class Order_DetailsEntity
        {
        [Key]
            public int Id { get; set; }
            public int OrderId { get; set; }
            public int DressId { get; set; }

            public Order_DetailsEntity(int id, int orderId, int dressId)
            {
                Id = id;
                OrderId = orderId;
                DressId = dressId;
            }

            public Order_DetailsEntity()
            {

            }
        }
}

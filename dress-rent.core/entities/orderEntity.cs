using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dress_rent.entities
{
    [Table("order")]
        public class orderEntity
        {
        [Key]
            public int Id { get; set; }
            public int CustomerId { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime RentDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public bool Status { get; set; }

            public orderEntity(int id, int customerId, DateTime orderDate, DateTime rentDate, DateTime returnDate, bool status)
            {
                Id = id;
                CustomerId = customerId;
                OrderDate = orderDate;
                RentDate = rentDate;
                ReturnDate = returnDate;
                Status = status;
            }
            public orderEntity()
            {

            }
        }
}

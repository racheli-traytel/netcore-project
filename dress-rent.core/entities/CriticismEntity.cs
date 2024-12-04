using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dress_rent.entities
{
    [Table("criticism")]
        public class CriticismEntity
    {
        [Key]
            public int Id { get; set; }
            public int CustomerId { get; set; }
            public int DressId { get; set; }
            public DateTime CriticismDate { get; set; }

            public int Rating { get; set; }
            public string Content { get; set; }
            public bool Isrecomended { get; set; }

            public CriticismEntity(int id, int customerId, int dressId, DateTime criticismDate, int rating, string content, bool isrecomended)
            {
                Id = id;
                CustomerId = customerId;
                DressId = dressId;
                CriticismDate = criticismDate;
                Rating = rating;
                Content = content;
                Isrecomended = isrecomended;
            }
            public CriticismEntity()
            {

            }




        }
    }

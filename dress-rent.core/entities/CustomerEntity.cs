using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dress_rent.entities
{
    [Table("customer")]
        public class CustomerEntity
    {
        [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public DateTime BirthDate { get; set; }
            public DateTime RegistratinDate { get; set; }

            public CustomerEntity(int id, string name, string email, string address, string phone, DateTime birthDate, DateTime registratinDate)
            {
                Id = id;
                Name = name;
                Email = email;
                Address = address;
                Phone = phone;
                BirthDate = birthDate;
                RegistratinDate = registratinDate;
            }
            public CustomerEntity()
            {

            }
        }
}

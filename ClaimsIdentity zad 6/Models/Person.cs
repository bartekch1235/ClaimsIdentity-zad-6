

using System.ComponentModel.DataAnnotations;

namespace ClaimsIdentity_zad_6.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        public bool IsActive { get; set; }
        public string email  { get; set; }
        public Person(string FirstName, string LastName,string emial)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            IsActive = true;
            this.email = emial;
        }
        public Person(string FirstName, string LastName, bool isActive, string email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsActive = isActive;
            this.email = email;
        }
        public Person(string FirstName,string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public Person()
        {

        }
    }
}

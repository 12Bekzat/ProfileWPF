using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileService
{
    public class Profile
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CombainedElementsLesson
{
    public class Company
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public virtual ICollection<PriceHistory> priceHistory { get; set; }
    }
}

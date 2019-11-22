using System;

namespace CombainedElementsLesson
{
    public class PriceHistory
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.Now;
        public double Price { get; set; }
        public virtual Company Company { get; set; }
        public Guid CompanyId { get; set; }
    }
}
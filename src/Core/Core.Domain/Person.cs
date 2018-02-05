using System.Collections.Generic;

namespace NOD.Bubbles.Ui.Core.Domain
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Bubble> Bubbles { get; set; }

        public Person()
        {
            Bubbles = null;
        }
    }
}

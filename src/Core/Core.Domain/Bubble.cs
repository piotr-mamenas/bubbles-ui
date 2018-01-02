using System.Collections.Generic;

namespace NOD.Bubbles.Ui.Core.Domain
{
    public class Bubble : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Person> Persons { get; set; }

        public Bubble()
        {
            Persons = null;
        }
    }
}

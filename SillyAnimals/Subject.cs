using SillyAnimals.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SillyAnimals
{
    abstract class Subject
    {
        public virtual string Species { get; }
        public virtual string PresumedSelf { get; }

        public Subject(string species, string presumedSelf)
        {
            Species = species;
            PresumedSelf = presumedSelf; 
        }

        public abstract string PresentSelf();
    }
}

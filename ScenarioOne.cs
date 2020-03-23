using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator5
{
    public class ScenarioOne
    {
        public void AddReference(SelfReference selfReference)
        {
            using (var context = new ModelSetReferences())
            {
                context.SelfReferences.Add(selfReference);
                context.SaveChanges();
            }
        }

        public ICollection<SelfReference> ListReferences()
        {
            using (var context = new ModelSetReferences())
            {
                return context.SelfReferences.ToList();
            }
        }
    }
}

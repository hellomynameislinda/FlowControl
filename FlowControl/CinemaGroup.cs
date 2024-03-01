using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class CinemaGroup
    {
        private List<CinemaVisitor> cinemaGroup { get; set; }

        public CinemaGroup()
        {
            cinemaGroup = new List<CinemaVisitor>();
        }
        internal static void RunCheckCinemaGroupPrice()
        {
            // Ask how many tickets
            // Iterate that number of times, ask for age
            // Count and display total
            //
        }

        internal void AddCinemaVisitor(string name, uint age)
        {
            cinemaGroup.Add(new CinemaVisitor(name, age));
        }

        internal IEnumerable<CinemaVisitor> GetCinemaGroup()
        {
            //IEnumeral istället för list, är snabbare. Läser bara in infon när den används. Den är Read only!
            //List ärver IEnumerable. List har dock lite extrafunktionalitet
            return cinemaGroup.ToArray();
        }
    }
}


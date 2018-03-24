using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Workout
{
    public class Oefening
    {
        public int OefeningId { get; set; }
        public List<Statistiek> Statistieken { get; set; }
        public Enum.BodyPart BodyPart { get; set; }
        public Enum.OefeningType Type { get; set; }
    }
}

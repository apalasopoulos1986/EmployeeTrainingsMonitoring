using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrainingsMonitoring.Models
{
    public class Trainee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public static readonly string Physically = "Physically";

        public static readonly string Remotely = "Remotely";

        public ICollection<TrainingEvent> TrainingEvents { get; set; }
    }
   


}

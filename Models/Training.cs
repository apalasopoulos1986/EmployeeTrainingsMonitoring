using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrainingsMonitoring.Models
{
    public class Training
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TrainingEvent> TrainingEvents { get; set; }
    }
}

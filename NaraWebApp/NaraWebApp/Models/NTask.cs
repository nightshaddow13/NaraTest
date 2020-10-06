using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaraWebApp.Models
{
    [Table("task")]
    public class NTask
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GlitchTrace.Models
{
    public class Project
    {
        [Required]
        public int ProjectId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual string CreatedBy { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
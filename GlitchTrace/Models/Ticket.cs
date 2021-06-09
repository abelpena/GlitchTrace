using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic.CompilerServices;

namespace GlitchTrace.Models
{
    public class Ticket
    {
        [Required]
        public int TicketId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name = "Status")]
        public bool IsOpen { get; set; }

        [Required]
        public int Priority { get; set; } // 1=high, 2=med, 3=low

        public DateTime? CompletionDate { get; set; }
        public DateTime? CreationDate { get; set; }


        public virtual string CreatedBy { get; set; }
        
        public virtual string AssignedUser { get; set; }
        
        public virtual string AssignedProject { get; set; }

        public enum PriorityId
        {
            High = 1,
            Medium = 2,
            Low = 3
        }
    }
}

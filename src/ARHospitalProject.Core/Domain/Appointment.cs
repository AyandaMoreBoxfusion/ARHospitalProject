using Abp.Domain.Entities.Auditing;
using ARHospitalProject.Domain.Discriminators;
using ARHospitalProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARHospitalProject.Domain
{
    [Entity(TypeShortAlias = "ARHis.Person")]
    public class Appointment: FullAuditedEntity<Guid>
    {
        public virtual DateTime BookingDate { get; set; }
        public virtual RefListAppointment Status { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}

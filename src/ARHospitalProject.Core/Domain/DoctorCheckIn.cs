using Abp.Domain.Entities.Auditing;
using ARHospitalProject.Domain.Discriminators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARHospitalProject.Domain
{
    [Entity(TypeShortAlias = "ARHis.Person")]
    public class DoctorCheckIn: FullAuditedEntity<Guid>
    {
        public virtual DateTime CheckInTime { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}

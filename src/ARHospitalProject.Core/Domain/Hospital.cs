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
    public class Hospital: FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }

        public virtual string Region { get; set; }

        public virtual string Address { get; set; }

        public virtual string ContactNumber { get; set; }
    }
}

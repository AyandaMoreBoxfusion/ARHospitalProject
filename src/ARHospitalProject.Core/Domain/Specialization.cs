using Abp.Domain.Entities.Auditing;
using ARHospitalProject.Domain.Discriminators;
using System;

namespace ARHospitalProject.Domain
{
    [Entity(TypeShortAlias = "ARHis.Person")]
    public class Specialization: FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
    }
}
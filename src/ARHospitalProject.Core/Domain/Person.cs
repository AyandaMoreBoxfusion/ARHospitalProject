using Abp.Domain.Entities.Auditing;
using ARHospitalProject.Domain.Discriminators;
using ARHospitalProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARHospitalProject.Domain
{
    [Entity(TypeShortAlias="ARHis.Person")]
    [Table("ARHis.People")]
    [DiscriminatorValue("ARHis.Person")]
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual DateTime? DateOfBirth { get; set; }

        public virtual RefListGender Gender { get; set; }

        public virtual string IdentificationNumber { get; set; }

        public virtual string CellPhoneNumber { get; set; }

        public virtual string Email { get; set; }

        public virtual string PhysicalAddress { get; set; }
    }
}

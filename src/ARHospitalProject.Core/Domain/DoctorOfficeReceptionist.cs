using ARHospitalProject.Domain.Discriminators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARHospitalProject.Domain
{
    [Entity(TypeShortAlias = "ARHis.Person")]
    [DiscriminatorValue("ARHis.Person")]
    public class DoctorOfficeReceptionist:Person
    {
        public virtual string OfficeReceptionNumber{ get; set; }
        public virtual string OfficeNumber { get; set; }
        public virtual string OfficeContactNumber { get; set; }
        public virtual string Password { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}

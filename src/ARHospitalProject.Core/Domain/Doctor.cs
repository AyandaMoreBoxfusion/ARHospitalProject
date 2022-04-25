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

    public class Doctor: Person
    {
        public virtual string Qualification { get; set; }
        public virtual DateTime DateEmployed { get; set; }
        public virtual string Password { get; set; }
        public virtual DoctorOfficeReceptionist DoctorOfficeReceptionist { get; set; }
        public virtual Specialization Specialization { get; set; }
    }
}

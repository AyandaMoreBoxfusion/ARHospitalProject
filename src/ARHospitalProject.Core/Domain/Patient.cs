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
    [DiscriminatorValue("ARHis.Person")]

    public class Patient: Person
    {
        public virtual RefListFundingType FundingType { get; set; }

    }
}

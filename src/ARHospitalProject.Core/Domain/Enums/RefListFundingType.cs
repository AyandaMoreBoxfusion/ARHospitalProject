using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARHospitalProject.Domain.Enums
{
    public enum RefListFundingType:int
    {
        [Description("1. Medical Aid")]
        MedicalAid = 1,

        [Description("2. Insurance Claim")]
        InsuranceClaim = 2,

        [Description("3. Cash")]
        Cash = 3

    }
}

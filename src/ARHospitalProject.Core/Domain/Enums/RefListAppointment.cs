using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARHospitalProject.Domain.Enums
{
    public enum RefListAppointment: int
    {
        [Description("1. Attended")]
        Attended = 1,

        [Description("2. Unattended")]
        Unattended = 2,

        [Description("3. Cancelled")]
        Cancelled = 3

    }
}

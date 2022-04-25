﻿using Abp.Domain.Entities.Auditing;
using ARHospitalProject.Domain.Discriminators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARHospitalProject.Domain
{
    [Entity(TypeShortAlias = "ARHis.Person")]
    public class PrescribedMedication: FullAuditedEntity<Guid>
    {
        public virtual string MedicationName { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}

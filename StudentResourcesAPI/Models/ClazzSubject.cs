﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace StudentResourcesAPI.Models
{
    public class ClazzSubject
    {
        public int ClazzId { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public Clazz Clazz { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }
    }
}

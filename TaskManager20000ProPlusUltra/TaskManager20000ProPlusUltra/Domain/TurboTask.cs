﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MathProCorporation.Domain.StatusAvailable;

namespace MathProCorporation.Domain
{
    public class TurboTask
    {
        public string TaskId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TurboStatus Status { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TurboEmployee Employee { get; set; }
    }
}
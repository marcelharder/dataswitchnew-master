﻿using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class VwAspnetApplication
    {
        public string ApplicationName { get; set; }
        public string LoweredApplicationName { get; set; }
        public Guid ApplicationId { get; set; }
        public string Description { get; set; }
    }
}

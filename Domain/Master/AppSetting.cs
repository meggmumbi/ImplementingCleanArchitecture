﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Master
{
    public class AppSetting : BaseEntity<int>
    {
        public string ReferenceKey { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;
    }
}

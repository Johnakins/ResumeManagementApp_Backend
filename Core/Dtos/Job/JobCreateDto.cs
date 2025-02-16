﻿using backend.Core.Enums;

namespace backend.Core.Dtos.Job
{
    public class JobCreateDto
    {
        public string Title { get; set; } = string.Empty;
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
    }
}

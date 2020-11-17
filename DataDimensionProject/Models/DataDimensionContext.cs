using System;

namespace DataDimensionProject.Models
{
    public class DataDimensionContext
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

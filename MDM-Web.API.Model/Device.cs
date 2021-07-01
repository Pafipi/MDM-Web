#nullable enable
using System;

namespace Model
{
    public class Device
    {
        public Guid Id { get; set; }
        public string deviceID { get; set; }
        public string? deviceToken { get; set; }
        public string? Owner { get; set; }
        
    }
}
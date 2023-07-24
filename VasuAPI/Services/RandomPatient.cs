using System;

namespace VasuAPI.Services
{
    public class RandomPatient
    {
        public Guid Id { get; set; }

        public int Age { get; set; }

        public string Disease { get; set; }

        public string Medication { get; set; }

        public string Race { get; set; }
    }
}

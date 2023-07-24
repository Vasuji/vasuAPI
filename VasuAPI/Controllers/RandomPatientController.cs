using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VasuAPI.Services;
using VasuAPI.Models;

namespace VasuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomPatientController : ControllerBase
    {
        private readonly ILogger<RandomPatientController> _logger;

        private static readonly string[] Diseases = new[]
        {
            "Diabetes", "Hypertension", "Asthma", "Cancer", "Heart Disease"
        };
        private static readonly string[] Medications = new[]
        {
            "Metformin", "Lisinopril", "Albuterol", "Tamoxifen", "Atorvastatin"
        };
        private static readonly string[] Races = new[]
        {
            "Asian", "African", "Caucasian", "Hispanic", "Mixed"
        };

        public RandomPatientController(ILogger<RandomPatientController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetRandomPatient", Name = "GetRandomPatient")]
        public IEnumerable<RandomPatient> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new RandomPatient
            {
                Id = Guid.NewGuid(),
                Age = Random.Shared.Next(10, 81),
                Disease = Diseases[Random.Shared.Next(Diseases.Length)],
                Medication = Medications[Random.Shared.Next(Medications.Length)],
                Race = Races[Random.Shared.Next(Races.Length)],
            })
            .ToArray();
        }
    }
}

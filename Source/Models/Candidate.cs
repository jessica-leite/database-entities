using Codenation.Challenge.Models;
using System;

namespace Source.Models
{
    public class Candidate
    {
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public int AccelerationId { get; set; }
        public Acceleration Acceleration { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}

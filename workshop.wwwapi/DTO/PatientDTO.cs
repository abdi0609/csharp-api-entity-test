﻿namespace workshop.wwwapi.DTO
{
    public class PatientDTO
    {
        public int Id { get; set; } 

        public string FullName { get; set; }

        public List<AppointmentDTO> Appointments { get; set; }
    }
}

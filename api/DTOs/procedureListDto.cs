using System;

namespace dataswitch.DTOs{
    public class procedureListDto
    {
        public virtual int procedureId { get; set; }
        public virtual DateTime dateOfSurgery { get; set; }
        public virtual String description { get; set; }
        public virtual String completed { get; set; }
        public virtual double patientId { get; set; }
        public int fd_Type { get; set; }
    }
}
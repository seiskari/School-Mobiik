using System;
using System.Collections.Generic;

namespace SchoolMobiik.Entity
{
    public partial class Work
    {
        public string SchoolSchoolId { get; set; }
        public int TeacherTeacherId { get; set; }

        public School SchoolSchool { get; set; }
        public Teacher TeacherTeacher { get; set; }
    }
}

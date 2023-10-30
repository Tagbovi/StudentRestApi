namespace StudentRestAPI
{
    public class Student
    {
        public int StudentId { get; set; }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public  Gender  Gender {get; set;}
        public int DepartmentId { get; set; }
        public required string PhotoPath { get; set; }

        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth.ToUniversalTime(); }
            internal set { _dateOfBirth = value.ToUniversalTime(); }
        }

        
    }
}

namespace North_DbFirst.Models
{
    public partial class Employee
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

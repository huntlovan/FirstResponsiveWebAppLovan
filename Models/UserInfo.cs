namespace FirstResponsiveWebAppLovan.Models
{
    public class UserInfo
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public DateTime? BirthDate { get; set; } // Extra credit feature

        private const int CurrentYear = 2025; // Use a global constant

        public int AgeThisYear()
        {
            return CurrentYear - BirthYear;
        }

        public int? AgeToday()
        {
            if (BirthDate.HasValue)
            {
                int age = CurrentYear - BirthDate.Value.Year;
                if (BirthDate.Value > DateTime.Today)
                {
                    age--; // If birthday hasn’t occurred yet this year, subtract 1
                }
                return age;
            }
            return null;
        }
    }
}

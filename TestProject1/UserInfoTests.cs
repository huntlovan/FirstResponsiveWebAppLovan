namespace TestProject1
{
    using System;
    using Xunit;
    using FirstResponsiveWebAppLovan.Models;

    public class UserInfoTests
    {
        [Fact]
        public void AgeThisYear_ShouldReturnCorrectAge()
        {
            // Arrange
            var user = new UserInfo { BirthYear = 2000 };

            // Act
            int age = user.AgeThisYear();

            // Assert
            Assert.Equal(25, age); // Since CurrentYear is 2025
        }

        [Theory]
        [InlineData("2000-06-10", 25)]  // Birthday has occurred in 2025
        [InlineData("2000-12-10", 25)]  // Birthday hasn't occurred yet in 2025
        public void AgeToday_ShouldReturnCorrectAge(string birthDate, int expectedAge)
        {
            // Arrange
            var user = new UserInfo { BirthDate = DateTime.Parse(birthDate) };

            // Act
            int? ageToday = user.AgeToday();

            // Assert
            Assert.Equal(expectedAge, ageToday);
        }

        [Fact]
        public void AgeToday_ShouldReturnNull_WhenBirthDateNotProvided()
        {
            // Arrange
            var user = new UserInfo();

            // Act
            int? ageToday = user.AgeToday();

            // Assert
            Assert.Null(ageToday);
        }
    }
}

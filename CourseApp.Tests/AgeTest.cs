using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
    [Fact]
    public void TestAge()
    {
        Assert.Equal("Вам 19 лет, 4 месяцев и 16 дня", AgeClass.Age(21, 8, 2000));
    }

    [Fact]
    public void TestBirthdayAboveToday()
        {
            try
            {
                AgeClass.Age(1, 12, 2056);
            }
            catch (Exception)
            {
                Console.WriteLine("Birthday > Today");
                Assert.True(true);
            }
    }

    [Fact]
    public void TestBirthdayToday()
    {
        Assert.Equal("Вам 0 лет, 0 месяцев и 0 дня", AgeClass.Age(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
    }
    }
}
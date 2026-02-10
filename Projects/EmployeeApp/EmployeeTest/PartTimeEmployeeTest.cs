using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using EmployeeManager;

namespace EmployeeTest
{
    [TestClass]
    public sealed class PartTimeEmployeeTest
    {
        //Initialize
        private PartTimeEmployee _employee;
        [TestInitialize]
        public void Init()
        {
            _employee = new PartTimeEmployee(1, "John Doe", "Sales", 0, 67, 21);
        }

        //CalculatePay
        [TestMethod]
        public void CalculatePay_ShouldReturnCorrectAmount_WhenGivenHourlyRateAndHours()
        {
            var result = _employee.CalculatePay(); Assert.AreEqual(1407, result);
        }

        [TestMethod]
        public void CalculatePay_ShouldReturnZero_WhenHoursWorkedIsZero()
        {
            _employee.HoursWorked = 0;
            var result = _employee.CalculatePay(); Assert.IsTrue(result == 0); // Pay is 0 according to work
        }

        //ToString
        [TestMethod]
        public void ToString_ShouldIncludeHourlyRateAndHoursWorked ()
        {
            var result = _employee.ToString(); Assert.AreEqual("ID: 1, Name: John Doe, Department: Sales, Base Salary: $0.00, Hourly Rate: $67.00, HoursWorked: $21.00", result);
        }
    }
}
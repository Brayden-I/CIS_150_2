using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using EmployeeManager;

namespace EmployeeTest
{
    [TestClass]
    public sealed class FullTimeEmployeeTest
    {
        //Initialize
        private FullTimeEmployee _employee;
        [TestInitialize]
        public void Init()
        {
            _employee = new FullTimeEmployee(5, "Jane Smith", "Human Resources", 40000, 4000);
        }

        //CalculatePay
        [TestMethod]
        public void CalculatePay_ShouldReturnBaseSalaryPlusAnnualBonus()
        {
            var result = _employee.CalculatePay(); Assert.AreEqual(44000, result);
        }

        [TestMethod]
        public void CalculatePay_ShouldReturnOnlyBaseSalary_WhenAnnualBonusIsZero()
        {
            _employee.AnnualBonus = 0;
            var result = _employee.CalculatePay(); Assert.AreEqual(result, 40000); // Pay is 0 according to work
        }

        //ToString
        [TestMethod]
        public void ToString_ShouldIncludeAnnualBonus()
        {
            var result = _employee.ToString(); Assert.AreEqual("ID: 5, Name: Jane Smith, Department: Human Resources, Base Salary: $40,000.00, Annual Bonus: $4,000.00, Total Pay: $44,000.00", result);
        }
    }
}
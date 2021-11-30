using Moq;
using Xunit;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Services;
using UnitTest_Mock.Models;

namespace UnitTesting
{
    public class EmployeeTest
    {
        #region
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        [Fact]
        public async void GetEmployeeById()
        {
            mock.Setup(p => p.GetEmployeebyId(1)).ReturnsAsync("JK");
            EmployeeController emp = new EmployeeController(mock.Object);
            var result = await emp.GetEmployeeById(1);
            Assert.Equal("JK", result);
        }


        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "JK",
                Designation = "SDE"
            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            EmployeeController emp = new EmployeeController(mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));

        }
    }
}

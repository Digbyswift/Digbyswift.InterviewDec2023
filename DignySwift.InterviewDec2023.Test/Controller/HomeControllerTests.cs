using Digbyswift.InterviewDec2023.Infrastructure;
using Digbyswift.InterviewDec2023.Infrastructure.Models;
using Digbyswift.InterviewDec2023.UI.Controllers;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DignySwift.InterviewDec2023.Test.Controller
{
    public class HomeControllerTests
    {
        private HomeController _homeController;
        private IStaffRepository _staffRepository;
        public HomeControllerTests()
        {
            _staffRepository = A.Fake<IStaffRepository>();

            //bring in controller
            _homeController = new HomeController(_staffRepository);
        }

        [Fact]
        public void HomeController_Index_ReturnsSuccess()
        {
            //arrange
            var staffs = A.Fake<IEnumerable<Staff>>();
            A.CallTo(() => _staffRepository.GetAllStaffNames()).Returns(staffs);
            //act
            var results = _homeController.Index();
            //assert
            results.Should().BeOfType<Task<IActionResult>>();
        }
        
        [Fact]
        public void HomeController_Get_ReturnsSuccess()
        {
            var id = 1;
            var staff = A.Fake<Staff>();
            A.CallTo(() => _staffRepository.Get(id));
            var result = _homeController.Get(id);
            result.Should().BeOfType<Task<Staff>>();
        }
    }
}

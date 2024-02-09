using Digbyswift.InterviewDec2023.Infrastructure;
using Digbyswift.InterviewDec2023.Infrastructure.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DignySwift.InterviewDec2023.Test.Repository
{
    public class StaffRepositoryTests
    {
        [Fact]
        public async void StaffRepository_Get_ReturnsStaff()
        {
            var id = 1;
            var staffRepository = new StaffRepository();

            var result = staffRepository.Get(id);

            result.Should().NotBeNull();
            result.Should().BeOfType<Task<Staff>>();
        }
    }
}

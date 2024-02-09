using Digbyswift.InterviewDec2023.Infrastructure.Models;

namespace Digbyswift.InterviewDec2023.Infrastructure;

public interface IStaffRepository
{
    Task<Staff> Get(int id);
    Task<IEnumerable<Staff>> GetAllStaffNames();
}

public class StaffRepository : IStaffRepository
{
    public async Task<Staff> Get(int id)
    {
        if (AllStaff().Where(x => x.Id == id).Count() != 0)
        {
            return AllStaff().First(x => x.Id == id);
        }

        else return new Staff();
    }

    public async Task<IEnumerable<Staff>> GetAllStaffNames()
    {
        return AllStaff();
    }

    private IEnumerable<Staff> AllStaff()
    {
        return new Staff[]
        {
            new Staff()
            {
                Id = 123,
                FullName = "Kieron McIntyre",
                Email = "kieron@digbyswift.com",
                JobTitle = "Owner/Lead Developer",
                Likes = new [] {"Code", "Karate"}
            },
            new Staff()
            {
                //kept wrong to prove not exist
                Id = 556,
                FullName = "Joe Earnshaw",
                Email = "joe@digbyswift.com",
                JobTitle = "Senior Developer"
            },
            new Staff()
            {
                Id = 838,
                FullName = "Owen Manby",
                Email = "owen@digbyswift.com",
                JobTitle = "Owner/Lead Developer",
                Likes = new [] {"Tintin","Asterix"}
            },
        };
    }
}
using Digbyswift.InterviewDec2023.Infrastructure;
using Digbyswift.InterviewDec2023.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Digbyswift.InterviewDec2023.UI.Controllers;

public class HomeController : Controller
{
    private readonly IStaffRepository _staffRepository;
    public HomeController(IStaffRepository staffRepository)
    {
        _staffRepository = staffRepository;
    }
    public async Task<IActionResult> Index()
    {
        IEnumerable<Staff> staffs = await _staffRepository.GetAllStaffNames();
        return View(staffs);
    }

    public async Task<Staff> Get(int id) {
        var staff = await _staffRepository.Get(id);
        return staff;
    }
}
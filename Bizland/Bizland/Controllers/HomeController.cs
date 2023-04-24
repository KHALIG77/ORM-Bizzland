
using System.Linq;
using Bizland.Data_Access;
using Bizland.ViewModels;
using Microsoft.AspNetCore.Mvc;

    public class HomeController:Controller
    {
    private readonly DataContext _data;

    public HomeController(DataContext data)
    {

        _data = data;
    }
    public ActionResult Index()
    {
        HomeViewModel vm = new HomeViewModel();
        vm.Services = _data.Service.ToList();
        vm.Members =_data.TeamMembers.ToList(); 

        return View(vm);
    }
    }


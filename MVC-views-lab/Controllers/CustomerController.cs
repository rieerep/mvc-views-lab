using Microsoft.AspNetCore.Mvc;
using MVC_views_lab.Models;
using MVC_views_lab.Models.ViewModel;

namespace MVC_views_lab.Controllers
{
    public class CustomerController : Controller
    {
        CustomerModel[] customers =
            {
                new CustomerModel { Id = 0, Name="Erkan", Email ="erk@me.com", Info = "Gold"},
                new CustomerModel { Id = 1, Name="Bob", Email ="bob@live.se", Info = "Platinum"},
                new CustomerModel { Id = 2, Name="Tove", Email="evot@mail.com", Info="Gold"}
            };

        //GET: customer/index
        public IActionResult Index()
        {

            return View(customers);
        }

        //EDIT /Customer/Edit/1
        
        public IActionResult Edit(int id)
        {

            CustomerModel customer = customers[id];

            //EditCustomerViewModel editPerson = new EditCustomerViewModel
            //{
            //    //Name = customer.Name,
            //    Email = customer.Email,
            //};

            return View(customer);
        }
    }
}

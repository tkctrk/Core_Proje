using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        public IViewComponentResult Invoke()
        {          
            ContactManager cm = new ContactManager(new EfContactDal());
            var values = cm.TGetList();
            return View(values);
        }
    }
}

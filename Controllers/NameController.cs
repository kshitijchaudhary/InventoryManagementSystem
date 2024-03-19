using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32.SafeHandles;

namespace InventoryManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
       

        public NameController()
        {
            // dbobject = orm db 
        }

        [HttpGet(Name = "GetName")]
        public String Get()
        {
            return "Hello  World";

            //db.Customers.returnAlla());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Orders.Backend.UnitOfWork.Interfaces;
using Orders.Share.Entities;

namespace Orders.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : GenericController<Category>
    {
        public CategoriesController(IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

[Route("api/[controller]")]
[ApiController]
public class ProductCategoryController : ControllerBase{

    private readonly DatabaseContext context;

    public ProductCategoryController(DatabaseContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ProductCategory>> Get()
    {
        return context.ProductCategories.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<ProductCategory> Get(int id)
    {
        var productCategory = context.ProductCategories.Find(id);
        if (productCategory == null)
        {
            return NotFound();
        }
        return productCategory;
    }

    [HttpPost]
    public ActionResult<ProductCategory> Post(ProductCategory productCategory)
    {
        if (productCategory == null)
        {
            return BadRequest();
        }

        context.ProductCategories.Add(productCategory);
        context.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = productCategory.ProductCategoryId }, productCategory);
    }

    [HttpDelete("{id}")]
    public ActionResult<ProductCategory> Delete(int id)
    {
        var productCategory = context.ProductCategories.Find(id);
        if (productCategory == null)
        {
            return NotFound();
        }
        context.ProductCategories.Remove(productCategory);
        context.SaveChanges();
        return productCategory;
    }

}
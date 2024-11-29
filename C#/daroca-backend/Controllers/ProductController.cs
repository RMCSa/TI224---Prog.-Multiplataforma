using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

[Route("api/[controller]")]
[ApiController]

public class ProductController : ControllerBase
{
    private readonly DatabaseContext context;

    public ProductController(DatabaseContext context)
    {
        this.context = context;
    }

    [HttpGet("/test")]
    public ActionResult<string> Test()
    {
        return "Hello World";
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        return context.Products.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        var product = context.Products.Find(id);
        if (product == null)
        {
            return NotFound();
        }
        return product;
    }

    [HttpPost]
    public ActionResult<Product> Post(Product product)
    {
        if (product == null)
        {
            return BadRequest();
        }

    
        context.Products.Add(product);
        context.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = product.ProductId }, product);
    }

    [HttpDelete("{id}")]
    public ActionResult<Product> Delete(int id)
    {
        var product = context.Products.Find(id);
        if (product == null)
        {
            return NotFound();
        }
        context.Products.Remove(product);
        context.SaveChanges();
        return product;
    }


    

}

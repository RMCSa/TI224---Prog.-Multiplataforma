using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase{
    private readonly DatabaseContext context;

    public CustomerController(DatabaseContext context){
        this.context = context;
    }

    [HttpGet("/test")]
    public ActionResult<string> Test(){
        return "Hello World";
    }

    [HttpGet]
    public ActionResult<IEnumerable<Customer>> GetCustomer(){
        return this.context.Customers.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Customer> GetCustomer(int id){
        var customer = this.context.Customers.Find(id);
        if(customer == null){
            return NotFound();
        }
        return customer;
    }

    [HttpPost]
    public ActionResult<Customer> CreateCustomer(Customer customer){
        if (customer == null){
            return BadRequest();
        }
        this.context.Customers.Add(customer);
        this.context.SaveChanges();
        return CreatedAtAction(nameof(GetCustomer), new { id = customer.CustomerId }, customer);
    }

    [HttpDelete("{id}")]
    public ActionResult<Customer> DeleteCustomer (int id){
        var existCustomer = this.context.Customers.Find(id);
        if (existCustomer == null){
            return NotFound();
        }
        this.context.Customers.Remove(existCustomer);
        this.context.SaveChanges();
        return existCustomer;

    }
}
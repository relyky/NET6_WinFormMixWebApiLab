using DemoSysComm;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoSysAPI.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class MyValueController : ControllerBase
{
  readonly static List<MyValue> _values = new() {
    new() { Id = 1, Value = "value1"},
    new() { Id = 2, Value = "value2"},
    new() { Id = 3, Value = "value3"}
  };

  // GET: api/<MyValueController>
  [HttpGet]
  public IEnumerable<MyValue> Get()
  {
    return _values;
  }

  // GET api/<MyValueController>/5
  [HttpGet("{id}")]
  public string Get(int id)
  {
    return "value";
  }

  // POST api/<MyValueController>
  [HttpPost]
  public void Post([FromBody] string value)
  {
  }

  // PUT api/<MyValueController>/5
  [HttpPut("{id}")]
  public void Put(int id, [FromBody] string value)
  {
  }

  // DELETE api/<MyValueController>/5
  [HttpDelete("{id}")]
  public void Delete(int id)
  {
  }
}

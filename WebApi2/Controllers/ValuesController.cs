using CommonRes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
  readonly static List<MyValue> _values = new() {
    new() { Id = 1, Value = "value1"},
    new() { Id = 2, Value = "value2"},
    new() { Id = 3, Value = "value3"}
  };

  // GET: api/<ValuesController>
  [HttpGet]
  public List<MyValue> Get()
  {
    return _values;
  }

  // GET api/<ValuesController>/5
  [HttpGet("{id}")]
  public MyValue? Get(int id)
  {
    return _values.FirstOrDefault(c => c.Id == id);
  }

  // POST api/<ValuesController>
  [HttpPost]
  public MyValue Post([FromBody] MyValue formData)
  {
    formData.Id = _values.Max(c => c.Id) + 1;
    _values.Add(formData);
    return formData;
  }

  // PUT api/<ValuesController>/5
  [HttpPut]
  public MyValue? Put([FromBody] MyValue formData)
  {
    int idx = _values.FindIndex(c => c.Id == formData.Id);
    if (idx > 0)
    {
      _values[idx].Value = formData.Value;
      return _values[idx];
    }

    return null;
  }

  // DELETE api/<ValuesController>/5
  [HttpDelete("{id}")]
  public int Delete(int id)
  {
    int idx = _values.FindIndex(c => c.Id == id);
    if(idx > 0)
    {
      _values.RemoveAt(idx);
      return 1;
    }

    return 0;
  }
}

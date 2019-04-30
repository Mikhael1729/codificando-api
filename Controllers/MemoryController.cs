using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using codificando_api.Models;
using codificando_api.Repositories;

namespace codificando_api.Controllers
{
  [Route("api/memories")]
  [ApiController]
  public class MemoryController : ControllerBase
  {
    List<Memory> memories = MemoryRepository.Memories;

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Memory>> Get() => memories;

    // GET api/memory/5.
    [HttpGet("{id}")]
    public ActionResult<Memory> Get(int id) => memories.FirstOrDefault(m => m.Id == id);

    // POST api/values
    [HttpPost]
    public void Post([FromBody] Memory memory) => memories.Add(memory);

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id) => memories.Remove(memories.FirstOrDefault(m => m.Id == id));
  }
}
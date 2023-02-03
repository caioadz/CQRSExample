using CQRSExample.Commands;
using CQRSExample.Commands.Address;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRSExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly CommandResolver commandResolver;

        public AddressController(CommandResolver commandBuilder)
        {
            this.commandResolver = commandBuilder;
        }

        // GET: api/<AddressController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AddressController>
        [HttpPost]
        public IActionResult Post(AddAddressCommand command)
        {            
            var result = commandResolver.Execute<AddAddressCommand, AddAddressCommandResult>(command);

            //Same command with void result
            commandResolver.Execute(command);

            return Ok(result);
        }

        // PUT api/<AddressController>/5
        [HttpPut("{id}")]
        public IActionResult Put(UpdateAddressCommand command)
        {
            commandResolver.Execute(command);
            return Ok();
        }

        // DELETE api/<AddressController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(RemoveAddressCommand command)
        {
            commandResolver.Execute(command);
            return Ok();
        }
    }
}

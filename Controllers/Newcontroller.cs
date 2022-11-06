//aisha mashrah
//nov 6 2022
//Restaurant Picker - Endpoint




using Microsoft.AspNetCore.Mvc;

namespace MashrahARestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("restaurantpicker")]

    public string restaurantPicker()
    {
        return "it will choose 3 different types of food for you it will also chooes a random place for you to eat in that catagory";
    } 
}

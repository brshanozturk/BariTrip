using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using BarilTripp.Areas.Admin.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace BarilTripp.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult>Index()
        {  
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?units=metric&locale=en-gb&checkin_date=2024-05-19&dest_type=city&order_by=popularity&filter_by_currency=EUR&adults_number=2&room_number=1&dest_id=-1456928&checkout_date=2024-05-20&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&children_ages=5%2C0&children_number=2"),
                Headers =
    {
        { "X-RapidAPI-Key", "3b0ce02eecmsh126385873090640p1bd063jsn85814c3cb2d0" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values =JsonConvert.DeserializeObject<BookingHotelSearhViewModel>(body);
                return View(values.results);
            }
          
        }

       

        
    }
}

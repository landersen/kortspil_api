using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace MicroserviceAPI.Controllers
{
    [ApiController]
    [Route("/Card")]
    public class CardController : ControllerBase
    {

        [HttpGet("/RandomCard/", Name = "GetRandomCard")]
        public object generateRandomCard()
        {
            Card card = new Card();
            //return "Her er dit kort: " + card.Kuloer + " " + card.number;
            //return card; // returnere json i stedet for en lang string - vist ovenover

            List<Card>spillekort = card.lavBunkeAfKortSpil();
            Random r = new Random();
            return spillekort[r.Next(1,55)];
        }
    }
}
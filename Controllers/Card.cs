using System.Diagnostics.Metrics;

namespace MicroserviceAPI.Controllers
{
    public class Card
    {
        public int number { get; set; }
        public string type { get; set; }

        public Card()
        {
            Random random = new Random();
            int kuloer = random.Next(1, 4);
            Kuloer k = (Kuloer)kuloer;
            type = k.ToString();
            this.number = random.Next(1, 14); // 14 fordi ellers rammer vi ikke 13
        }

        public Card(int number, Kuloer k)
        {
            this.number = number;
            type = k.ToString();
        }

        public List<Card> lavBunkeAfKortSpil()
        {
            List<Card> spilleKort = new List<Card>();
            foreach (var item in Enum.GetValues(typeof(Kuloer)).Cast<Kuloer>())
            {
                if (item == Kuloer.Joker)
                    continue;
                for (int i = 1; i < 14; i++)
                {
                    spilleKort.Add(new Card(i, item));
                }
            }
            spilleKort.Add(new Card(99, Kuloer.Joker));
            spilleKort.Add(new Card(99, Kuloer.Joker));
            spilleKort.Add(new Card(99, Kuloer.Joker));
            return spilleKort;
        }
    }
}

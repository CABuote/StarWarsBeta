using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public class Jedis
    {
        private List<string> jedisList = new() { "Luke Skywalker, Yoda, Obi-Wan Kenobi" };
        public List<string> GetList()
        {
            return jedisList;
        }

        // enter saber or blaster for options on character

    }


}

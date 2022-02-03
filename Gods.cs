using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public class DarkLords
    {
       private List<string> darkLordList = new() { "Darth Vader, Darth Maul, Lord Sith" };
       public List<string> GetList()
         {
            return darkLordList;
      
         }
        // enter saber or blaster for options on character
    }

}




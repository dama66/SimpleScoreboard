using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfScreenHelper;

namespace SimpleScoreboard
{
    public static class VM
    {
        public static Display Display { get; set; } = new Display();

        public static Game Game { get; set; } = new Game();

        
    }
}

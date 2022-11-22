using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    [Serializable]
    internal class ListComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Anonation { get; set; }
        public string Type { get; set; }
        public string Author { get; set; }
        public string UseConditions { get; set; }
        public string Address { get; set; }
    }
    
    
}

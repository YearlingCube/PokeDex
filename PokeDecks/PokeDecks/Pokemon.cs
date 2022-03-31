using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace PokeDecks
{
    class Pokemon
    {
        public string m_Name { get; set; }
        public string m_Type { get; set; }
        public string m_Ability { get; set; }
        public string m_Description { get; set; }
        public string m_Picture { get; set; }
        public int m_HP { get; set; }
        public int m_Number { get; set; }
    }
}

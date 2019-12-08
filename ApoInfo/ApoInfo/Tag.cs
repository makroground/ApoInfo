using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoInfo
{
    [Serializable]
    public class Tag
    {
        public string Datum { get; set; }
        public string InhaltApotheke_eins { get; set; }
        public string InhaltApotheke_zwei { get; set; }
        public string InhaltApotheke_drei { get; set; }
        public string InhaltApotheke_vier { get; set; }
    }
}

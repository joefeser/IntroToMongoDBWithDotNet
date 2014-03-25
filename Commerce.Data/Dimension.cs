using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data {

    [DebuggerDisplay("l:{Length} h:{Height} w:{Width} weight:{Weight}")]
    public class Dimension {

        public decimal Length {
            get;
            set;
        }

        public decimal Height {
            get;
            set;
        }

        public decimal Width {
            get;
            set;
        }

        public decimal Weight {
            get;
            set;
        }

    }
}

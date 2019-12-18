using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public interface Laser
    {
     
        speedpower wengraving { get; }
        speedpower aengraving { get;  }
        speedpower wcutting14 { get; }
        speedpower wcutting18 { get; }
        speedpower acutting14 { get; }
        speedpower acutting18 { get; }
        speedpower wcombined14 { get; }
        speedpower wcombined18 { get; }
        speedpower acombined14 { get; }
        speedpower acombined18 { get; }
    }
}

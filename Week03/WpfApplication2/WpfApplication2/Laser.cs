using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public interface Laser
    {
        speedpower photo { get; }
        speedpower engraving300 { get; }
        speedpower engraving600 { get;  }
        speedpower cutting14 { get; }
    }
}

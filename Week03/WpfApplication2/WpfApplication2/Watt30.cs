using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class Watt30 : Laser
    {
        public speedpower cutting14
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 2;
                cutting.power = 100;
                return cutting;
            }
        }

        public speedpower engraving300
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public speedpower engraving600
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public speedpower photo
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}

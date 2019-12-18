using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class Watt40 : Laser
    {
        public Watt40()
        {
        }

        public speedpower wcutting14
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 1;
                cutting.power = 100;
                return cutting;
            }
        }

        public speedpower wcutting18
        {
            get
            {
                speedpower engraving = new speedpower();
                engraving.speed = 6;
                engraving.power = 100;
                return engraving;
            }
        }

        public speedpower wengraving
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 40;
                cutting.power = 50;
                return cutting;

            }
        }

        public speedpower acutting14
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 25;
                cutting.power = 100;
                return cutting;

            }
        }
        public speedpower acutting18
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 8;
                cutting.power = 100;
                return cutting;

            }
        }
        public speedpower wcombined14
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 40;
                cutting.power = 100;
                return cutting;                

            }
        }
        public speedpower wcombined18
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 35;
                cutting.power = 100;
                return cutting;

            }
        }
        public speedpower aengraving
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 35;
                cutting.power = 90;
                return cutting;

            }
        }
        public speedpower acombined14
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 100;
                cutting.power = 100;
                return cutting;

            }
        }
        public speedpower acombined18
        {
            get
            {
                speedpower cutting = new speedpower();
                cutting.speed = 8;
                cutting.power = 100;
                return cutting;

            }
        }
    }
}

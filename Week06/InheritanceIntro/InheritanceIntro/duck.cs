using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
   public class duck : Animal
    {

      

        public duck() { }

        public duck(int height, string name)
        {
            this.Height = height;
            this.Name = name;
        }

        public void Quack()
        {
            MessageBox.Show("Quack");
        }
    }
}

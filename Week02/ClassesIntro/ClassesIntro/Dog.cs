using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string Breed;
        public int Height;
        public string Name;
        public string Color;
        private string v1;
        private int v2;
        private string dogName;

        public Dog(string v1, string dogName, int v2 )
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dogName = dogName;
        }

        public void Bark()
        {
            MessageBox.Show("Bark");
        }

        public void SayName()
        {
            MessageBox.Show("my name is " + Name);
        }

       

        public Dog() { }

        public Dog(string breed, int height, string name)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
        
        }
    }
}

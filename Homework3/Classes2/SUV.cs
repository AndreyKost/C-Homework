using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class SUV : Car
    {
        private bool visokoProhodim;
    

          public bool VisokoProhodim
          {
            get { return visokoProhodim; }
            set { visokoProhodim = value; }
          }
         public SUV(int price, bool visokoProhodim)
            : base(price)
        {
            this.visokoProhodim = visokoProhodim;
        }
    
    
    }
}

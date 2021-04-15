using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After2
{
    class Rect
    {
        public int w;
        public int h;

        public int getArea()
        {

            return w * h;
        }
/* public int getArea()
        {

            return w * h;
        }*/
        public int width;
        public void setwidth(int width)
        {
            if (width < 0)
                this.width = 0;
            else
                
            this.width=width ;
        }
        public int getwidth()
        {
            return this.width;
        }
        
        public int height;
        public void setheight(int height)
        {if (height < 0)
                this.height = 0;
            this.height = height;
        }
        public int getheight()
        {
            return this.height;
        }
        public int getArea_with_getset()
        {
            return width * height;
        }
       
    }
}

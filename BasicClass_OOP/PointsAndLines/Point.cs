using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass_OOP.PointsAndLines //namespaces.
{
    internal class Point //objects
    {
        private int x; //fields.
        private int y;

        //sa field type need gamitin ay CamelCase, kapag properties PascalCase.

        public int X
        {
            get 
            { 
                return x; // just returns the value of the field you are using.
            }
            set 
            { 
                x = value; // this keyword basically give the value you assigned to the property.
                
            }
        
        }

        //another argument that takes empty parameters.

        public Point()
        {

        }

        public Point(int x, int y) // constructor
        {
            this.x = x;
            this.y = y; //lets u use the fields, parang this is letting you know na we are pointing it in the X of the Class and
                        //making it equal sa X ng constructors.
        }
    }
}

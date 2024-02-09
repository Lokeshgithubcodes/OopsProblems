using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblems
{
    class PolymorphismShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class Circle : PolymorphismShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Square : PolymorphismShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }


}

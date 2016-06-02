using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shooter;
using FormPrototype.Properties;
using System.Drawing;

namespace FormPrototype
{
    class PointTest : CImageBase
    {
        private Rectangle pointRectangle = new Rectangle();

        public PointTest() : base(Resources.RedDot)
        {
            pointRectangle.X = 10;
            pointRectangle.Y = 10;
        }

        public void Update(int X, int Y)
        {
            Left = X;
            Top = Y;
            pointRectangle.X = Left;
            pointRectangle.Y = Top;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(pointRectangle.X.ToString());
            sb.Append(", ");
            sb.Append(pointRectangle.Y.ToString());
            return sb.ToString();
        }
    }
}

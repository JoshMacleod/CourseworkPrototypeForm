using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shooter
{
    class CImageBase : IDisposable //CImageBase inheriting methods and properties from IDisposable
    {
        bool disposed = false;

        Bitmap bitmap;
        private float X;

        public float Left
        {
            get { return X; }
            set { X = value; }
        }

        private float Y;

        public float Top
        {
            get { return Y; }
            set { Y = value; }
        }

        public CImageBase(Bitmap resource)
        {
            bitmap = new Bitmap(resource);
        }

        public void DrawImage(Graphics gfx)
        {
            gfx.DrawImage(bitmap, X, Y);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                bitmap.Dispose();
            }
            disposed = true;
        }
    }
}

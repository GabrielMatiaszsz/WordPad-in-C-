using System;

namespace BlocoDeNotas
{
    internal class Drawing
    {
        private string v;
        private IntPtr mainWindowHandle;

        public Drawing(string v)
        {
            this.v = v;
        }

        public Drawing(IntPtr mainWindowHandle)
        {
            this.mainWindowHandle = mainWindowHandle;
        }

        internal void Save(string v)
        {
            throw new NotImplementedException();
        }
    }
}
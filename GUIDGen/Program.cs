using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUIDGen
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            System.Windows.Forms.Clipboard.SetText(Guid.NewGuid().ToString());
        }
    }
}

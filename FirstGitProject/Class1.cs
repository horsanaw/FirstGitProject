using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGitProject
{
    class Class1
    {
       private string marka;
       private string modell;
       private string evjarat;
       private string kilometer;
       private string uzemanyag;
       private string ar;

        public Class1(string marka, string modell, string evjarat, string kilometer, string uzemanyag, string ar)
        {
            this.marka = marka;
            this.modell = modell;
            this.evjarat = evjarat;
            this.kilometer = kilometer;
            this.uzemanyag = uzemanyag;
            this.ar = ar;
        }

        public override string ToString()
        {
            return marka + " " + modell + " " + evjarat + " " + kilometer + " " + uzemanyag + " " + ar + " ";
        }
    }

}
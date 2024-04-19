using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUPSISModel;

namespace PUPSISDataLayer
{
    public class FeeData
    {
        public Fee Fee(){
            Fee pending = new Fee { category = "Balanced Fee", amount = 2000 };
            return pending;

        }
    }
}

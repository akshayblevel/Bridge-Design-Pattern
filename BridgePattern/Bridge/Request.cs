using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Request
    {
        public IRequestRecharge RequestRecharge { get; set; }
        public string Operator { get; set; }
        public string  Mobile { get; set; }
        public int Amount { get; set; }

        public abstract void Recharge();
    }
}

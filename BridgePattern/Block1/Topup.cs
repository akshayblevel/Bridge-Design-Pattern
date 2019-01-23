using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Topup : Request
    {
        public override void Recharge()
        {
            RequestRecharge.DoRecharge(Operator, Mobile, Amount);
        }
    }
}

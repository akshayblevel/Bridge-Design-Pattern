using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface IRequestRecharge
    {
        void DoRecharge(string Operator, string Mobile, int Amount);
    }
}

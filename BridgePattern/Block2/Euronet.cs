using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Euronet : IRequestRecharge
    {
        public void DoRecharge(string Operator, string Mobile, int Amount)
        {
            Console.WriteLine("Euronet\n{0}\n{1}\n{2}\n", Operator, Mobile,Amount);
        }
    }
}

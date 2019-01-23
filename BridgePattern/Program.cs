using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        { 
            IRequestRecharge euronet = new Euronet();
            IRequestRecharge cyberplat = new CyberPlat();
            IRequestRecharge lapu = new LAPU();

            Request request = new Topup();
            request.Operator = "VOD";
            request.Mobile = "9769496026";
            request.Amount = 100;

            request.RequestRecharge = euronet;
            request.Recharge();

            DTH dth = new DTH();
            dth.Operator = "D2H";
            dth.Mobile = "9825134178";
            dth.Amount = 300;

            dth.RequestRecharge = lapu;
            dth.Recharge();

            Console.ReadKey();
        }
    }
}

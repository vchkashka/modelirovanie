using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelirovanie
{
    
    public class Program
    {
        
        static void Main(string[] args)
        {
            double N_obs_sr = 0, N_neobs_sr = 0, T_pr = 0, T_obr = 0, K = 0;
            double D1 = 0, D2 = 0, D3 = 0, D4 = 0, D5 = 0;
            for (int i = 0; i < 50; i++)
            {
                ConveyorSystem conveyorSystem = new ConveyorSystem(5, 0, 4, 240); // количество станков, места в буфере, интенсивность прихода заявок, время симуляции прихода заявок в минутах

                (double, double, double, double, double) tuple = conveyorSystem.Simulate();
                //N_obs_sr += tuple.Item1 / 50;
                //N_neobs_sr += tuple.Item2 / 50;
                //T_pr += tuple.Item3 / 50;
                //T_obr += tuple.Item4 / 50;
                //K += tuple.Item5 / 50;

                D1 += (tuple.Item1 - 463.26) * (tuple.Item1 - 463.26);
                D2 += (tuple.Item2 - 502.78) * (tuple.Item2 - 502.78);
                D3 += (tuple.Item3 - 133.98) * (tuple.Item3 - 133.98);
                D4 += (tuple.Item4 - 59.64) * (tuple.Item4 - 59.64);
               // D5 += (tuple.Item5 - 463.26) * (tuple.Item5 - 463.26);
            }

            //Console.WriteLine("N_obs_sr =" + N_obs_sr);
            //Console.WriteLine("N_neobs_sr =" + N_neobs_sr);
            //Console.WriteLine("T_pr =" + T_pr);
            //Console.WriteLine("T_obr =" + T_obr);
            //Console.WriteLine("K =" + K); 
            
            Console.WriteLine("D1 =" + D1/50);
            Console.WriteLine("D2 =" + D2 / 50);
            Console.WriteLine("D3 =" + D3 / 50);
            Console.WriteLine("D4 =" + D4 / 50);
           // Console.WriteLine("K =" + D5 / 50);
            Console.ReadKey();
        }
    }
}

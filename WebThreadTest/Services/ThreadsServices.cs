using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebThreadTest.Services
{
    public class ThreadsServices
    {
        /*Paralelo and Async*/
        public async Task<int> Thread1(int time)
        {
            return  await Task.Run(() =>
            {
                Thread.Sleep(time);

                return 1;
            });

        }
        public async Task<int> Thread2(int time)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(time);
                return 2;
            });
        }
        public async Task<int> Thread3(int time)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(time);
                return 3;
            });
        }
        public async Task<int> Thread4(int time)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(time);
                return 4;
            });
        }


        /*Paralelo and Not Async*/
        //public int Thread1(int time)
        //{
        //    Thread.Sleep(time);

        //    return 1;

        //}
        //public int Thread2(int time)
        //{
        //    Thread.Sleep(time);
        //    return 2;
        //}
        //public int Thread3(int time)
        //{
        //    Thread.Sleep(time);
        //    return 3;
        //}
        //public int Thread4(int time)
        //{
        //    Thread.Sleep(time);
        //    var res = 4;
        //    return res;
        //}
    }
}
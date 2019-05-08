using System;
using System.Collections.Generic;

namespace Version_1_C
{
    [Serializable]
    //public sealed class clsDateComparer : IComparer<clsWork> p2
    //public sealed class Singleton
    //{
    //    private static Singleton instance = null;
    //    private static readonly object padlock = new object();

    //    Singleton()
    //    {
    //    }

    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            lock (padlock)
    //            {
    //                if (instance == null)
    //                {
    //                    instance = new Singleton();
    //                }
    //                return instance;
    //            }
    //        }
    //    }
    //}
    //------------------------------------------------------------------------------------------------
    public sealed class clsDateComparer : IComparer<clsWork>
    {
        public static clsDateComparer Instance { get { return clsDateComparer.instance; } }

        private static readonly clsDateComparer instance = new clsDateComparer();
        private clsDateComparer()
        { }
        
        public int Compare(clsWork x, clsWork y)
        {

            return x.Date.CompareTo(y.Date);
        }

    }


        /////--------------------------------------------------------------------------------------------
        //public int Compare(clsWork x, clsWork y)
        //{

        //  return x.Date.CompareTo(y.Date);

        //    //clsWork lcWorkX = (clsWork)x; Q11
        //    //clsWork lcWorkY = (clsWork)y; Q11
        //    //DateTime lcDateX = x.Date; Xtra
        //    //DateTime lcDateY = y.Date; Xtra

        //    return x.Date.CompareTo(y.Date); //lcDateX.CompareTo(lcDateY); Xtra use this if it doesnt work

        //    //x.date.CompareTo(y.date)
        //}
        // }
    
}

    //class Singleton
    //{
    //    public static readonly Singleton _obj = new Singleton();


    //    public int Compare(clsWork x, clsWork y)
    //    {

    //        return x.Date.CompareTo(y.Date); //lcDateX.CompareTo(lcDateY); Xtra use this if it doesnt work

           
    //    }

    //    Singleton () { }
    //}
    


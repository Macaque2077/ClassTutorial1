using System;
using System.Collections.Generic;

namespace Version_1_C
{
    [Serializable]
    public sealed class clsNameComparer : IComparer<clsWork>
    {
        public static clsNameComparer Instance { get { return clsNameComparer.instance; } }

        private static readonly clsNameComparer instance = new clsNameComparer();

        private clsNameComparer() { }
        public int Compare(clsWork x, clsWork y)
        {
            //clsWork lcWorkClassX = (clsWork)x;
            //clsWork lcWorkClassY = (clsWork)y;
            string lcNameX = x.Name;
            string lcNameY = y.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }
}


        //class clsNameComparer : IComparer<clsWork>
        //{

        //    public int Compare(clsWork x, clsWork y)
        //    {
        //        //clsWork lcWorkClassX = (clsWork)x;
        //        //clsWork lcWorkClassY = (clsWork)y;
        //        string lcNameX = x.Name;
        //        string lcNameY = y.Name;

        //        return lcNameX.CompareTo(lcNameY);
        //    }
        //}
    

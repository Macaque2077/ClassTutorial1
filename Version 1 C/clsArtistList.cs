using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Windows.Forms;



namespace Version_1_C
{
    [Serializable()]



    public class clsArtistList : SortedList<string, clsArtist>
    {
        
        public static string _errorMessage;

        //public void editArtist(string prKey)
        //{
        //    clsArtist lcArtist = (clsArtist)this[prKey];
        //    //lcArtist = (clsArtist)this[prKey];
        //    if (lcArtist != null)
        //      //  lcArtist.EditDetails();
        //    else
        //        throw new Exception();
        //    //MessageBox.Show("Sorry no artist by this name");
        //}



        public decimal getTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsArtist lcArtist in Values)
            {   //.TotalValue instead of .GetWorksValue Q8
                lcTotal += lcArtist.TotalValue;
            }
            return lcTotal;
        }

        private const string _FileName = "gallery.dat";

        public void Save()
        {
            _errorMessage = "";
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, this);
                lcFileStream.Close();
            }
            catch (Exception e)
            {
                _errorMessage = Convert.ToString(e);
                //MessageBox.Show(e.Message, "File Save Error");
            }
        }

        public static clsArtistList Retrieve()
        {
            clsArtistList lcArtistList;

            _errorMessage = "";

            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcArtistList = (clsArtistList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();

            }

            catch (Exception e)
            {
                lcArtistList = new clsArtistList();
                _errorMessage = Convert.ToString(e);
                //MessageBox.Show(e.Message, "File Retrieve Error");

            }

            return lcArtistList;
        }

        //public void newArtistList() // test fucntion to solve null artist list error
        //{
        //    clsArtistList lcArtistList;
        //    lcArtistList = new clsArtistList();
        //}
        public string msgError          
            {
            get
            {
                return _errorMessage;
            }
            }
    }
}

using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;
        
        private decimal _TotalValue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;

        //private static frmArtist _artistDialog = new frmArtist();  removed this q2 p7
        //public static readonly p2
        //private static frmArtist _artistDialog = frmArtist.Instance;   //p2
        public decimal TotalValue { get => _TotalValue; set => _TotalValue = value; }
        public clsWorksList WorksList { get => _WorksList; set => _WorksList = value; }
        public clsArtistList ArtistList { get => _ArtistList; set => _ArtistList = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Speciality { get => _Speciality; set => _Speciality = value; }
        public string Phone { get => _Phone; set => _Phone = value; }

        public clsArtist(clsArtistList prArtistList)
        {
            _WorksList = new clsWorksList(); 
            _ArtistList = prArtistList;      //Question 8
            //EditDetails(); editted our for task2 part 7 e
        }



        public bool IsDuplicate(string prArtistName)
        {

            return _ArtistList.ContainsKey(prArtistName);
        }

        public void newArtist()
        {

            if (!string.IsNullOrEmpty(Name))
                _ArtistList.Add(Name, this);
            else
                throw new Exception("No artist name entered");

            //q2 p7
            //clsArtist lcArtist = new clsArtist(this);
            //.Name instead of.GetKey Q8
            //if (lcArtist.Name != "")
            //{
            //    Add(lcArtist.Name, lcArtist);

            //}
            //else
            //{
            //    throw new Exception();
            //}


        }

        //editted out for task2 part 7e
        //public void EditDetails()
        //{
        //    TotalValue = WorksList.GetTotalValue(); //Q8 Total value on home page doesnt work without this

        //    //frmArtist.Instance.SetDetails(this); //P2
        //    //_artistDialog.SetDetails(this); //Q8 removed for q2 p7

        //    ////if (_artistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    ////{
        //    ////    _artistDialog.GetDetails(ref _Name, ref _Speciality, ref _Phone);
        //    //TotalValue = WorksList.GetTotalValue();        //Question 8
        //    ////}
        //}

        //public string GetKey()
        //{
        //    return Name;
        //}

        //public decimal GetWorksValue()
        //{
        //    return TotalValue;
        //}

    }
}

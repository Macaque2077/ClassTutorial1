using System;
//using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        public delegate void LoadPhotographFormDelegate(clsPhotograph prPhotograph);
        public static LoadPhotographFormDelegate LoadPhotographForm;

        private float _Width;
        private float _Height;
        private string _Type;

        //[NonSerialized()]
        //private frmPhotograph _PhotographDialog; // p2 removed the static

        //private frmPhotograph myPhoto = new frmPhotograph(); this line can be used to check whether the frm is a singleton

        public float Width { get => _Width; set => _Width = value; }
        public float Height { get => _Height; set => _Height = value; }
        public string Type { get => _Type; set => _Type = value; }

        public override void EditDetails()
        {
            LoadPhotographForm(this);
            ////p2 5
            //if (_PhotographDialog == null) _PhotographDialog = frmPhotograph.Instance;
            //_PhotographDialog.SetDetails(this);

            //Q10
            //if (photographDialog == null)
            //{
            //    photographDialog = new frmPhotograph();
            //}
            //photographDialog.SetDetails(_Name, _Date, _Value, _Width, _Height, _Type);
            //if (photographDialog.ShowDialog() == DialogResult.OK)
            //{
            //    photographDialog.GetDetails(ref _Name, ref _Date, ref _Value, ref _Width, ref _Height, ref _Type);
            //}
        }

    }
}

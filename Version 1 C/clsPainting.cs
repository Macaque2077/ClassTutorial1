using System;
//using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsPainting : clsWork
    {
        //p2 4a
        public delegate void LoadPaintingFormDelegate(clsPainting prPainting);
        public static LoadPaintingFormDelegate LoadPaintingForm;

        private float _Width;
        private float _Height;
        private string _Type;

        //[NonSerialized()]

        //private frmPainting _PaintDialog;//p2 removed the static

        public float Width { get => _Width; set => _Width = value; }
        public float Height { get => _Height; set => _Height = value; }
        public string Type { get => _Type; set => _Type = value; }

       
        public override void EditDetails()
        {

            LoadPaintingForm(this);

            //p2 4b
            //if (_PaintDialog == null) _PaintDialog = frmPainting.Instance;
            //_PaintDialog.SetDetails(this);

            //Q10
            //if (paintDialog == null)
            //{
            //    paintDialog = new frmPainting();
            //}
            //paintDialog.SetDetails(_Name, _Date, _Value, _Width, _Height, _Type);
            //if(paintDialog.ShowDialog() == DialogResult.OK)
            //{
            //   paintDialog.GetDetails(ref _Name, ref _Date, ref _Value, ref _Width, ref _Height, ref _Type);
            //}
        }
    }
}

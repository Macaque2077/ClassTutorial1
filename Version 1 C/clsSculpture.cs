using System;
//using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsSculpture : clsWork
    {
        public delegate void LoadSculptureFormDelegate(clsSculpture prSculpture);
        public static LoadSculptureFormDelegate LoadSculptureForm;

        private float _Weight;
        private string _Material;

        

        public float Weight { get => _Weight; set => _Weight = value; }
        public string Material { get => _Material; set => _Material = value; }

        public override void EditDetails()
        {
            LoadSculptureForm(this);
            //p2 5
            //if (_SculptureDialog == null) _SculptureDialog = frmSculpture.Instance;
            //_SculptureDialog.SetDetails(this);

            //Q10
            //if (SculptureDialog == null)
            //{
            //    SculptureDialog = new frmSculpture();
            //}
            //SculptureDialog.SetDetails(_Name, _Date, _Value, _Weight, _Material);
            //if (SculptureDialog.ShowDialog() == DialogResult.OK)
            //{
            //    SculptureDialog.GetDetails(ref _Name, ref _Date, ref _Value, ref _Weight, ref _Material);
            //}
        }

    }
}

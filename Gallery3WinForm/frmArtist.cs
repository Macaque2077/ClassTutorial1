using System;
//using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Gallery3WinForm
{
    public partial class frmArtist : Form
    {
        //p2 task 7
        private static Dictionary<string, frmArtist> _ArtistFormList = new Dictionary<string, frmArtist>();

        public static void Run(string prArtistName)
        {
            frmArtist lcArtistForm;
            if (string.IsNullOrEmpty(prArtistName) ||
            !_ArtistFormList.TryGetValue(prArtistName, out lcArtistForm))
            {
                lcArtistForm = new frmArtist();
                if (string.IsNullOrEmpty(prArtistName))
                    lcArtistForm.SetDetails(new clsArtist());
                else
                {
                    _ArtistFormList.Add(prArtistName, lcArtistForm);
                    lcArtistForm.refreshFormFromDB(prArtistName);
                }
            }
            else
            {
                lcArtistForm.Show();
                lcArtistForm.Activate();
            }
        }

        private async void refreshFormFromDB(string prArtistName)
        {
            SetDetails(await ServiceClient.GetArtistAsync(prArtistName));
        }


        //p2 task 7
        //
        public frmArtist()
        {
            InitializeComponent();
        }

        
        //private clsWorksList _WorksList;
        private byte _SortOrder; // 0 = Name, 1 = Date

        private void UpdateDisplay()
        {
            ////txtName.Enabled = txtName.Text == "";
            //if (_SortOrder == 0)
            //{
            //    //_WorksList.SortByName();
            //    rbByName.Checked = true;
            //}
            //else
            //{
            //    //_WorksList.SortByDate();
            //    rbByDate.Checked = true;
            //}

            //lstWorks.DataSource = null;
            ////lstWorks.DataSource = _WorksList;
            ////lblTotal.Text = Convert.ToString(_WorksList.GetTotalValue());
            //frmMain.Instance.updateDisplay();
        }

        public void SetDetails(clsArtist prArtist)
        {
            

            _Artist = prArtist;
            updateForm();
            UpdateDisplay();
            Show();
            frmMain.Instance.updateDisplay();
            txtName.Enabled = string.IsNullOrEmpty(_Artist.Name); //q2 p7

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            //_WorksList.DeleteWork(lstWorks.SelectedIndex);

            //if (lstWorks.SelectedIndex >= 0 && lstWorks.SelectedIndex < _WorksList.Count)
            //{
            //    if (MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        //_WorksList.DeleteWork(lstWorks.SelectedIndex);
            //    }
            //}
            UpdateDisplay();
            frmMain.Instance.updateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //_WorksList.AddWork();
            UpdateDisplay();
            frmMain.Instance.updateDisplay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            if (isValid() == true)
                try
                {
                    pushData();
                    if (txtName.Enabled)
                    {
                        //_Artist.newArtist();
                        MessageBox.Show("Artist added!", "Success");
                        frmMain.Instance.updateDisplay();
                        txtName.Enabled = false;
                    }
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


        }

        public virtual Boolean isValid()
        {
            //if (txtName.Enabled && txtName.Text != "")
            //{
                
            //    if (_Artist.IsDuplicate(txtName.Text)) // Q9 _ArtistList.ContainsKey(txtName.Text)
            //    {
            //        MessageBox.Show("Artist with that name already exists!");
            //        return false;
            //    }
            //    else
            //        return true;
            //}
            //else
                return true;
        }

        private void lstWorks_DoubleClick(object sender, EventArgs e)
        {
            int lcIndex = lstWorks.SelectedIndex;

            //if (lcIndex >= 0 && lcIndex < _WorksList.Count)
            //{
            //    _WorksList.EditWork(lcIndex);
            //}
            //else
            //{
            //    MessageBox.Show("Sorry no work selected #" + Convert.ToString(lcIndex));
            //}
                UpdateDisplay();

        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
            _SortOrder = Convert.ToByte(rbByDate.Checked);
            UpdateDisplay();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private clsArtist _Artist;
        //Q8
        private void updateForm()
        {
            
            txtName.Text = _Artist.Name;
            txtSpeciality.Text = _Artist.Speciality;
            txtPhone.Text = _Artist.Phone;

            //_WorksList = _Artist.WorksList;
            //_SortOrder = _WorksList.SortOrder;
            UpdateDisplay();
        }
        //Q8
        private void pushData()
        {
            _Artist.Name = txtName.Text;
            _Artist.Speciality = txtSpeciality.Text;
            _Artist.Phone = txtPhone.Text;
            //_SortOrder = _WorksList.SortOrder;

        }
    }
}
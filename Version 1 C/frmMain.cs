using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public sealed partial class frmMain : Form
    {
        //p2
        public static frmMain Instance { get { return frmMain.instance; } } // this is the public property

        private static readonly frmMain instance = new frmMain();

        private frmMain()
        {
            InitializeComponent();
        }
        //p2
        /// <summary>
        ///  NMIT, 2019
        /// </summary>


        //private clsArtistList _ArtistList = new clsArtistList(); Q6
        private clsArtistList _ArtistList; //Q6

        private string error;
        private void frmMain_Load(object sender, EventArgs e)
        {

            _ArtistList = clsArtistList.Retrieve();
            updateDisplay();

            error = clsArtistList._errorMessage;

            if (error != ""){
                MessageBox.Show("File Retrieve Error");
            }
        }


        public void updateDisplay()
        {
            lstArtists.DataSource = null;
            string[] lcDisplayList = new string[_ArtistList.Count];

            
            _ArtistList.Keys.CopyTo(lcDisplayList, 0);
            lstArtists.DataSource = lcDisplayList;
            lblValue.Text = Convert.ToString(_ArtistList.getTotalValue());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmArtist.Run(new clsArtist(_ArtistList));
                //_ArtistList.newArtist();
                //MessageBox.Show("Artist added!"); //q2 p7d
                //updateDisplay();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Duplicate Key!");
            }
        }


        private void lstArtists_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)                       
                try
                {
                    frmArtist.Run(_ArtistList[lcKey]);// test
                    //_ArtistList.editArtist(lcKey); //q2 p7 test
                    //updateDisplay();  // q2 p7 tets
                }
            
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Sorry no artist by this name");
                }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _ArtistList.Save();

            error = clsArtistList._errorMessage;

            if (error != "")
            {
                MessageBox.Show(error, "File Save Error");
            }
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
            {
                lstArtists.ClearSelected();
                _ArtistList.Remove(lcKey);
                updateDisplay();
            }
        }


    }
}
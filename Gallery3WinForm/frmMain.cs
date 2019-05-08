using Gallery3WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gallery3WinForm
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


       
        //private clsArtistList _ArtistList; Task 3

        //private string error;
        private void frmMain_Load(object sender, EventArgs e)
        {

            //_ArtistList = clsArtistList.Retrieve(); Task 3
            updateDisplay();

            //error = clsArtistList._errorMessage; Task 3
            //Task 3
            //if (error != ""){                       
            //    MessageBox.Show("File Retrieve Error");       
            //}
        }


        public async void updateDisplay()
        {
            try
            {
                lstArtists.DataSource = null;
                lstArtists.DataSource = await ServiceClient.GetArtistNamesAsync();
            }
            catch { }


            //lstArtists.DataSource = null;
            //string[] lcDisplayList = new string[_ArtistList.Count];


            //_ArtistList.Keys.CopyTo(lcDisplayList, 0);
            //lstArtists.DataSource = lcDisplayList;
            //lblValue.Text = Convert.ToString(_ArtistList.getTotalValue());
            }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //frmArtist.Run(new clsArtist(_ArtistList));

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
                    frmArtist.Run(lstArtists.SelectedItem as string);

                }
            
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Sorry no artist by this name");
                }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string lcKey;

            //lcKey = Convert.ToString(lstArtists.SelectedItem);
            //if (lcKey != null)
            //{
            //    lstArtists.ClearSelected();
            //    _ArtistList.Remove(lcKey);
            //    updateDisplay();
            //}
        }


    }
}
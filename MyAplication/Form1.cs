using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyAplication
{
    public partial class MusicPlayerApp : Form
    {

        public MusicPlayerApp()
        {
            InitializeComponent();

        }


        //Create a global variabiles
        String[] paths, files;
        

        private void lbllogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code this close the app
            this.Close();

        }

        private void Hituri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i= 0; i< files.Length; i++)
                {
                    Muzica.Items.Add(files[i]);

                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[Muzica.SelectedIndex];
        }
    }
}
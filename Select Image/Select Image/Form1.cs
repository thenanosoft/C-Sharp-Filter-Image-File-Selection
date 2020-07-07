﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Select_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSlctImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Images *.jpg; *.jpeg; *.gif; *.png; *.bmp; *.tif, *.tiff; | *.jpg; *.jpeg; *.gif; *.png; *.bmp; *.tif, *.tiff;";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgBox.Image = new Bitmap(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Some thing went wrong");
            }
        }
    }
}

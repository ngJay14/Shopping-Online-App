﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingApp.UserControls
{
    public partial class ucMessImageRec : UserControl
    {
        public ucMessImageRec()
        {
            InitializeComponent();
        }

        private Image _ava;
        private Image _image;
        private string _time;

        public Image Ava
        {
            get { return _ava; }
            set { _ava = value; pcAva.Image = value; }
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; pcImage.Image = value; }
        }
        public string Time
        {
            get { return _time; }
            set { _time = value; lbTime.Text = value; }
        }
    }
}

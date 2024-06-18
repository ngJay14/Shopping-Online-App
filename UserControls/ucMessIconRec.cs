using shoppingApp.Classes;
using System;
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
    public partial class ucMessIconRec : UserControl
    {
        public ucMessIconRec()
        {
            InitializeComponent();
        }

        private Image _ava;
        private Image _icon;
        private string _time;

        public Image Ava
        {
            get { return _ava; }
            set { _ava = value; pcAva.Image = _ava; }
        }

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pcIcon.Image = _icon; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; lbTime.Text = value; }
        }
    }
}

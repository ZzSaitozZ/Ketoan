﻿using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Danhmuc
{
    public partial class Frame : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frame()
        {
            InitializeComponent();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbiGallery, true);
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
        }
       
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macdoc
{
    public partial class PDFViewer : Form
    {
        string filePath;
        public PDFViewer(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        private void PDFViewer_Load(object sender, EventArgs e)
        {

            pdfViewer1.DocumentFilePath = filePath;

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Chat
{
    public partial class Message : UserControl
    {
        public Message()
        {
            InitializeComponent();
        }

        public void LoadData(string message)
        {
            lbMessage.Text = message;
        }
    }
}

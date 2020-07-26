﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickStop.Domain.Models;
using QuickStop.Components;

namespace QuickStop.Client.Controls
{
    public partial class HotelCard : UserControl
    {
        private readonly int hotelID;
        public event EventHandler<HotelSelectedEventArgs> HotelSelected;

        public HotelCard()
        {
            InitializeComponent();
        }

        public HotelCard(Hotel hotel) : this()
        {
            hotelID = hotel.ID;
            // TODO: Load Images from base64 string
            //pictureBox.Image = Convert.ToImage(hotel.Icon);
            label1.Text = hotel.Name;
            label2.Text = hotel.Price.ToString();
            label3.Text = hotel.Ratings.ToString();
        }

        private void ViewHotelOnClick(object sender, EventArgs e)
        {
            HotelSelected?.Invoke(this, new HotelSelectedEventArgs(hotelID));
        }
    }
}
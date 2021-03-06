﻿namespace QuickStop.Client.Views
{
    partial class HotelRoomDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelRoomDetailsForm));
            this.HotelRoomName = new System.Windows.Forms.Label();
            this.SelectHotelRoomButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HotelRoomImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.HotelRoomDescription = new System.Windows.Forms.Label();
            this.HotelRoomPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.HotelRoomLocation = new System.Windows.Forms.Label();
            this.HotelRatings = new System.Windows.Forms.Label();
            this.HotelRoomGuestCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelRoomImage)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HotelRoomName
            // 
            this.HotelRoomName.AutoSize = true;
            this.HotelRoomName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.HotelRoomName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelRoomName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(195)))), ((int)(((byte)(100)))));
            this.HotelRoomName.Location = new System.Drawing.Point(12, 12);
            this.HotelRoomName.Margin = new System.Windows.Forms.Padding(12);
            this.HotelRoomName.Name = "HotelRoomName";
            this.HotelRoomName.Size = new System.Drawing.Size(647, 37);
            this.HotelRoomName.TabIndex = 1;
            this.HotelRoomName.Text = "HOTEL NAME";
            this.HotelRoomName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectHotelRoomButton
            // 
            this.SelectHotelRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.SelectHotelRoomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectHotelRoomButton.FlatAppearance.BorderSize = 0;
            this.SelectHotelRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectHotelRoomButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectHotelRoomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(195)))), ((int)(((byte)(100)))));
            this.SelectHotelRoomButton.Location = new System.Drawing.Point(445, 439);
            this.SelectHotelRoomButton.Margin = new System.Windows.Forms.Padding(6);
            this.SelectHotelRoomButton.Name = "SelectHotelRoomButton";
            this.SelectHotelRoomButton.Size = new System.Drawing.Size(220, 49);
            this.SelectHotelRoomButton.TabIndex = 3;
            this.SelectHotelRoomButton.Text = "SELECT ROOM";
            this.SelectHotelRoomButton.UseVisualStyleBackColor = false;
            this.SelectHotelRoomButton.Click += new System.EventHandler(this.BookHotelOnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(195)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "ROOM DESCRIPTION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.OldLace;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.90611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.51863F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.42623F));
            this.tableLayoutPanel1.Controls.Add(this.HotelRoomImage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SelectHotelRoomButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HotelRoomPrice, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.31078F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 494);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // HotelRoomImage
            // 
            this.HotelRoomImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.tableLayoutPanel1.SetColumnSpan(this.HotelRoomImage, 2);
            this.HotelRoomImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelRoomImage.Location = new System.Drawing.Point(355, 113);
            this.HotelRoomImage.Margin = new System.Windows.Forms.Padding(0);
            this.HotelRoomImage.Name = "HotelRoomImage";
            this.HotelRoomImage.Size = new System.Drawing.Size(316, 320);
            this.HotelRoomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HotelRoomImage.TabIndex = 0;
            this.HotelRoomImage.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.HotelRoomDescription, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(355, 320);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // HotelRoomDescription
            // 
            this.HotelRoomDescription.AutoSize = true;
            this.HotelRoomDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelRoomDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRoomDescription.ForeColor = System.Drawing.Color.OldLace;
            this.HotelRoomDescription.Location = new System.Drawing.Point(6, 50);
            this.HotelRoomDescription.Margin = new System.Windows.Forms.Padding(6);
            this.HotelRoomDescription.Name = "HotelRoomDescription";
            this.HotelRoomDescription.Size = new System.Drawing.Size(343, 264);
            this.HotelRoomDescription.TabIndex = 7;
            this.HotelRoomDescription.Text = "label2";
            this.HotelRoomDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HotelRoomPrice
            // 
            this.HotelRoomPrice.AutoSize = true;
            this.HotelRoomPrice.BackColor = System.Drawing.Color.OldLace;
            this.HotelRoomPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelRoomPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRoomPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.HotelRoomPrice.Location = new System.Drawing.Point(3, 433);
            this.HotelRoomPrice.Name = "HotelRoomPrice";
            this.HotelRoomPrice.Size = new System.Drawing.Size(349, 61);
            this.HotelRoomPrice.TabIndex = 2;
            this.HotelRoomPrice.Text = "Price";
            this.HotelRoomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.HotelRoomName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(671, 105);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(163)))), ((int)(((byte)(168)))));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.HotelRoomLocation, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.HotelRatings, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.HotelRoomGuestCount, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(671, 44);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // HotelRoomLocation
            // 
            this.HotelRoomLocation.AutoSize = true;
            this.HotelRoomLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(163)))), ((int)(((byte)(168)))));
            this.HotelRoomLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelRoomLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRoomLocation.ForeColor = System.Drawing.Color.OldLace;
            this.HotelRoomLocation.Location = new System.Drawing.Point(446, 0);
            this.HotelRoomLocation.Margin = new System.Windows.Forms.Padding(0);
            this.HotelRoomLocation.Name = "HotelRoomLocation";
            this.HotelRoomLocation.Padding = new System.Windows.Forms.Padding(6);
            this.HotelRoomLocation.Size = new System.Drawing.Size(225, 44);
            this.HotelRoomLocation.TabIndex = 10;
            this.HotelRoomLocation.Text = "LOCATION";
            this.HotelRoomLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HotelRatings
            // 
            this.HotelRatings.AutoSize = true;
            this.HotelRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelRatings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRatings.ForeColor = System.Drawing.Color.OldLace;
            this.HotelRatings.Location = new System.Drawing.Point(223, 0);
            this.HotelRatings.Margin = new System.Windows.Forms.Padding(0);
            this.HotelRatings.Name = "HotelRatings";
            this.HotelRatings.Size = new System.Drawing.Size(223, 44);
            this.HotelRatings.TabIndex = 7;
            this.HotelRatings.Text = "Ratings";
            this.HotelRatings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HotelRoomGuestCount
            // 
            this.HotelRoomGuestCount.AutoSize = true;
            this.HotelRoomGuestCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(163)))), ((int)(((byte)(168)))));
            this.HotelRoomGuestCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelRoomGuestCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRoomGuestCount.ForeColor = System.Drawing.Color.OldLace;
            this.HotelRoomGuestCount.Location = new System.Drawing.Point(0, 0);
            this.HotelRoomGuestCount.Margin = new System.Windows.Forms.Padding(0);
            this.HotelRoomGuestCount.Name = "HotelRoomGuestCount";
            this.HotelRoomGuestCount.Size = new System.Drawing.Size(223, 44);
            this.HotelRoomGuestCount.TabIndex = 9;
            this.HotelRoomGuestCount.Text = "label8";
            this.HotelRoomGuestCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HotelRoomDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HotelRoomDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quick Stop: Hotel Details";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelRoomImage)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HotelRoomImage;
        private System.Windows.Forms.Label HotelRoomName;
        private System.Windows.Forms.Button SelectHotelRoomButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HotelRoomPrice;
        private System.Windows.Forms.Label HotelRatings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label HotelRoomDescription;
        private System.Windows.Forms.Label HotelRoomGuestCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label HotelRoomLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
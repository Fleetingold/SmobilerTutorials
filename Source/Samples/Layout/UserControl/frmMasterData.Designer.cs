﻿using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.Layout.UserControl
{
    partial class frmMasterData : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.plAssetsType = new Smobiler.Core.Controls.Panel();
            this.imgAssetsType = new Smobiler.Core.Controls.Image();
            this.lblAssetsType = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.plWareHouse = new Smobiler.Core.Controls.Panel();
            this.imgWareHouse = new Smobiler.Core.Controls.Image();
            this.lblWareHouse = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.plClient = new Smobiler.Core.Controls.Panel();
            this.imgClient = new Smobiler.Core.Controls.Image();
            this.lblClient = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.plSupplier = new Smobiler.Core.Controls.Panel();
            this.imgSupplier = new Smobiler.Core.Controls.Image();
            this.lblSupplier = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "主数据";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plAssetsType,
            this.plWareHouse,
            this.plClient,
            this.plSupplier});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 500);
            // 
            // plAssetsType
            // 
            this.plAssetsType.BackColor = System.Drawing.Color.White;
            this.plAssetsType.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgAssetsType,
            this.lblAssetsType,
            this.label1});
            this.plAssetsType.Location = new System.Drawing.Point(0, 15);
            this.plAssetsType.Name = "plAssetsType";
            this.plAssetsType.Size = new System.Drawing.Size(300, 45);
            this.plAssetsType.Touchable = true;
            this.plAssetsType.TouchOpacity = 100;
            this.plAssetsType.Press += new System.EventHandler(this.plAssetsType_Press);
            // 
            // imgAssetsType
            // 
            this.imgAssetsType.Location = new System.Drawing.Point(10, 5);
            this.imgAssetsType.Name = "imgAssetsType";
            this.imgAssetsType.ResourceID = "assetsType";
            this.imgAssetsType.Size = new System.Drawing.Size(35, 35);
            // 
            // lblAssetsType
            // 
            this.lblAssetsType.FontSize = 15F;
            this.lblAssetsType.Location = new System.Drawing.Point(55, 0);
            this.lblAssetsType.Name = "lblAssetsType";
            this.lblAssetsType.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblAssetsType.Size = new System.Drawing.Size(170, 45);
            this.lblAssetsType.Text = "资产分类";
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(255, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 45);
            this.label1.Text = ">";
            // 
            // plWareHouse
            // 
            this.plWareHouse.BackColor = System.Drawing.Color.White;
            this.plWareHouse.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plWareHouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plWareHouse.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgWareHouse,
            this.lblWareHouse,
            this.label3});
            this.plWareHouse.Location = new System.Drawing.Point(0, 60);
            this.plWareHouse.Name = "plWareHouse";
            this.plWareHouse.Size = new System.Drawing.Size(300, 45);
            this.plWareHouse.Touchable = true;
            this.plWareHouse.TouchOpacity = 100;
            this.plWareHouse.Press += new System.EventHandler(this.plWareHouse_Press);
            // 
            // imgWareHouse
            // 
            this.imgWareHouse.Location = new System.Drawing.Point(10, 5);
            this.imgWareHouse.Name = "imgWareHouse";
            this.imgWareHouse.ResourceID = "warehouse";
            this.imgWareHouse.Size = new System.Drawing.Size(35, 35);
            // 
            // lblWareHouse
            // 
            this.lblWareHouse.FontSize = 15F;
            this.lblWareHouse.Location = new System.Drawing.Point(55, 0);
            this.lblWareHouse.Name = "lblWareHouse";
            this.lblWareHouse.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblWareHouse.Size = new System.Drawing.Size(170, 45);
            this.lblWareHouse.Text = "仓库管理";
            // 
            // label3
            // 
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label3.Location = new System.Drawing.Point(255, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 45);
            this.label3.Text = ">";
            // 
            // plClient
            // 
            this.plClient.BackColor = System.Drawing.Color.White;
            this.plClient.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plClient.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgClient,
            this.lblClient,
            this.label5});
            this.plClient.Location = new System.Drawing.Point(0, 105);
            this.plClient.Name = "plClient";
            this.plClient.Size = new System.Drawing.Size(300, 45);
            this.plClient.Touchable = true;
            this.plClient.TouchOpacity = 100;
            this.plClient.Press += new System.EventHandler(this.plClient_Press);
            // 
            // imgClient
            // 
            this.imgClient.Location = new System.Drawing.Point(10, 5);
            this.imgClient.Name = "imgClient";
            this.imgClient.ResourceID = "guest";
            this.imgClient.Size = new System.Drawing.Size(35, 35);
            // 
            // lblClient
            // 
            this.lblClient.FontSize = 15F;
            this.lblClient.Location = new System.Drawing.Point(55, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblClient.Size = new System.Drawing.Size(170, 45);
            this.lblClient.Text = "客户管理";
            // 
            // label5
            // 
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label5.Location = new System.Drawing.Point(255, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 45);
            this.label5.Text = ">";
            // 
            // plSupplier
            // 
            this.plSupplier.BackColor = System.Drawing.Color.White;
            this.plSupplier.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgSupplier,
            this.lblSupplier,
            this.label7});
            this.plSupplier.Location = new System.Drawing.Point(0, 150);
            this.plSupplier.Name = "plSupplier";
            this.plSupplier.Size = new System.Drawing.Size(300, 45);
            this.plSupplier.Touchable = true;
            this.plSupplier.TouchOpacity = 100;
            this.plSupplier.Press += new System.EventHandler(this.plSupplier_Press);
            // 
            // imgSupplier
            // 
            this.imgSupplier.Location = new System.Drawing.Point(10, 5);
            this.imgSupplier.Name = "imgSupplier";
            this.imgSupplier.ResourceID = "supplier";
            this.imgSupplier.Size = new System.Drawing.Size(35, 35);
            // 
            // lblSupplier
            // 
            this.lblSupplier.FontSize = 15F;
            this.lblSupplier.Location = new System.Drawing.Point(55, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblSupplier.Size = new System.Drawing.Size(170, 45);
            this.lblSupplier.Text = "供应商管理";
            // 
            // label7
            // 
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label7.Location = new System.Drawing.Point(255, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 45);
            this.label7.Text = ">";
            // 
            // frmMasterData
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Name = "frmMasterData";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel plAssetsType;
        private Smobiler.Core.Controls.Image imgAssetsType;
        private Smobiler.Core.Controls.Label lblAssetsType;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel plWareHouse;
        private Smobiler.Core.Controls.Image imgWareHouse;
        private Smobiler.Core.Controls.Label lblWareHouse;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel plClient;
        private Smobiler.Core.Controls.Image imgClient;
        private Smobiler.Core.Controls.Label lblClient;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Panel plSupplier;
        private Smobiler.Core.Controls.Image imgSupplier;
        private Smobiler.Core.Controls.Label lblSupplier;
        private Smobiler.Core.Controls.Label label7;
    }
}
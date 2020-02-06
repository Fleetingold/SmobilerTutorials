﻿using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.Layout.UserControl
{
    partial class frmAnalyze : Smobiler.Core.Controls.MobileUserControl
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
            this.scType = new Smobiler.Core.Controls.SegmentedControl();
            this.plGoods = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.plbGoods = new Smobiler.Core.Controls.Panel();
            this.ibQuant = new Smobiler.Core.Controls.ImageButton();
            this.ibSafeQuant = new Smobiler.Core.Controls.ImageButton();
            this.ibExpiry = new Smobiler.Core.Controls.ImageButton();
            this.plPurchase = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.plbPurchase = new Smobiler.Core.Controls.Panel();
            this.ibPurQuant = new Smobiler.Core.Controls.ImageButton();
            this.ibVendor = new Smobiler.Core.Controls.ImageButton();
            this.plSale = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.plbSale = new Smobiler.Core.Controls.Panel();
            this.ibSaleQuant = new Smobiler.Core.Controls.ImageButton();
            this.ibCustomer = new Smobiler.Core.Controls.ImageButton();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "统计";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.scType,
            this.plGoods,
            this.plPurchase,
            this.plSale});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 500);
            // 
            // scType
            // 
            this.scType.Items = new string[] {
        "资产",
        "耗材"};
            this.scType.Name = "scType";
            this.scType.SegmentedBorderRadius = 0;
            this.scType.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.scType.SelectedColor = System.Drawing.Color.White;
            this.scType.Size = new System.Drawing.Size(300, 35);
            this.scType.UnSelectedBackColor = System.Drawing.Color.White;
            this.scType.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.scType.SelectedIndexChanged += new System.EventHandler(this.scType_SelectedIndexChanged);
            // 
            // plGoods
            // 
            this.plGoods.BackColor = System.Drawing.Color.White;
            this.plGoods.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plGoods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plGoods.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.plbGoods});
            this.plGoods.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plGoods.Location = new System.Drawing.Point(0, 35);
            this.plGoods.Name = "plGoods";
            this.plGoods.Size = new System.Drawing.Size(300, 100);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "商品分析";
            // 
            // plbGoods
            // 
            this.plbGoods.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ibQuant,
            this.ibSafeQuant,
            this.ibExpiry});
            this.plbGoods.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plbGoods.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plbGoods.Name = "plbGoods";
            this.plbGoods.Size = new System.Drawing.Size(0, 65);
            // 
            // ibQuant
            // 
            this.ibQuant.Flex = 1;
            this.ibQuant.IconColor = System.Drawing.Color.DodgerBlue;
            this.ibQuant.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibQuant.ImgTextRatio = new Smobiler.Core.Controls.Ratio(4, 6);
            this.ibQuant.Name = "ibQuant";
            this.ibQuant.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.ibQuant.ResourceID = "kucun";
            this.ibQuant.Size = new System.Drawing.Size(0, 65);
            this.ibQuant.Text = "库存";
            this.ibQuant.Press += new System.EventHandler(this.ibQuant_Press);
            // 
            // ibSafeQuant
            // 
            this.ibSafeQuant.Flex = 1;
            this.ibSafeQuant.IconColor = System.Drawing.Color.DodgerBlue;
            this.ibSafeQuant.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibSafeQuant.ImgTextRatio = new Smobiler.Core.Controls.Ratio(4, 6);
            this.ibSafeQuant.Name = "ibSafeQuant";
            this.ibSafeQuant.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.ibSafeQuant.ResourceID = "anquan";
            this.ibSafeQuant.Size = new System.Drawing.Size(0, 65);
            this.ibSafeQuant.Text = "安全库存";
            this.ibSafeQuant.Visible = false;
            this.ibSafeQuant.Press += new System.EventHandler(this.ibSafeQuant_Press);
            // 
            // ibExpiry
            // 
            this.ibExpiry.Flex = 1;
            this.ibExpiry.IconColor = System.Drawing.Color.DodgerBlue;
            this.ibExpiry.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibExpiry.ImgTextRatio = new Smobiler.Core.Controls.Ratio(4, 6);
            this.ibExpiry.Name = "ibExpiry";
            this.ibExpiry.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.ibExpiry.ResourceID = "youxiaoqi";
            this.ibExpiry.Size = new System.Drawing.Size(0, 65);
            this.ibExpiry.Text = "有效期分析";
            this.ibExpiry.Press += new System.EventHandler(this.ibExpiry_Press);
            // 
            // plPurchase
            // 
            this.plPurchase.BackColor = System.Drawing.Color.White;
            this.plPurchase.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plPurchase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPurchase.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.plbPurchase});
            this.plPurchase.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plPurchase.Location = new System.Drawing.Point(0, 135);
            this.plPurchase.Name = "plPurchase";
            this.plPurchase.Size = new System.Drawing.Size(300, 100);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "采购分析";
            // 
            // plbPurchase
            // 
            this.plbPurchase.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ibPurQuant,
            this.ibVendor});
            this.plbPurchase.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plbPurchase.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plbPurchase.Name = "plbPurchase";
            this.plbPurchase.Size = new System.Drawing.Size(0, 65);
            // 
            // ibPurQuant
            // 
            this.ibPurQuant.Flex = 1;
            this.ibPurQuant.IconColor = System.Drawing.Color.DodgerBlue;
            this.ibPurQuant.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibPurQuant.ImgTextRatio = new Smobiler.Core.Controls.Ratio(4, 6);
            this.ibPurQuant.Name = "ibPurQuant";
            this.ibPurQuant.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.ibPurQuant.ResourceID = "caigou";
            this.ibPurQuant.Size = new System.Drawing.Size(0, 65);
            this.ibPurQuant.Text = "采购报表";
            this.ibPurQuant.Press += new System.EventHandler(this.ibPurQuant_Press);
            // 
            // ibVendor
            // 
            this.ibVendor.Flex = 1;
            this.ibVendor.IconColor = System.Drawing.Color.DodgerBlue;
            this.ibVendor.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibVendor.ImgTextRatio = new Smobiler.Core.Controls.Ratio(4, 6);
            this.ibVendor.Name = "ibVendor";
            this.ibVendor.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.ibVendor.ResourceID = "gongyingshang";
            this.ibVendor.Size = new System.Drawing.Size(0, 65);
            this.ibVendor.Text = "供货商";
            this.ibVendor.Press += new System.EventHandler(this.ibVendor_Press);
            // 
            // plSale
            // 
            this.plSale.BackColor = System.Drawing.Color.White;
            this.plSale.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plSale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plSale.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.plbSale});
            this.plSale.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plSale.Location = new System.Drawing.Point(0, 235);
            this.plSale.Name = "plSale";
            this.plSale.Size = new System.Drawing.Size(300, 100);
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(0, 35);
            this.label3.Text = "销售分析";
            // 
            // plbSale
            // 
            this.plbSale.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ibSaleQuant,
            this.ibCustomer});
            this.plbSale.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plbSale.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plbSale.Name = "plbSale";
            this.plbSale.Size = new System.Drawing.Size(0, 65);
            // 
            // ibSaleQuant
            // 
            this.ibSaleQuant.Flex = 1;
            this.ibSaleQuant.IconColor = System.Drawing.Color.DodgerBlue;
            this.ibSaleQuant.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibSaleQuant.ImgTextRatio = new Smobiler.Core.Controls.Ratio(4, 6);
            this.ibSaleQuant.Name = "ibSaleQuant";
            this.ibSaleQuant.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.ibSaleQuant.ResourceID = "xiaoshou";
            this.ibSaleQuant.Size = new System.Drawing.Size(0, 65);
            this.ibSaleQuant.Text = "销售报表";
            this.ibSaleQuant.Press += new System.EventHandler(this.ibSaleQuant_Press);
            // 
            // ibCustomer
            // 
            this.ibCustomer.Flex = 1;
            this.ibCustomer.IconColor = System.Drawing.Color.DodgerBlue;
            this.ibCustomer.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibCustomer.ImgTextRatio = new Smobiler.Core.Controls.Ratio(4, 6);
            this.ibCustomer.Name = "ibCustomer";
            this.ibCustomer.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.ibCustomer.ResourceID = "kehu";
            this.ibCustomer.Size = new System.Drawing.Size(0, 65);
            this.ibCustomer.Text = "客户";
            this.ibCustomer.Press += new System.EventHandler(this.ibCustomer_Press);
            // 
            // frmAnalyze
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Size = new System.Drawing.Size(300, 500);
            this.Load += new System.EventHandler(this.frmAnalyze_Load);
            this.Name = "frmAnalyze";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.SegmentedControl scType;
        private Smobiler.Core.Controls.Panel plGoods;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel plbGoods;
        private Smobiler.Core.Controls.ImageButton ibQuant;
        private Smobiler.Core.Controls.ImageButton ibSafeQuant;
        private Smobiler.Core.Controls.ImageButton ibExpiry;
        private Smobiler.Core.Controls.Panel plPurchase;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Panel plbPurchase;
        private Smobiler.Core.Controls.ImageButton ibPurQuant;
        private Smobiler.Core.Controls.ImageButton ibVendor;
        private Smobiler.Core.Controls.Panel plSale;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel plbSale;
        private Smobiler.Core.Controls.ImageButton ibSaleQuant;
        private Smobiler.Core.Controls.ImageButton ibCustomer;
    }
}
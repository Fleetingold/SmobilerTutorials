using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Samples
{
    partial class demoListViewRefresh : Smobiler.Core.Controls.MobileForm
    {

        private int dataCounter = 0;

        private void demoListViewRefresh_Load(object sender, EventArgs e)
        {
            this.listView1.TemplateControl = new ListViewTemplateControl();
            this.listView1.FooterControl = new ListViewFooterTemplateControl();
            BindListViewData();
        }

        /// <summary>
        /// ��������ˢ��ʱ����ʼ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_Refresh(object sender, EventArgs e)
        {
            this.listView1.Rows.Clear();
            //������ʱ����ʼ����ʼ����Ϊ0
            dataCounter = 0;
            BindListViewData();
        }

        /// <summary>
        /// ����ListView�� FooterControl �ϵ�Button���ʱ��������
        /// </summary>
        internal void AddListViewData()
        {
            dataCounter += 1;
            BindListViewData();
        }

        /// <summary>
        /// ÿһ�μ���10������
        /// </summary>
        private void BindListViewData()
        {
            DataTable dt= new DataTable("listview");
            dt.Columns.Add(new DataColumn("Label", typeof(string)));
            int dataStart = dataCounter * 10 + 1;
            int dataEnd = (dataCounter + 1) * 10;
            for (int i = dataStart; i <= dataEnd; i++)
            {
                dt.Rows.Add(i);
            }
            if (dataCounter == 0)
            {
                this.listView1.DataSource = dt;
                this.listView1.DataBind();
            }
            else
            {
                this.listView1.NewRow(dt, "");
            }
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    /// <summary>
    /// ListView��ģ��
    /// </summary>
    class ListViewTemplateControl:MobileUserControl
    {
        public ListViewTemplateControl():base()
        {
            this.Layout = LayoutPosition.Relative;
            this.Height = 30;
            this.Controls.Add(new Label() { DisplayMember = "Label", Flex = 1, Width = 0 });
        }
    }

    /// <summary>
    /// ListView����������ݵ�ģ��
    /// </summary>
    class ListViewFooterTemplateControl : MobileUserControl
    {
        private Button btnLoad;

        public ListViewFooterTemplateControl() : base()
        {
            this.Layout = LayoutPosition.Relative;
            this.Height = 30;
            btnLoad = new Button() { Text = "��������", Flex = 1, Width = 0 };
            btnLoad.Press += BtnLoad_Press;
            this.Controls.Add(btnLoad);
        }

        private void BtnLoad_Press(object sender, EventArgs e)
        {
            demoListViewRefresh form = this.Owner.Owner as demoListViewRefresh;
            form.AddListViewData();
        }
    }
}
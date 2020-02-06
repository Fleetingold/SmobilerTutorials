using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using System.ComponentModel;

namespace Smobiler.Tutorials.Samples
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demogetdata : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ��ѡ�����ʱ������
        /// </summary>
        [Description("��ѡ�����ʱ������")]
        public event SelectedEventHandler Selected;

        private void SmobilerForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(System.Int32));
            table.Rows.Add(1);
            table.Rows.Add(2);
            listView1.Rows.Clear();     //�������
            if (table.Rows.Count > 0)    //������Դ
            {
                listView1.DataSource = table;
                listView1.DataBind();
            }
        }

        internal void OnSelected(string text)
        {
            if (this.Selected != null)
                this.Selected(this, new SelectedEventArgs(text));
            this.Close();
        }

    }
}
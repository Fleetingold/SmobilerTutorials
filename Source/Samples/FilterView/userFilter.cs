using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Samples
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class userFilter : Smobiler.Core.Controls.MobileUserControl
    {

        private void userFilter_Load(object sender, EventArgs e)
        {
            Demo(new string[] { "����", "��ƽ��", "�����", "������", "����", "�ʹ���", "������", "�ں���", "�ռ�����", "������", "����" }, new string[] { "����", "1km", "3km", "5km", "10km", "ȫ��" });
        }

        private void panel2_Press(object sender, EventArgs e)
        {

            //��������ڵ��ʱ���޸�ѡ���FontIcon��ͼ��
            fontIcon1.ResourceID = "caret-down";
            fontIcon2.ResourceID = "caret-up";
            fontIcon3.ResourceID = "caret-up";

            Demo(new string[] { "����", "��ƽ��", "�����", "������", "����", "�ʹ���", "������", "�ں���", "�ռ�����", "������", "����" }, new string[] { "����", "1km", "3km", "5km", "10km", "ȫ��" });
        }

        /// <summary>
        /// ��ListView�������ݰ�
        /// </summary>
        /// <param name="dt1Data"></param>
        /// <param name="dt2Data"></param>
        private void Demo(string[] dt1Data, string[] dt2Data)
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("LABEL", typeof(string));
            dt1Data.ToList<String>().ForEach((item) => { dt1.Rows.Add(item); });

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("LABEL", typeof(string));
            dt2Data.ToList<String>().ForEach((item) => { dt2.Rows.Add(item); });

            this.userFilterItem1.DataBind(dt1, dt2);
        }

        private void panel3_Press(object sender, EventArgs e)
        {
            fontIcon1.ResourceID = "caret-up";
            fontIcon2.ResourceID = "caret-down";
            fontIcon3.ResourceID = "caret-up";

            Demo(new string[] { "����", "��ƽ��", "�����" }, new string[] { "����", "1km" });
        }

        private void panel4_Press(object sender, EventArgs e)
        {
            fontIcon1.ResourceID = "caret-up";
            fontIcon2.ResourceID = "caret-up";
            fontIcon3.ResourceID = "caret-down";

            Demo(new string[] { "����", "��ƽ��", "�����", "������" }, new string[] { "����", "ȫ��" });
        }

    }
}
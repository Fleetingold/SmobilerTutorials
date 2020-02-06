using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples.ShowDialog
{

    public delegate void DialogPasswordEventHandler(string password);

    //[System.ComponentModel.ToolboxItem(true)]
    partial class userDialogPassword : Smobiler.Core.Controls.MobileUserControl
    {

        private int currentPassNum = 0;

        public event DialogPasswordEventHandler DialogPassword;

        private void ibtClose_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnBack_Press(object sender, EventArgs e)
        {
            if (currentPassNum > 0)
            {
                //�ڵ��ɾ��ʱ��ɾ���������Ѿ����������
                Label labNum = this.palPassword.Controls.Find("labPass" + currentPassNum.ToString()) as Label;
                labNum.Text = "";
                currentPassNum -= 1;
            }
        }

        /// <summary>
        /// ͨ�������Ի�ȡ����
        /// </summary>
        public string Password
        {
            get
            {
                return string.Format("{0}{1}{2}{3}{4}{5}", this.labPass1.Text, this.labPass2.Text, this.labPass3.Text, this.labPass4.Text, this.labPass5.Text, this.labPass6.Text);
            }
        }

        private void btnNum_Press(object sender, EventArgs e)
        {
            currentPassNum += 1;
            Button btn=sender as Button;
            //���ڿؼ��Ǵ�btnNum0��btnNum9��ֻ��Ҫȡ��ǰ�ؼ��������һλ����Ϊ���ּ��ɡ�
            char num= btn.Name[6];
            //�ҵ���Ӧλ�õ�Label����ʾ��
            Label labNum = this.palPassword.Controls.Find("labPass" + currentPassNum.ToString()) as Label;
            labNum.Text = num.ToString();
            //�����ǰ�������빻6λ����ô�رյ�ǰ���档
            if (currentPassNum >=6)
            {
                if (DialogPassword != null) DialogPassword.Invoke(Password);
                this.Close();
            }
        }

        private void btnForgetPass_Press(object sender, EventArgs e)
        {
            MessageBox.Show("δʵ��");
        }
    }
}
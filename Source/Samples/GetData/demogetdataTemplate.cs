using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.ComponentModel;

namespace Smobiler.Tutorials.Samples
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demogetdataTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        
        private void panel1_Press(object sender, EventArgs e)
        {
            
            demogetdata dmd = (demogetdata)this.Owner.Owner;
            dmd.OnSelected(this.label1.Text);
        }
        
    }

    /// <summary>
    /// ΪSelected�¼��ṩ����
    /// </summary>
    /// <remarks></remarks>
    public class SelectedEventArgs : EventArgs
    {

        private string _text = "";
        /// <summary>
        /// ѡ�������
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name">ѡ�������</param>
        /// <remarks></remarks>
        public SelectedEventArgs(string text) : base()
        {
            _text = text;
        }
    }

    /// <summary>
    /// һ��ί�У�����ʾ�ڰ�ť���ʱҪ���õķ�����
    /// </summary>
    /// <param name="sender">�¼�Դ</param>
    /// <param name="e">�����¼����ݵ� SelectedEventArgs</param>
    /// <remarks></remarks>
    public delegate void SelectedEventHandler(object sender, SelectedEventArgs e);
}
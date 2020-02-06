using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples
{
    partial class demoCustomResource : Smobiler.Core.Controls.MobileForm
    {
 
        static demoCustomResource()
        {
            MobileServer.RegisterExtendHandler(Smobiler.Core.Web.ExtendHandlerType.ResourceGet, typeof(HttpCustomResourceHandler));
        }

        private void demoCustomResource_Load(object sender, EventArgs e)
        {
            //�����������ΪCustomize
            this.image1.ResourceMode = ResourceMode.Customize;
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateImage_Press(object sender, EventArgs e)
        {
            //ˢ��ͼ��
            this.image1.ResourceID = "test";
            this.image1.Refresh();
        }
    }


    class HttpCustomResourceHandler : Smobiler.Core.Web.IExtendHandler
    {
        public Smobiler.Core.Web.ExtendHandlerStatusArgs Excute(Smobiler.Core.Web.ExtendHandlerArgs e)
        {
            Smobiler.Core.Web.ExtendHandlerResourceGetArgs args = e as Smobiler.Core.Web.ExtendHandlerResourceGetArgs;
            var id = args.ResourceID;

            //���ﶯ̬����һ��ͼ��
            var image = new System.Drawing.Bitmap(300, 300);
            var g = System.Drawing.Graphics.FromImage(image);
            //д�ϵ�ǰʱ��
            g.DrawString(DateTime.Now.ToString(), new System.Drawing.Font("����", 20), new System.Drawing.SolidBrush(System.Drawing.Color.Red), 0, 0);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                //��ȡͼ����Դ
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                var imageData = ms.GetBuffer();
                //���÷�������Ϊbyte
                args.Data = new BinaryResultArgs(imageData, args.ResourceID);
                ms.Close();
                return args;
            }
        }
    }
}
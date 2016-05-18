using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.IO;
using System.Text;

namespace hm.Web.handler
{
    /// <summary>
    /// UploadImageHandler 的摘要说明
    /// </summary>
    public class UploadImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpFileCollection files = context.Request.Files;
            HttpPostedFile postedFile = files[0];

            string fpath = context.Request.Params["fpath"].ToString();
            string path = HttpContext.Current.Server.MapPath("~/upload/") + "\\" + fpath + "\\";
            
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);//在根目录下建立文件夹 
            }
            if (postedFile.ContentLength > 10240000)
            {
                context.Response.Write("{\"result\":\"false\",\"err\":\"文件大小不能大于1M！\"}");
                context.Response.End();
                return;
            }
            string fileName, fileExtension;
            fileName = System.IO.Path.GetFileName(postedFile.FileName);
            string SaveFilePath = "";
            if (fileName != "")
            {
                string apath = "/upload/" + fpath + "/" + System.DateTime.Now.ToString("yyyymmddhhmmss");
                SaveFilePath = apath + ".jpg";
                string smallPath = apath + "_small" + ".jpg";
                fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
                //if (fileExtension != ".jpg")
                //{
                //    context.Response.Write("{\"result\":\"false\",\"err\":\"文件格式不正确，你只能上传jpg格式文件！\"}");
                //    context.Response.End();
                //    return;
                //}
                postedFile.SaveAs(context.Server.MapPath(SaveFilePath));
                //生成缩略图
                Common.CommonHelper.MakeThumbnail(context.Server.MapPath(SaveFilePath), context.Server.MapPath(smallPath), 70, 60, "W", "jpg");
                context.Response.Write("{\"result\":\"true\",\"pic\":\"" + SaveFilePath + "\"}");
                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
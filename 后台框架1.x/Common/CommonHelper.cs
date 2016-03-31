using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Web;
using System.IO;

namespace hm.Common
{
    public static class CommonHelper
    {
        public static string File_Type_Id_GroupStep = "1";

        /// <summary>
        /// 绑定TreeView(filedList:parentId,textFiled,valueFiled)
        /// </summary>
        /// <param name="tv"></param>
        /// <param name="treeViewData"></param>
        /// <param name="filedList"></param>
        public static TreeView AddTopTreeViewNodes(TreeView tv, DataTable treeViewData, string[] filedList)
        {
            DataView view = new DataView(treeViewData);
            view.RowFilter = filedList[0] + "=0";
            tv.Nodes.Clear();
            foreach (DataRowView row in view)
            {
                TreeNode newNode = new TreeNode(row[filedList[1]].ToString(), row[filedList[2]].ToString());
                newNode.Expanded = true;
                tv.Nodes.Add(newNode);
                AddChildTreeViewNodes(treeViewData, newNode, filedList);//绑定子节点
            }
            return tv;
        }

        private static void AddChildTreeViewNodes(DataTable treeViewData, TreeNode parentTreeViewNode, string[] filedList)
        {
            DataView view = new DataView(treeViewData);
            view.RowFilter = filedList[0]+"=" + parentTreeViewNode.Value;
            foreach (DataRowView row in view)
            {
                TreeNode newNode = new TreeNode(row[filedList[1]].ToString(), row[filedList[2]].ToString());
                newNode.Expanded = false;
                parentTreeViewNode.ChildNodes.Add(newNode);
                AddChildTreeViewNodes(treeViewData, newNode, filedList);//递归，绑定子节点
            }
        }

        #region 生成缩略图
        public static string Imageupload(FileUpload file1, string folerPath)
        {
            string msg = "";
            Boolean fileOk = false;
            string path = HttpContext.Current.Server.MapPath("~/upload/") + "\\" + folerPath+"\\";
            if (!Directory.Exists(path)) 
            {
                Directory.CreateDirectory(path);//在根目录下建立文件夹 
            } 
            if (file1.HasFile)
            {
                //取得文件的扩展名,并转换成小写            
                string fileExtension = System.IO.Path.GetExtension(file1.FileName).ToLower();
                //限定只能上传jpg和gif图片            
                string[] allowExtension = { ".jpg", ".gif", ".bmp" };
                //对上传的文件的类型进行一个个匹对            
                for (int i = 0; i < allowExtension.Length; i++)
                {
                    if (fileExtension == allowExtension[i])
                    {
                        fileOk = true;
                        break;
                    }
                }
                //            
                if (!fileOk)
                {
                    msg = "要上传的文件类型不对！";
                }
                //对上传文件的大小进行检测，限定文件最大不超过8M            
                if (file1.PostedFile.ContentLength > 8192000)
                {
                    fileOk = false;
                }
                //最后的结果            
                if (fileOk)
                {
                    try
                    {
                        string sourcePath = path + DateTime.Now.ToString("yyyyMMddhhmmss") + "_big" + fileExtension;
                        string smallPath = path + DateTime.Now.ToString("yyyyMMddhhmmss") + "_small" + fileExtension;
                        string bigPath = "/upload/" + folerPath + "/" + DateTime.Now.ToString("yyyyMMddhhmmss") + "_big" + fileExtension;
                        string sPath = "/upload/" + folerPath + "/" + DateTime.Now.ToString("yyyyMMddhhmmss") + "_small" + fileExtension;
                        file1.PostedFile.SaveAs(sourcePath);
                        MakeThumbnail(sourcePath, smallPath, 200, 120, "W", "jpg");
                        msg = "上传成功|" + bigPath + "|" + sPath;
                    }
                    catch
                    {
                        msg = "上传失败";
                    }
                }
                else
                {
                    msg = "文件类型或者文件大小超出8M或者文件类型不对";
                }
            }
            return msg;
        }
        /// <summary> 
        /// 生成缩略图 
        /// </summary> 
        /// <param name="originalImagePath">源图路径</param> 
        /// <param name="thumbnailPath">缩略图路径</param> 
        /// <param name="width">缩略图宽度</param> 
        /// <param name="height">缩略图高度</param> 
        /// <param name="mode">生成缩略图的方式:HW指定高宽缩放(可能变形);W指定宽，高按比例 H指定高，宽按比例 Cut指定高宽裁减(不变形)</param>　　 
        /// <param name="mode">要缩略图保存的格式(gif,jpg,bmp,png) 为空或未知类型都视为jpg</param>　　 
        public static void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode, string imageType)
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);
            int towidth = width;
            int toheight = height;
            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;
            switch (mode)
            {
                case "HW"://指定高宽缩放（可能变形）　　　　　　　　 
                    break;
                case "W"://指定宽，高按比例　　　　　　　　　　 
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例 
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）　　　　　　　　 
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }
            //新建一个bmp图片 
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            //新建一个画板 
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法 
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度 
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充 
            g.Clear(Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分 
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
              new Rectangle(x, y, ow, oh),
              GraphicsUnit.Pixel);
            try
            {
                //以jpg格式保存缩略图 
                switch (imageType.ToLower())
                {
                    case "gif":
                        bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "jpg":
                        bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "bmp":
                        bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "png":
                        bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file1">控件ID</param>
        /// <param name="folerPath">子目录文件夹（无需加斜线）</param>
        /// <param name="allowExtension">支持的扩展名</param>
        /// <param name="fileSize">文件大小（单位M）</param>
        /// <returns></returns>
        public static string Fileupload(FileUpload file1, string folerPath, string[] allowExtension, int fileSize)
        {
            string msg = "";
            Boolean fileOk = false;
            string path = HttpContext.Current.Server.MapPath("~/upload/") + "\\" + folerPath + "\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);//在根目录下建立文件夹 
            }
            if (file1.HasFile)
            {
                //取得文件的扩展名,并转换成小写            
                string fileExtension = System.IO.Path.GetExtension(file1.FileName).ToLower();

                //对上传的文件的类型进行一个个匹对            
                for (int i = 0; i < allowExtension.Length; i++)
                {
                    if (fileExtension == allowExtension[i])
                    {
                        fileOk = true;
                        break;
                    }
                }
                //            
                if (!fileOk)
                {
                    msg = "要上传的文件类型不对！";
                }
                //对上传文件的大小进行检测，限定文件最大不超过8M            
                if (file1.PostedFile.ContentLength > fileSize * 1024000)
                {
                    fileOk = false;
                }
                //最后的结果            
                if (fileOk)
                {
                    try
                    {
                        Random ra = new Random();
                        int randomInt = ra.Next(0, 100);
                        string sourcePath = path + DateTime.Now.ToString("yyyyMMddhhmmss") + randomInt + fileExtension;
                        string outPath = "/upload/" + folerPath + "/" + DateTime.Now.ToString("yyyyMMddhhmmss") + randomInt + fileExtension;
                        file1.PostedFile.SaveAs(sourcePath);
                        msg = "上传成功|" + outPath;
                    }
                    catch
                    {
                        msg = "上传失败";
                    }
                }
                else
                {
                    msg = "文件类型或者文件大小超出" + fileSize + "M或者文件类型不对";
                }
            }
            return msg;
        }

        public static DataTable AddDtColumns(DataTable dt, string colName, string[] showArray)
        {
            dt.Columns.Add(colName + "String");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < showArray.Length; j++)
                {
                    if (j.ToString().Equals(dt.Rows[i][colName].ToString()))
                    {
                        dt.Rows[i][colName + "String"] = showArray[j];
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// 从字符串的指定位置截取指定长度的子字符串
        /// </summary>
        /// <param name="str">原字符串</param>
        /// <param name="startIndex">子字符串的起始位置</param>
        /// <param name="length">子字符串的长度</param>
        /// <returns>子字符串</returns>
        public static string CutString(string str, int startIndex, int length)
        {
            if (startIndex >= 0)
            {
                if (length < 0)
                {
                    length = length * -1;
                    if (startIndex - length < 0)
                    {
                        length = startIndex;
                        startIndex = 0;
                    }
                    else
                    {
                        startIndex = startIndex - length;
                    }
                }


                if (startIndex > str.Length)
                {
                    return "";
                }


            }
            else
            {
                if (length < 0)
                {
                    return "";
                }
                else
                {
                    if (length + startIndex > 0)
                    {
                        length = length + startIndex;
                        startIndex = 0;
                    }
                    else
                    {
                        return "";
                    }
                }
            }

            if (str.Length - startIndex < length)
            {
                length = str.Length - startIndex;
            }

            return str.Substring(startIndex, length);
        }
    }
}

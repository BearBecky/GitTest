using Ionic.Zip;
using Newtonsoft.Json;
using ProjectTestAPI.Areas.v1.Models.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class FtpDownlodaFileController : ApiController
    {


        // GET: api/FtpDownlodaFile/5
        public XmlDocument Get()
        {
            //FtpWebRequest reqFTP;
            //string filePath = "E://Data//Desktop";
            //string fileName = "HtlList.zip";
            string ftpUserID = "cibhagt";
            string ftpPassword = "AhUKtgvfr8&%";
            //string ftpServerIP = "bh.china-airlines.com:1099";
            string error = "";
            string zipUrl = @"E:\Data\Desktop\HtlList.zip";
            string ftpServerIP = "ftp://bh.china-airlines.com:1099/";
            string zipfilename = "HtlList.zip";

            string strDirePath = @"E:\Data\Desktop\";
            XmlDocument xml = new XmlDocument();
            string content = string.Empty;
            XmlSerializer xs = new XmlSerializer(typeof(BUDGETHOLIDAY));
            try
            {

                #region ftp 下載 zip
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerIP + zipfilename);
                request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                request.UseBinary = true; // Use binary to ensure correct dlv!
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.KeepAlive = true;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                FileStream writer = new FileStream(zipUrl, FileMode.Create);
               
                long length = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[2048];

                readCount = responseStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    writer.Write(buffer, 0, readCount);
                    readCount = responseStream.Read(buffer, 0, bufferSize);
                }

                responseStream.Close();
                response.Close();
                writer.Close();
                #endregion

                #region 解壓縮(壓縮檔內不包含資料夾的文件)
                using (ZipFile zip = ZipFile.Read(zipUrl))
                {
                   
                    foreach (ZipEntry entry in zip.Entries)
                    {
                        if (entry.FileName == zipfilename.Replace(".zip","/")) 
                        {
                            if (!System.IO.Directory.Exists(strDirePath + entry.FileName))
                            {
                                System.IO.Directory.CreateDirectory(strDirePath + entry.FileName);
                            } 
                            continue;
                        }
                        using (var ms = new MemoryStream())
                        {
                            entry.Extract(ms);

                            // 使用 DotNetZip 會導致 MemoryStream 的 Position 不在最前面
                            // 這會導致後續抓不到檔案，所以讀取後必須把 Position 歸零！
                            ms.Position = 0;

                            using (BinaryReader reader = new BinaryReader(ms))
                            {
                                File.WriteAllBytes(
                                    Path.Combine(strDirePath, entry.FileName),
                                    reader.ReadBytes((int)ms.Length));
                            }

                        }
                        #region 讀取xml 檔案
                        xml.Load(strDirePath + entry.FileName);
                        
                        #endregion
                        
                    }
                }

                #endregion


                
                return xml;
            }
             catch (Exception ex)
            {
                error = ex.Message;
            }

            return xml;
        }
    }
}
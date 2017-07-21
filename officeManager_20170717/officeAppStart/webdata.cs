﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

/*
namespace officeAppStart
{
    // 웹에 올려둔 UM.txt 파일과 UM.zip 파일을 로컬로 다운로드 받는 역할을 하는 클래스
    class webdata
    {
    }
}
*/

namespace F1Soft
{
 
    public delegate void BytesDownloadedEventHandler(ByteArgs e);
 
    public class ByteArgs : EventArgs
    {
        private int _downloaded;
        private int _total;
 
        public int downloaded
        {
           get
           {
               return _downloaded;
           }
           set
           {
               _downloaded = value;
           }
        }
 
        public int total
        {
           get
           {
               return _total;
           }
           set
           {
               _total = value;
           }
        }
 
    }
 
    // [URL]에 위치한 [file]을 받아서 [targetFolder]에 내려받는다.
    class webdata
    {
 
        public static event BytesDownloadedEventHandler bytesDownloaded;
 
        public static bool downloadFromWeb(string URL, string file, string targetFolder)
        {
           try
           {
 
               byte[] downloadedData;

               downloadedData = new byte[0];
 
               //open a data stream from the supplied URL
               WebRequest webReq = WebRequest.Create(URL + file);
               WebResponse webResponse =webReq.GetResponse();
               Stream dataStream =webResponse.GetResponseStream();
 
               //Download the data in chuncks
               byte[] dataBuffer = new byte[1024];
 
               //Get the total size of the download
               int dataLength = (int)webResponse.ContentLength;
 
               //lets declare our downloaded bytes event args
               ByteArgs byteArgs = new ByteArgs();
 
               byteArgs.downloaded = 0;
               byteArgs.total = dataLength;
 
               //we need to test for a null as if an event isnot consumed we will get an exception
               if (bytesDownloaded != null) bytesDownloaded(byteArgs);
 
 
               //Download the data
               MemoryStream memoryStream = new MemoryStream();
               while (true)
               {
                    //Let'stry and read the data
                    int bytesFromStream = dataStream.Read(dataBuffer, 0, dataBuffer.Length);
 
                    if(bytesFromStream == 0)
                    {
 
                        byteArgs.downloaded =dataLength;
                        byteArgs.total =dataLength;
                        if (bytesDownloaded != null)bytesDownloaded(byteArgs);
 
                        //Download complete
                        break;
                    }
                    else
                    {
                        //Write the downloaded data
                       memoryStream.Write(dataBuffer, 0, bytesFromStream);
 
                        byteArgs.downloaded = bytesFromStream;
                        byteArgs.total =dataLength;
                        if (bytesDownloaded != null)bytesDownloaded(byteArgs);
 
                    }
               }
 
               //Convert the downloaded stream to a bytearray
                downloadedData =memoryStream.ToArray();
 
               //Release resources
               dataStream.Close();
               memoryStream.Close();
 
               //Write bytes to the specified file
               FileStream newFile = new FileStream(targetFolder+ file, FileMode.Create);
               newFile.Write(downloadedData, 0, downloadedData.Length);
               newFile.Close();
 
               return true;
 
           }
 
           catch (Exception)
            {
               //We may not be connected to the internet
               //Or the URL may be incorrect
               return false;
           }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using F1Soft;
using System.Diagnostics;
using Ionic.Zip;

namespace officeAppStart
{
    // 내려받은 UM.txt에 있는 버전숫자와 로컬에 있는 UM.txt파일의 버전숫자를 비교해서 올려둔 버전이 더 최신이면 업데이트(update)를 실행하는 역할을 할 클래스
    class update
    {

        /// <summary>Get updateand version information from specified online file - returns a List</summary>
        /// <param name="downloadsURL">URL to download file from</param>
        /// <param name="versionFile">Name of the pipe| delimited version file to download</param>
        /// <param name="resourceDownloadFolder">Folder on the local machine to download the version file to</param>
        /// <paramname="startLine">Line number, ofthe version file, to read the version information from</param>
        /// <returns>Listcontaining the information from the pipe delimited version file</returns>
        public static List<string> getUpdateInfo(string downloadsURL, string versionFile, string resourceDownloadFolder, int startLine)
        {
 
           bool updateChecked = false;
 
           //create download folder if it does not exist
           if (!Directory.Exists(resourceDownloadFolder))
           {
 
               Directory.CreateDirectory(resourceDownloadFolder);
 
           }
 
           //let's try and download update informationfrom the web
           updateChecked = webdata.downloadFromWeb(downloadsURL,versionFile, resourceDownloadFolder);
 
           //if the download of the file was successful
           if (updateChecked)
           {
 
               //get information out of download info file
               return populateInfoFromWeb(versionFile,resourceDownloadFolder, startLine);
 
           }
           //there is a chance that the download of thefile was not successful
           else
           {
 
               return null;
 
           }
 
        }
 
 
 
        /// <summary>Download file from the web immediately</summary>
        /// <param name="downloadsURL">URL to download file from</param>
        /// <param name="filename">Name of the file to download</param>
        /// <param name="downloadTo">Folder on the local machine to download the file to</param>
        /// <param name="unzip">Unzip the contents of the file</param>
        /// <returns>Void</returns>
        public static void installUpdateNow(string downloadsURL, string filename, string  downloadTo, bool unzip)
        {
 
           bool downloadSuccess = webdata.downloadFromWeb(downloadsURL, filename, downloadTo);
 
           if (unzip)
           {
 
               unZip(downloadTo + filename, downloadTo);
 
           }
 
        }
 
 
        /// <summary>Starts theupdate application passing across relevant information</summary>
        /// <param name="downloadsURL">URL to download file from</param>
        /// <param name="filename">Name of the file to download</param>
        /// <param name="destinationFolder">Folder on the local machine to download the file to</param>
        /// <param name="processToEnd">Name of the process to end before applying the updates</param>
        /// <param name="postProcess">Name of the process to restart</param>
        /// <param name="startupCommand">Command line to be passed to the process to restart</param>
        /// <param name="updater"></param>
        /// <returns>Void</returns>
        public static void installUpdateRestart(string downloadsURL, string filename, string  destinationFolder, string processToEnd, string postProcess, string startupCommand, string updater)
        {
 
           string cmdLn = "";
 
           cmdLn += "|downloadFile|" +filename;
           cmdLn += "|URL|" +downloadsURL;
           cmdLn += "|destinationFolder|"+ destinationFolder;
           cmdLn += "|processToEnd|" +processToEnd;
           cmdLn += "|postProcess|" +postProcess;
           cmdLn += "|command|" + @" / " + startupCommand;
 
            ProcessStartInfo startInfo = new ProcessStartInfo();
           startInfo.FileName = updater;
           startInfo.Arguments = cmdLn;
           Process.Start(startInfo);
 
        }
 
 
 
        public static List<string> populateInfoFromWeb(string versionFile, string  resourceDownloadFolder, int line)
        {
 
           List<string> tempList = new List<string>();
           int ln;
           int i;
 
           ln = 0;
 
           if (File.Exists(resourceDownloadFolder+ versionFile))
               foreach (string  strline in File.ReadAllLines(resourceDownloadFolder+ versionFile))
               {
 
                    if(ln == line)
                    {
 
                        string[] parts = strline.Split('|');
                       foreach(string part in  parts)
                        {
 
                            tempList.Add(part);
 
                        }
 
                        return tempList;
 
                    }
 
                    ln++;
               }
 
 
            return null;
 
        }
 
 
 
 
        private static bool unZip(string file, string unZipTo)//,bool deleteZipOnCompletion)
        {
           try
           {
 
               // Specifying Console.Out here causesdiagnostic msgs to be sent to the Console
               // In a WinForms or WPF or Web app, you couldspecify nothing, or an alternate
               // TextWriter to capture diagnostic messages.
 
               using (ZipFile  zip = ZipFile.Read(file))
               {
                    //This call to ExtractAll() assumes:
                    //   - none of the entries arepassword-protected.
                    //   - want to extract all entries to current workingdirectory
                    //   - none of the files in the zip already existin the directory;
                    //     if they do, the method will throw.
                    zip.ExtractAll(unZipTo);
               }
 
               //if (deleteZipOnCompletion)File.Delete(unZipTo + file);
 
           }
           catch (System.Exception)
           {
               return false;
           }
 
           return true;
 
        }
 
        /// <summary>Updates theupdate application by renaming prefixed files</summary>
        /// <param name="updaterPrefix">Prefix of files to be renamed</param>
        /// <param name="containingFolder">Folder on the local machine where the prefixed files exist</param>
        /// <returns>Void</returns>
        public static void updateMe(string updaterPrefix, string containingFolder)
        {
 
           DirectoryInfo dInfo = new DirectoryInfo(containingFolder);
           FileInfo[] updaterFiles =dInfo.GetFiles(updaterPrefix + "*");
           int fileCount = updaterFiles.Length;
 
           foreach (FileInfo file in updaterFiles)
           {
 
               string newFile = containingFolder +file.Name;
               string origFile = containingFolder + @"\" +file.Name.Substring(updaterPrefix.Length, file.Name.Length -updaterPrefix.Length);
 
               if (File.Exists(origFile)){ File.Delete(origFile); }
 
               File.Move(newFile, origFile);
 
           }
 
        }

    }
}

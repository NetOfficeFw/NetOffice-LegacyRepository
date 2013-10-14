﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NetOffice.Tools;
using NetOffice.OutlookApi.Tools;
using NetOffice.OutlookApi;

/*
  * This project shows you the COMAddin base class from the NetOffice tools.
  * Its designed to reduce infrastructure code from your own.
  * You have to set some attributes and thats all. 
  * You see also the host application is available as class instance property. no need for dispose here because the base class do this for you while shutdown.
*/

namespace NetOfficeTools.SimpleOutlookCS4
{
    [COMAddin("NetOfficeCS4 Sample Outlook Addin", "This Addin shows you the COMAddin base class from the NetOffice Tools", 3)]
    [Guid("E84FBA68-FDA6-4cf6-A0E7-5F025C0F9867"), ProgId("SimpleOutlookCS4.Addin")]
    public class Addin : COMAddin
    {
        public Addin()
        {
            this.OnStartupComplete += new OnStartupCompleteEventHandler(Addin_OnStartupComplete);
            this.OnDisconnection += new OnDisconnectionEventHandler(Addin_OnDisconnection);
        }

        void Addin_OnStartupComplete(ref Array custom)
        {
            // get the host application version
            string hostVersion = this.Application.Version;
            Console.WriteLine("Host Application Version is:{0}", hostVersion);
        }

        void Addin_OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace LocalDataPersistent.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            string dbPath = FileAccessHelper.GetLocalFilePath("LocalDataPersistent.db3");
            LoadApplication(new App(dbPath));

            return base.FinishedLaunching(app, options);
        }
    }
}

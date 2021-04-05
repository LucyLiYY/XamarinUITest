using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossPlatform_UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile("C:/Users/yangl/Downloads/UPS Mobile_v9.1.0.10_apkpure.com.apk")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}
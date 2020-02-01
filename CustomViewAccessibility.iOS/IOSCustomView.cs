using System;
using CustomViewAccessibility;
using CustomViewAccessibility.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ICustomViewRenderer), typeof(IOSCustomView))]
namespace CustomViewAccessibility.iOS
{
    public class IOSCustomView : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                return;
            }

            Console.WriteLine("PIPPO created from IOS");
            Control.BackgroundColor = UIColor.Red;
        }

        public override void AccessibilityElementDidBecomeFocused()
        {
            base.AccessibilityElementDidBecomeFocused();

            Console.WriteLine("PIPPO I am in focus");
        }
    }
}
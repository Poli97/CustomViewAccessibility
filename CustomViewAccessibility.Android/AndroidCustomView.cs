using System;
using Android.Content;
using Android.Views.Accessibility;
using CustomViewAccessibility;
using CustomViewAccessibility.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ICustomViewRenderer), typeof(AndroidCustomView))]
namespace CustomViewAccessibility.Droid
{
    public class AndroidCustomView : ButtonRenderer
    {
        public AndroidCustomView(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                return;
            }

            Console.WriteLine("PIPPO created from Android");
            Control.SetBackgroundColor(Android.Graphics.Color.Orange);
        }

        public override void OnPopulateAccessibilityEvent(AccessibilityEvent e)
        {
            base.OnPopulateAccessibilityEvent(e);

            if (e.EventType == EventTypes.ViewAccessibilityFocused)
            {
                Console.WriteLine("PIPPO I am in focus");
            }
        }
    }
}

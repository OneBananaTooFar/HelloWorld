// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HelloWorldiOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DivideButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelAnswer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MultiplyButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SubtractButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt1stnum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt2ndnum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel txtAnswer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtnumb1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtnumb2 { get; set; }

        [Action ("UIButton398_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton398_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton625_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton625_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddButton != null) {
                AddButton.Dispose ();
                AddButton = null;
            }

            if (DivideButton != null) {
                DivideButton.Dispose ();
                DivideButton = null;
            }

            if (labelAnswer != null) {
                labelAnswer.Dispose ();
                labelAnswer = null;
            }

            if (MultiplyButton != null) {
                MultiplyButton.Dispose ();
                MultiplyButton = null;
            }

            if (SubtractButton != null) {
                SubtractButton.Dispose ();
                SubtractButton = null;
            }

            if (txt1stnum != null) {
                txt1stnum.Dispose ();
                txt1stnum = null;
            }

            if (txt2ndnum != null) {
                txt2ndnum.Dispose ();
                txt2ndnum = null;
            }

            if (txtAnswer != null) {
                txtAnswer.Dispose ();
                txtAnswer = null;
            }

            if (txtnumb1 != null) {
                txtnumb1.Dispose ();
                txtnumb1 = null;
            }

            if (txtnumb2 != null) {
                txtnumb2.Dispose ();
                txtnumb2 = null;
            }
        }
    }
}
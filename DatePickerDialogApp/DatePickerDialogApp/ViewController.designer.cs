// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DatePickerDialogApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPickDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel selectedDate { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnPickDate != null) {
                btnPickDate.Dispose ();
                btnPickDate = null;
            }

            if (selectedDate != null) {
                selectedDate.Dispose ();
                selectedDate = null;
            }
        }
    }
}
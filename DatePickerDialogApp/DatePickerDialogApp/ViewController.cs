using System;
using DatePickerDialogApp.Helper;
using UIKit;

namespace DatePickerDialogApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            btnPickDate.TouchUpInside+=BtnPickDate_TouchUpInside;
        }

        void BtnPickDate_TouchUpInside(object sender, EventArgs e)
        {
            var startingTime = DateTime.Now;
            var dialog = new DatePickerDialog();
            dialog.Show("Choose date", "Done", "Cancel", UIDatePickerMode.Date, (dt) => {
                selectedDate.Text = dt.ToString("dd-MM-yyyy");
            }, startingTime);
        }

    }
}

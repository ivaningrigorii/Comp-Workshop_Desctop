using System;
using System.Windows.Forms;

namespace course_project
{
    /// <summary>
    /// В классе WindowSwither
    /// next - переход от одной к другой форме,
    /// а next_ и return_ - переходы через главную форму
    /// </summary>
    static class WindowSwither
    {
        static Form formStart_ = new Form();
        static Form _seakForm = new Form();


        static public void next(Form last, Form next)
        {
            Cursor.Current = Cursors.WaitCursor;

            next.Location = last.Location;
            next.WindowState = last.WindowState;

            next.Show();
            next.FormClosed += formClosing_;

            next.Location = last.Location;
            next.WindowState = last.WindowState;
            next.Size = last.Size;

            last.FormClosed -= formClosing_;
            last.Close();

            Cursor.Current = Cursors.Default;
        }

        static public void next_(Form start, Form next)
        {
            Cursor.Current = Cursors.WaitCursor;

            formStart_ = start;

            next.Location = formStart_.Location;
            next.WindowState = formStart_.WindowState;

            next.FormClosed += formClosing_;
            next.Show();

            next.Location = formStart_.Location;
            next.WindowState = formStart_.WindowState;
            next.Size = formStart_.Size;

            formStart_.Hide();

            Cursor.Current = Cursors.Default;
        }

        static public void return_(Form last)
        {
            Cursor.Current = Cursors.WaitCursor;

            formStart_.WindowState = last.WindowState;
            formStart_.Location = last.Location;


            formStart_.Show();

            formStart_.WindowState = last.WindowState;
            formStart_.Location = last.Location;
            formStart_.Size = last.Size;

            last.FormClosed -= formClosing_;
            last.Close();

            Cursor.Current = Cursors.Default;
        }

        public static void seak(Form last, Form next)
        {
            Cursor.Current = Cursors.WaitCursor;

            next.Location = last.Location;
            next.WindowState = last.WindowState;

            next.Show();
            next.FormClosed += formClosing_;

            next.Location = last.Location;
            next.WindowState = last.WindowState;
            next.Size = last.Size;

            _seakForm = last;
            
            last.Hide();

            Cursor.Current = Cursors.Default;
        }

        public static void show(Form last)
        {
            Cursor.Current = Cursors.WaitCursor;

            _seakForm.Location = last.Location;
            _seakForm.WindowState = last.WindowState;

            _seakForm.Show();

            _seakForm.Location = last.Location;
            _seakForm.WindowState = last.WindowState;
            _seakForm.Size = last.Size;

            last.FormClosed -= formClosing_;

            last.Close();

            Cursor.Current = Cursors.Default;
        }


        public static void formClosing_(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

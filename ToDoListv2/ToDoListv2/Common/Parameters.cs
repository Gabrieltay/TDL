using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;

namespace ToDoListv2.Common
{
    public static class Parameters
    {
        public enum DEADLINE_DISPLAY
        {
            DATE,
            SPAN
        }

        public static DEADLINE_DISPLAY Deadline_P = DEADLINE_DISPLAY.DATE;

        public static Font Font_P = new Font( "Lucida Console", 11.25f );

        public static Boolean DropboxEnabled_P = false;

        public static String DropboxDir_P = "C:\\";

        public static Boolean Display_Prior_P = true;
    }
}

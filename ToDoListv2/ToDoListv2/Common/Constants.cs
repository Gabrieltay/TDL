using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListv2.Common
{
    public class Constants
    {
        public const String DEFAULT_FILE = "myData.tdl";

        public const int EXPIRE_DAYS = 7;

        public const int LISTVIEWITEM_HEIGHT = 20;

        public const int LISTVIEW_HEIGHT = 455;

        public const int LISTVIEW_WIDTH = 384;

        public const int AUTOSAVE_INTERVAL = 1000 * 3;

        public const int ANIMATION_INTERVAL = 1000 * 5;

        public const int SYNC_INTERVAL = AUTOSAVE_INTERVAL * 3;

        public const String TICK = "tick";

        public const String UNTICK = "untick";

        public const int PRIORITY_COLUMN_WIDTH = 60;

        public const double TRANSLUCENT = 0.9;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMParser
{
    public class UserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        public String DefaultSavePath
        {
            get
            {
                return "";
            }
            set
            {
                this["DefaultSavePath"] = value;
            }
        }

        public String DefaultLogPath
        {
            get
            {
                return "";
            }
            set
            {
                this["DefaultLogPath"] = value;
            }
        }

    }
}

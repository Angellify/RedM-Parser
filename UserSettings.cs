using System.Configuration;

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

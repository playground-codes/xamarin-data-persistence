using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace LocalDataPersistent
{
    public class PreferenceHelper
    {
        readonly ISettings settings;
        const string NAME_KEY = "pref_name";
        const string AGE_KEY = "pref_age";
        const string EMAIL_KEY = "pref_email";

        public PreferenceHelper()
        {
            settings = CrossSettings.Current;
        }

        public string Name
        {
            set
            {
                settings.AddOrUpdateValue(NAME_KEY, value);
            }

            get
            {
                return settings.GetValueOrDefault(NAME_KEY, "");
            }
        }

        public int Age
        {
            set
            {
                settings.AddOrUpdateValue(AGE_KEY, value);
            }

            get
            {
                return settings.GetValueOrDefault(AGE_KEY, -1);
            }
        }

        public string Email
        {
            set
            {
                settings.AddOrUpdateValue(EMAIL_KEY, value);
            }

            get
            {
                return settings.GetValueOrDefault(EMAIL_KEY, "");
            }
        }
    }
}

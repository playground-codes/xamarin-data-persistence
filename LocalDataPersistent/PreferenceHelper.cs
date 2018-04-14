using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace LocalDataPersistent
{
    public class PreferenceHelper
    {
        private ISettings settings;
        private const string NAME_KEY = "pref_name";
        private const string AGE_KEY = "pref_age";
        private const string EMAIL_KEY = "pref_email";

        public PreferenceHelper()
        {
            settings = CrossSettings.Current;
        }

        public void SaveName(string name) {
            settings.AddOrUpdateValue(NAME_KEY, name);
        }

        public void SaveAge(int age) {
            settings.AddOrUpdateValue(AGE_KEY, age);
        }

        public void SaveEmail(string email) {
            settings.AddOrUpdateValue(EMAIL_KEY, email);
        }

        public string GetName() {
            return settings.GetValueOrDefault(NAME_KEY, "");
        }

        public int GetAge() {
            return settings.GetValueOrDefault(AGE_KEY, -1);
        }

        public string GetEmail() {
            return settings.GetValueOrDefault(EMAIL_KEY, "");
        }
    }
}

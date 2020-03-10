using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kleintierzucht_Manager.Klassen
{
    public class Settings
    {
        private string _settingVersion = "1";
        private string _filepath;

        public Settings()
        {

        }

        public string Filepath { get => _filepath; private set => _filepath = value; }
        
        public Settings LoadSettings()
        {
            var res = new Settings();
            //Lade daten aus Konfig file
            string v = ReadSetting("ConfigVersion");
            if (v != _settingVersion)
            {
                //Update Config File
                //Wenn version Nicht gefunden Hinzufügen
                if(v == "Not Found")
                {

                }

            }

            return res;
        }
         string ReadSetting(string key)
         {
            string result = "false";
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException ex)
            {
                result = ex.BareMessage;
                return result;
            }
         }
        void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}

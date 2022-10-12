using System;

namespace MakoIoT.Device.Services.Interface
{
    public interface IConfigurationService
    {
        object GetConfigSection(string sectionName, Type objectType);
        void UpdateConfigSection(string sectionName, object section);
        bool UpdateConfigSectionString(string sectionName, string sectionString);
        bool UpdateConfigSectionString(string sectionName, string sectionString, Type objectType);

        event EventHandler ConfigurationUpdated;
        void WriteDefault(string sectionName, object section, bool overwrite = false);
        string[] GetSections();
        string LoadConfigSection(string sectionName);
        bool ClearAll();
    }
}

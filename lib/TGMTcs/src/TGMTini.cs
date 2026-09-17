//CÔNG TY TNHH GIẢI PHÁP THỊ GIÁC MÁY TÍNH
//support@viscomsolution.com
//0939.825.125

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGMTcs
{
    public class TGMTini
    {
        string m_filePath;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        static TGMTini m_instance;

        private Dictionary<string, Dictionary<string, string>> _iniData;

        public string DefaultSection = "";

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static TGMTini GetInstance()
        {
            if (m_instance == null)
                m_instance = new TGMTini();
            return m_instance;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public void LoadConfig(string iniPath, string defaultSection)
        {
            if(!File.Exists(iniPath))
            {
                MessageBox.Show(iniPath, "Không tìm thấy file config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            m_filePath = new FileInfo(iniPath ?? EXE + ".ini").FullName;
            DefaultSection = defaultSection;

            _iniData = new Dictionary<string, Dictionary<string, string>>();
            string currentSection = "";

            foreach (var line in File.ReadLines(m_filePath, Encoding.UTF8))
            {
                string trimmed = line.Trim();
                if (trimmed.StartsWith("[") && trimmed.EndsWith("]"))
                {
                    currentSection = trimmed.Trim('[', ']');
                    if (!_iniData.ContainsKey(currentSection))
                        _iniData[currentSection] = new Dictionary<string, string>();
                }
                else if (trimmed.Contains("="))
                {
                    var parts = trimmed.Split(new[] { '=' }, 2);
                    if (currentSection != "")
                    {
                        _iniData[currentSection][parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public string ReadString(string key, string defaultValue="", string section = null)
        {
            if (section == null && DefaultSection != "")
                section = DefaultSection;

            try
            {
                if (_iniData.TryGetValue(section, out var keys))
                {
                    if (keys.TryGetValue(key, out var value))
                        return value;
                }
            }
            catch
            {
            }

            
            return defaultValue;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public int ReadInt(string key, int defaultValue = 0, string section = null)
        {
            if (section == null && DefaultSection != "")
                section = DefaultSection;

            try
            {
                return Convert.ToInt32(ReadString(key, defaultValue.ToString(), section));
            }
            catch
            {
                return defaultValue;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public float ReadFloat(string key, float defaultValue = 0, string section = null)
        {
            if (section == null && DefaultSection != "")
                section = DefaultSection;

            try
            {
                return float.Parse(ReadString(key, defaultValue.ToString(), section));
            }
            catch
            {
                return defaultValue;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public bool ReadBool(string key, bool defaultValue = false, string section = null)
        {
            if (section == null && DefaultSection != "")
                section = DefaultSection;

            try
            {
                string val = ReadString(key, defaultValue.ToString(), section).ToLower();
                return val == "1" || val == "true";
            }
            catch
            {
                return defaultValue;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public void SaveValue(string key, string value, string section = null)
        {
            if (string.IsNullOrEmpty(key))
                return;

            if (string.IsNullOrEmpty(section) && DefaultSection != "")
                section = DefaultSection;

            // Update in-memory dictionary
            if (!_iniData.ContainsKey(section))
                _iniData[section] = new Dictionary<string, string>();

            _iniData[section][key] = value;

            // Save to file
            if (string.IsNullOrEmpty(m_filePath))
                throw new InvalidOperationException("File path not set. Call Load(filePath) first.");

            using (StreamWriter writer = new StreamWriter(m_filePath, false, Encoding.UTF8))
            {
                foreach (var sec in _iniData)
                {
                    writer.WriteLine($"[{sec.Key}]");
                    foreach (var kv in sec.Value)
                    {
                        writer.WriteLine($"{kv.Key}={kv.Value}");
                    }
                    writer.WriteLine(); // Add an empty line between sections
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public void SaveValue(string key, int value, string section = null)
        {
            SaveValue(key, value.ToString(), section);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public void SaveValue(string key, bool value, string section = null)
        {
            SaveValue(key, value ? "1" : "0", section);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public void SaveValue(string key, float value, string section = null)
        {
            SaveValue(key, value.ToString(), section);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteKey(string key, string section = null)
        {
            SaveValue(key, null, section);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteSection(string section = null)
        {
            SaveValue(null, null, section);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public bool IsKeyExists(string key, string section = null)
        {
            return ReadString(key, section).Length > 0;
        }

    }
}

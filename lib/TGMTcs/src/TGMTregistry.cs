//CÔNG TY TNHH GIẢI PHÁP THỊ GIÁC MÁY TÍNH
//support@viscomsolution.com
//0939.825.125

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TGMTcs
{
    public class TGMTregistry
    {
        static TGMTregistry m_instance;
        RegistryKey m_regKey;

        public bool Inited { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public TGMTregistry()
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static TGMTregistry GetInstance()
        {
            if (m_instance == null)
                m_instance = new TGMTregistry();
            return m_instance;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Init(string key)
        {
            m_regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + key, true);
            if (m_regKey == null)
            {
                Registry.CurrentUser.OpenSubKey("SOFTWARE", true).CreateSubKey(key);
                m_regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + key, true);
            }
            Inited = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteKey(string value)
        {
            try
            {
                m_regKey.DeleteValue(value);
            }
            catch(Exception ex)
            {
            }            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void SaveValue(string key, object value)
        {
            m_regKey.SetValue(key, value);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public string ReadString(string key, string defaultData ="")
        {
            Object data = m_regKey.GetValue(key);
            if (data == null)
                return defaultData;
            else
                return data.ToString();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public int ReadInt(string key, int defaultData = 0)
        {
            Object data = m_regKey.GetValue(key);
            if (data == null)
                return defaultData;
            else
                return int.Parse(data.ToString());
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool ReadBool(string key, bool defaultData = false)
        {
            string value = ReadString(key);
            if (value == null || value == "")
                return defaultData;

            return value.ToLower() == "true" || value == "1";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public float ReadFloat(string key, float defaultData = 0)
        {
            Object data = m_regKey.GetValue(key);
            if (data == null)
                return defaultData;
            else
                return float.Parse((string)data);
        }
    }
}

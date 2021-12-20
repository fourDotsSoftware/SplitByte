using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace SplitByte
{
    class RegistryHelper
    {
        public static void FillComboBoxWithValues(ref ComboBox cmb, string cmbkey)
        {
            if (Module.Portable) return;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software", true);

            RegistryKey key0 = null;
            RegistryKey key01 = null;
            RegistryKey key02 = null;

            try
            {
                key0 = key.OpenSubKey("4dots Software", true);

                if (key0==null)
                {
                    key0 = key.CreateSubKey("4dots Software");
                }

                key01 = key0.OpenSubKey("Split Byte", true);

                if (key01==null)
                {
                    key01=key0.CreateSubKey("Split Byte");
                }

                key02 = key01.OpenSubKey(cmbkey, true);

                if (key02==null)
                {
                    key02 = key01.CreateSubKey(cmbkey);
                }

                key = key02;

            if (key != null)
                {
                    string[] valn = key.GetValueNames();

                    for (int k = 0; k < valn.Length; k++)
                    {
                        cmb.Items.Add(key.GetValue(valn[k], ""));
                    }
                }
            }
            finally
            {
                try
                {
                    if (key != null)
                    {
                        key.Close();
                    }
                }
                catch { }

                try
                {
                    if (key01 != null)
                    {
                        key01.Close();
                    }
                }
                catch { }

                try
                {
                    if (key02 != null)
                    {
                        key02.Close();
                    }
                }
                catch { }

                try
                {
                    if (key0 != null)
                    {
                        key0.Close();
                    }
                }
                catch { }
            }
        }

        public static string GetKeyValue(string keystr)
        {
            if (Module.Portable) return "";

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\4dots Software\Split Byte\");

            if (key != null)
            {
                return key.GetValue(keystr, "").ToString();
            }

            return "";
        }

        public static bool SetKeyValue(string keystr,string keyvalue)
        {
            if (Module.Portable) return false;

            RegistryKey key = null;
            RegistryKey key0 = null;
            RegistryKey key1 = null;

            try
            {

                key = Registry.CurrentUser.OpenSubKey(@"Software", true);

                key0 = key.OpenSubKey("4dots Software", true);

                if (key0==null)
                {
                    key0 = key.CreateSubKey("4dots Software");
                }

                key1 = key0.OpenSubKey("Split Byte", true);

                if (key1==null)
                {
                    key1 = key0.CreateSubKey("Split Byte");
                }

                key = key1;

                //key = Registry.CurrentUser.OpenSubKey(@"Software\4dots Software\Split Byte\",true);

                if (key != null)
                {
                    key.SetValue(keystr, keyvalue);
                }

                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                try
                {
                    if (key != null)
                    {
                        key.Close();
                    }
                }
                catch { }

                try
                {
                    if (key0 != null)
                    {
                        key0.Close();
                    }
                }
                catch { }

                try
                {
                    if (key1 != null)
                    {
                        key1.Close();
                    }
                }
                catch { }
            }
        }

        public static bool AddingCombo = false;

        public static void AddValueToComboBox(ref ComboBox cmb, string cmbkey)
        {
            if (Module.Portable) return;

            string cmbval = cmb.Text;

            //Module.ShowMessage(cmbval);

            RegistryKey key = null;
            RegistryKey key0 = null;
            RegistryKey key01 = null;
            RegistryKey key02 = null;
            RegistryKey key03 = null;

            try
            {
                AddingCombo = true;

                key0 = Registry.CurrentUser.OpenSubKey(@"Software", true);

                key01 = key0.OpenSubKey("4dots Software", true);

                if (key01==null)
                {
                    key0.CreateSubKey("4dots Software");
                }

                key02 = key01.OpenSubKey("Split Byte", true);

                if (key02==null)
                {
                    key02 = key01.CreateSubKey("Split Byte");
                }

                key03 = key02.OpenSubKey(cmbkey, true);

                if (key03==null)
                {
                    key03 = key02.CreateSubKey(cmbkey);
                }

                //key = Registry.CurrentUser.OpenSubKey(@"Software\4dots Software\Split Byte\" + cmbkey, true);

                key = key03;

                List<string> cmbvals = new List<string>();

                cmb.Items.Clear();

                if (key != null)
                {
                    //Module.ShowMessage("a1");

                    string[] valn = key.GetValueNames();

                    for (int k = 0; k < valn.Length; k++)
                    {
                        cmbvals.Add(key.GetValue(valn[k], "").ToString());
                        key.DeleteValue(valn[k]);
                        //cmb.Items.Add(key.GetValue(valn[k], ""));

                    }

                    cmbvals.Remove(cmbval);
                    cmbvals.Insert(0, cmbval);

                    for (int k = 0; (k < cmbvals.Count) && (k < 20); k++)
                    {
                        key.SetValue("Value " + k.ToString(), cmbvals[k]);
                        cmb.Items.Add(cmbvals[k]);
                    }                    
                }
            }
            catch
            {

            }
            finally
            {
                try
                {
                    key.Close();
                }
                catch { }

                try
                {
                    key0.Close();
                }
                catch { }

                try
                {
                    key01.Close();
                }
                catch { }

                try
                {
                    key02.Close();
                }
                catch { }

                try
                {
                    key03.Close();
                }
                catch { }

                cmb.SelectedIndex = 0;                
                AddingCombo = false;
            }
        }

        public static void FixRegistry()
        {
            if (Module.Portable) return;
                        
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey key2 = key;

            try
            {
                key = key.OpenSubKey("4dots Software", true);

                if (key == null)
                {
                    key = key2.CreateSubKey("4dots Software");

                }

                key2 = key;

                key = key.OpenSubKey("Split Byte", true);

                if (key == null)
                {
                    key = key2.CreateSubKey("Split Byte");
                }

                key2 = key;

                key = key2.OpenSubKey("SplitInputFile", true);

                if (key == null)
                {
                    key2.CreateSubKey("SplitInputFile");

                }

                key = key2.OpenSubKey("CheckWeek", true);

                if (key == null)
                {
                    key2.CreateSubKey("CheckWeek");

                }

                key = key2.OpenSubKey("ShowMessageOnSucess", true);

                if (key == null)
                {
                    key2.CreateSubKey("ShowMessageOnSucess");

                }

                key = key2.OpenSubKey("SplitOutputFolder", true);

                if (key == null)
                {
                    key2.CreateSubKey("SplitOutputFolder");
                }

                key = key2.OpenSubKey("JoinFirstPartFile", true);

                if (key == null)
                {
                    key2.CreateSubKey("JoinFirstPartFile");
                }

                key = key2.OpenSubKey("JoinOutputFile", true);

                if (key == null)
                {
                    key2.CreateSubKey("JoinOutputFile");
                }

                key = key2.OpenSubKey("MD5InputFile", true);

                if (key == null)
                {
                    key2.CreateSubKey("MD5InputFile");
                }

                key = key2.OpenSubKey("MD5Value", true);

                if (key == null)
                {
                    key2.CreateSubKey("MD5Value");
                }

                key = key2.OpenSubKey("SplitWhenFinished", true);

                if (key == null)
                {
                    key2.CreateSubKey("SplitWhenFinished");
                }

                key = key2.OpenSubKey("JoinWhenFinished", true);

                if (key == null)
                {
                    key2.CreateSubKey("JoinWhenFinished");
                }

                key = key2.OpenSubKey("Email Accounts", true);

                if (key == null)
                {
                    key2.CreateSubKey("Email Accounts");
                }

                key = key2.OpenSubKey("Email To", true);

                if (key == null)
                {
                    key2.CreateSubKey("Email To");
                }
            }
            finally
            {
                try
                {
                    if (key != null)
                    {
                        key.Close();
                    }

                    if (key2 != null)
                    {
                        key2.Close();
                    }
                }
                catch { }


                
            }
        }
    }
}

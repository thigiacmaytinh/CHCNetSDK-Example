//CÔNG TY TNHH GIẢI PHÁP THỊ GIÁC MÁY TÍNH
//support@viscomsolution.com
//0939.825.125

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGMTcs
{

    public sealed class AtomicBool
    {
        // 0 = false, 1 = true
        private int _value;

        public AtomicBool(bool initialValue = false)
        {
            _value = initialValue ? 1 : 0;
        }

        public bool Get()
        {
            return Interlocked.CompareExchange(ref _value, 0, 0) == 1;
        }

        public void Set(bool value)
        {
            Interlocked.Exchange(ref _value, value ? 1 : 0);
        }
        public void Reset()
        {
            Interlocked.Exchange(ref _value, 0);
        }
    }

    public class TGMTthread
    {
        public static void BeginInvokeSafe(Control control, Action action)
        {
            try { control.BeginInvoke(action); } catch { }
        }

        public static void InvokeSafe(Control control, Action action)
        {
            try
            {
                if (control.InvokeRequired)
                    control.Invoke(action);
                else
                    action();
            }
            catch { }
        }
    }
}
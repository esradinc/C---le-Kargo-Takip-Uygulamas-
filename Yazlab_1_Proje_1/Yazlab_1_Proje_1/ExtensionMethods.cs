using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab_1_Proje_1
{
    public delegate void Func();

    public static class ExtensionMethods
    {
        public static TResult Invoke<T, TResult>(this T controlToInvokeOn, Func<TResult> code) where T : Control
        {
            if (controlToInvokeOn.InvokeRequired)
            {
                return (TResult)controlToInvokeOn.Invoke(code);
            }
            else
            {
                return (TResult)code();
            }
        }
      
        public static void Invoke(this Control controlToInvokeOn, Func code)
        {
            if (controlToInvokeOn.InvokeRequired)
            {
                controlToInvokeOn.Invoke(code);
            }
            else
            {
                code();
            }
        }
    }
}

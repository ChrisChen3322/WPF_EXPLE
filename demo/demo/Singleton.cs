using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace demo
{
    public sealed class SingletonPattern
    {
        private static readonly SingletonPattern _sigleton = new SingletonPattern();

        //获取唯一可用的对象
        public static SingletonPattern getInstance()
        {
            return _sigleton;
        }

        public void showMessage(string p_txt = "")
        {
            MessageBox.Show(p_txt);
        }
    }
}

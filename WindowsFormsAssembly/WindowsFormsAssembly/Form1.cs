using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace WindowsFormsAssembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取程序集(根据名称进行匹配)
            Assembly asse = Assembly.Load("Assembly.DAL");
            //获取程序集中指定的类对象类型名称
            Type type = asse.GetType("Assembly.DAL.Product");
            //创建一个实例化对象    （为什么这里创建实例化对象）
            //这是将Product类实例化吗
            Object obj = Activator.CreateInstance(type);
            //得到方法的访问权限 进而访问Product类里的方法
            MethodInfo GetProductIDMax = type.GetMethod("GetProductIDMax");
            var values = GetProductIDMax.Invoke(obj, new object[] { 12 }).ToString();
            MessageBox.Show(values);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Assembly asse = Assembly.Load("Assembly.DAL");
            Type type = asse.GetType("Assembly.DAL.Prouct");
            //
            Object obj = Activator.CreateInstance(type);

            FieldInfo Price = type.GetField("Price");
            var values = Price.GetValue(obj).ToString();
            MessageBox.Show(values);

        }
    }
}

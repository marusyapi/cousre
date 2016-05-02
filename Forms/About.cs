using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection; //работа с методанными
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Pituykova
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        public string AssemblyTitle
        {
            get
            {
                //получить все атрибуты Title сборки
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                //если есть хотя бы один атрибут Title
                if (attributes.Length > 0)
                {
                    //выбираем первый
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    //если это не пустая строка, вернуть атрибут
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                //если нет атрибута Title, или если атрибут Title был пустой строкой, вернуть имя с расширением .exe
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                //получить все атрибуты Description сборки
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                //если нет каких-либо Description атрибутов, возвращает пустую строку
                if (attributes.Length == 0)
                {
                    return "";
                }
                //если есть Description атрибут, возвращает его значение
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                //получить все атрибуты Product сборки
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                //если нет каких-либо атрибутов Product, возвращает пустую строку
                if (attributes.Length == 0)
                {
                    return "";
                }
                //если есть атрибут Product, вернуть его значение
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                //получить все атрибуты Copyright сборки
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                //если нет каких-либо атрибутов Copyright, возвращает пустую строку
                if (attributes.Length == 0)
                {
                    return "";
                }
                //если есть атрибут Copyright, вернуть его значение
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                //получить все Company атрибуты сборки
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // Если нет атрибутов любой Company, возвращает пустую строку
                if (attributes.Length == 0)
                {
                    return "";
                }
                //если есть атрибут Company, возвращает его значение
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

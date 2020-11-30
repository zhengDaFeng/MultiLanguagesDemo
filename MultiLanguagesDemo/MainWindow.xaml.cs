using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiLanguagesDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void cmbSelectLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetLanguageDictionary(cmbSelectLanguage.SelectedIndex);
        }

        private void SetLanguageDictionary(int index)
        {
            ResourceDictionary dict = new ResourceDictionary();
            string lang = Thread.CurrentThread.CurrentCulture.ToString();
            switch (index)
            {
                case 0:
                    dict.Source = new Uri("..\\DictionaryLanguageCN.xaml",
                                  UriKind.Relative);
                    break;
                case 1:
                    dict.Source = new Uri("..\\DictionaryLanguageEN.xaml",
                                       UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\DictionaryLanguageCN.xaml",
                                      UriKind.Relative);
                    break;
            }
            this.Resources.MergedDictionaries.Add(dict);
        }
    }
}

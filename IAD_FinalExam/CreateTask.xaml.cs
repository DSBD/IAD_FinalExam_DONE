using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IAD_FinalExam
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateTask : Page
    {
        DateTimeOffset tempDate;
        public CreateTask()
        {
            this.InitializeComponent();

            CalendarDatePicker DueDate = new CalendarDatePicker();
        }
        
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tempDate = (DateTimeOffset)DueDate.Date;
                Debug.WriteLine(tempDate.ToString());
            }
            catch (Exception nex)
            {
                Debug.WriteLine(nex);
            }
            
            if (!String.IsNullOrEmpty(txt_DescBox.Text) && tempDate != null)
            {
                Debug.WriteLine(tempDate.ToString());

                Task sendTask = new Task(txt_DescBox.Text, tempDate.DateTime);

                this.Frame.Navigate(typeof(MainPage), sendTask);
            }
        }
    }
}
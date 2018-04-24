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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IAD_FinalExam
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static List<Task> taskList = new List<Task>();

        public MainPage()
        {
            this.InitializeComponent();

            txt_NumTasks.Text = $"You Have {taskList.Count} Task(s) to Finish";
                        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateTask));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                taskList.Add((Task)e.Parameter);

                txt_NumTasks.Text = $"You Have {taskList.Count} Task(s) to Finish";

                if (taskList.Count > 0)
                {
                    foreach (Task curTask in taskList)
                    {
                        MainTaskList.Items.Add(curTask);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
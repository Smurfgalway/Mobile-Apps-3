using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MA3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreatieProfile : Page
    {
        private IMobileServiceTable<TodoItem> table = App.MobileService.GetTable<TodoItem>();
        private static MobileServiceCollection<TodoItem, TodoItem> mytable;
        public CreatieProfile()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            TodoItem item = new TodoItem
            {
                Name = Name.Text,
                UserName = UserName.Text,
                Password = Password.Text,
                //DOB = DOB.Date,
            };
            await table.InsertAsync(item);
        }
        public static MobileServiceCollection<TodoItem, TodoItem> getContent()
        {
            return mytable;
        }
    }
}

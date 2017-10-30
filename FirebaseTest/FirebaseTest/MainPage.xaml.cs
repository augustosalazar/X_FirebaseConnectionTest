using Firebase.Xamarin.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirebaseTest
{
    public partial class MainPage : ContentPage
    {
        FirebaseClient firebase;
        public MainPage()
        {
            firebase = new FirebaseClient("https://xamarinfirebasevideo.firebaseio.com/");
            InitializeComponent();
        }

        public async Task<int> getList()
        {
            var list = (await firebase
            .Child("yourentity")
            .OnceAsync<Contact>());

            Debug.WriteLine("Número de entradas en firebase " + list.Count);

            return 0;

        }



        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await getList();
        }
    }
}

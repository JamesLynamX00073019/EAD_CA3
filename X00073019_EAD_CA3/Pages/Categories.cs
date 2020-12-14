using Microsoft.AspNetCore.Components; // Allows use of ComponentBase
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// James Lynam - EAD CA3 - X00073019 - Index.cs

namespace X00073019_EAD_CA3.Pages
{
    // Need to declare partial, conflicts otherwise
    // ComponentBase allows us to use code in corresponding razor page
    public partial class Categories : ComponentBase
    {
        public class Kitty
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        // Deserialize to an Array
        private List<Kitty> data;

        public class Root
        {
            public List<Kitty> MyArray { get; set; }
        }


        private Boolean found;
        private string errormessage;


        // Asynchronous method to extra data from API
        private async Task GetDataAsync()
        {
            try
            {
                string uri = "https://api.thecatapi.com/v1/categories";

                // To an Array
                data = await Http.GetJsonAsync<List<Kitty>>(uri);

                found = true;
                errormessage = String.Empty;


            }
            catch (Exception e)
            {

                found = false;
                errormessage = e.Message;


            }
        }
        protected override async Task OnInitializedAsync()
        {
            await GetDataAsync();
        }
    }
}

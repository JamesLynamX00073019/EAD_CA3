using Microsoft.AspNetCore.Components; // Allows use of ComponentBase
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// James Lynam - EAD CA3 - X00073019 - Index.cs

namespace X00073019_EAD_CA3.Pages
{
    // Need to declare partial, conflicts otherwise
    // ComponentBase allows us to use code in corresponding razor page
    public partial class Cat : ComponentBase
    {

        // Class data converted from JSON
        public class Kitty
        {
            public List<object> breeds { get; set; }
            public string id { get; set; }
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        // Deserialize to an Array
        private List<Kitty> data;

        public class Root
        {
            public List<Kitty> MyArray { get; set; }
        }

        private Boolean found;
        private string errormessage;
        private string searchUrl;
        private int catCategory;


        // Asynchronous method to extra data from API
        private async Task GetDataAsync()
        {
            try
            {
                string uri = "https://api.thecatapi.com/v1/images/search";

                // Again, to an Array
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

        // Asynchronous method to display an image on page start
        protected override async Task OnInitializedAsync()
        {
            await GetDataAsync();
        }

        // Asynchronous method to search for cat images based on what number is entered
        // Is concatenated to API url
        private async Task Search()
        {
            try
            {
                searchUrl = string.Format("https://api.thecatapi.com/v1/images/search?category_ids=" + catCategory);


                try
                {
                    // Validation
                    if (catCategory == 3 || catCategory == 6 || catCategory == 8 || catCategory == 9 || catCategory == 10 || catCategory == 11 || catCategory == 12 || catCategory == 13)
                    {
                        Console.WriteLine("Error. Please enter a valid ID.");
                    }
                    else
                    {
                        // To an Array
                        data = await Http.GetJsonAsync<List<Kitty>>(searchUrl);

                        found = true;
                        errormessage = String.Empty;
                    }
                }
                catch (Exception e)
                {

                    found = false;
                    errormessage = e.Message;


                }


            }


            catch (Exception e)
            {

                found = false;
                errormessage = e.Message;


            }
        }

        // Categorical filter asynchronous methods, all essentially the same bar the category ID
        private async Task CatsInHats()
        {
            try
            {
                searchUrl = "https://api.thecatapi.com/v1/images/search?category_ids=1";

                data = await Http.GetJsonAsync<List<Kitty>>(searchUrl);

                found = true;
                errormessage = String.Empty;
            }
            catch (Exception e)
            {

                found = false;
                errormessage = e.Message;


            }
        }

        private async Task CatsInSpace()
        {
            try
            {
                searchUrl = "https://api.thecatapi.com/v1/images/search?category_ids=2";

                data = await Http.GetJsonAsync<List<Kitty>>(searchUrl);

                found = true;
                errormessage = String.Empty;
            }
            catch (Exception e)
            {

                found = false;
                errormessage = e.Message;


            }
        }

        private async Task CatsInSunglasses()
        {
            try
            {
                searchUrl = "https://api.thecatapi.com/v1/images/search?category_ids=4";

                data = await Http.GetJsonAsync<List<Kitty>>(searchUrl);

                found = true;
                errormessage = String.Empty;
            }
            catch (Exception e)
            {

                found = false;
                errormessage = e.Message;


            }
        }

        private async Task CatsInBoxes()
        {
            try
            {
                searchUrl = "https://api.thecatapi.com/v1/images/search?category_ids=5";

                data = await Http.GetJsonAsync<List<Kitty>>(searchUrl);

                found = true;
                errormessage = String.Empty;
            }
            catch (Exception e)
            {

                found = false;
                errormessage = e.Message;


            }
        }

        private async Task CatsInTies()
        {
            try
            {
                searchUrl = "https://api.thecatapi.com/v1/images/search?category_ids=7";

                data = await Http.GetJsonAsync<List<Kitty>>(searchUrl);

                found = true;
                errormessage = String.Empty;
            }
            catch (Exception e)
            {

                found = false;
                errormessage = e.Message;


            }
        }

        private async Task CatsInSinks()
        {
            try
            {
                searchUrl = "https://api.thecatapi.com/v1/images/search?category_ids=14";

                data = await Http.GetJsonAsync<List<Kitty>>(searchUrl);

                found = true;
                errormessage = String.Empty;
            }
            catch (Exception e)
            {

                found = false;
                errormessage = e.Message;


            }
        }

        private async Task CatsInClothes()
        {
            try
            {
                searchUrl = "https://api.thecatapi.com/v1/images/search?category_ids=15";

                data = await Http.GetJsonAsync<List<Kitty>>(searchUrl);

                found = true;
                errormessage = String.Empty;
            }
            catch (Exception e)
            {

                found = false;
                errormessage = e.Message;


            }
        }
    }
}

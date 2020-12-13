using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace X00073019_EAD_CA3.Pages
{
    public partial class Cat : ComponentBase
    {

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

        // private Root data;
        private Boolean found;
        private string errormessage;
        private string categoryName;

        private string SearchTerm { get; set; } = "";




        private string searchUrl;
        private int catCategory;

        private async Task Search()
        {
            try
            {
                searchUrl = string.Format("https://api.thecatapi.com/v1/images/search?category_ids=" + catCategory);


                try
                {
                    if (catCategory < 1 || catCategory > 6)
                    {
                        Console.WriteLine("Error. Category must be between 1 and 6");
                    }
                    else
                    {
                        // Again, to an Array
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












        protected override async Task OnInitializedAsync()
        {
            await GetDataAsync();
        }





    }
}

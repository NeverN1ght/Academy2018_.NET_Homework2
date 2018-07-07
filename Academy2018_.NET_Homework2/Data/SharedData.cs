using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Academy2018_.NET_Homework2.Models;
using Academy2018_.NET_Homework2.Models.Domain;
using Academy2018_.NET_Homework2.Services;

namespace Academy2018_.NET_Homework2.Data
{
    public static class SharedData
    {
        public static List<User> Data { get; set; }

        public static async void Initialize()
        {
            var dataLoad = new DataLoadService(new HttpClient());
            Data = await dataLoad.GetDataHierarchyAsync();
        }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Meetup2016
{
    public class Provider<T> where T : class
    {
        private static List<T> _model;

        public static List<T> CreateModel(string path)
        {
            if (_model == null)
            {
#if __ANDROID__
                Stream stream = Android.App.Application.Context.Assets.Open(path);
                using (StreamReader reader = new StreamReader(stream))
                {
                    string source = reader.ReadToEnd();
                    _model = JsonConvert.DeserializeObject<List<T>>(source);
                }
#else
                using (StreamReader reader = new StreamReader(path))
                {
                     string source = reader.ReadToEnd();
                    _model = JsonConvert.DeserializeObject<List<T>>(source);
                }
#endif
            }
            return _model;
        }
    }
}
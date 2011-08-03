using System.IO;
using System.Net;

namespace SampleApiCallCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string apikey = "Your Api Key";
            string userIpAddress = "127.0.0.1"; // This should be the ip of an end-user to prevent being identified as an abuser.
            string userAgent = "User-Agent:%20The actual user-agent provided by the user";
            string searchTerm = "apple";
            string category = "web"; // accepted values are 'web', 'images', 'video', or 'news'
            string uri = string.Format("http://api.ischyrus.com/RestfulSearchApiService.svc/Search/?apikey={0}&ip={1}&term={2}&cat={3}&agent=User-Agent:{4}", apikey, userIpAddress, searchTerm, category, userAgent);
            WebRequest request = HttpWebRequest.Create(uri);
            using (WebResponse response = request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string webresults = reader.ReadToEnd();
            }
        }
    }
}

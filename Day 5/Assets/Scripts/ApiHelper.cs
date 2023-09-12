using UnityEngine;
using System.Net;
using System.IO;
public static class ApiHelper
{
    public static Joke GetNewJoke()
    {
        HttpWebRequest request = WebRequest.CreateHttp("https://api.chucknorris.io/jokes/random");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse(); 
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<Joke>(json);
        
    }
}

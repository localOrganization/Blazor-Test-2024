using System;
using System.Collections.Generic;

namespace DisplayColors.Data
{
    // *************************************************
    // build C# class from JSON https://json2csharp.com/
    // *************************************************
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class WebColors
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Datum> data { get; set; }
        public Support support { get; set; }
    }


    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public string pantone_value { get; set; }
    }

    public class Support
    {
        public string url { get; set; }
        public string text { get; set; }
    }
}
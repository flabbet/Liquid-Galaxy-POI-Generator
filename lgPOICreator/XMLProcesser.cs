using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace lgPOICreator
{ //t
    public class KMLProcesser
    {
        public static void ProcessFiles(string[] files, string fileName, string planet)
        {
            for (int i = 0; i < files.Length; i++)
            {
                string name = GetValueFromTag(files[i], "Placemark").Item(0).FirstChild.InnerText;
                XmlNodeList geoInfoNodes = GetValueFromTag(files[i], "LookAt", "Camera").Item(0).ChildNodes;
                 string content = string.Format(@"{0}@{1}@flytoview=<LookAt><longitude>{2}</longitude><latitude>{3}</latitude><altitude>{4}</altitude><heading>{5}</heading><tilt>{6}</tilt><roll>{7}</roll><gx:altitudeMode>{8}</gx:altitudeMode></LookAt>",
                planet,
                name,
                geoInfoNodes.Item(0).InnerText,
                geoInfoNodes.Item(1).InnerText,
                geoInfoNodes.Item(2).InnerText,
                geoInfoNodes.Item(3).InnerText,
                geoInfoNodes.Item(4).InnerText,
                geoInfoNodes.Item(5).InnerText,
                geoInfoNodes.Item(6).InnerText);
                Console.WriteLine((i+1) + ". Adding " + name + "...");
                using(TextWriter tsw = new StreamWriter(fileName, true))
                {
                    tsw.WriteLine(content);
                }
            }
        }

        public static XmlNodeList GetValueFromTag(string file,string tag)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);         
            return doc.GetElementsByTagName(tag);
        }

        public static XmlNodeList GetValueFromTag(string file, string tag, string replaceTag)
        {
            string tagToBeUsed = tag;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            if (doc.GetElementsByTagName(tagToBeUsed).Count == 0)
            {
                tagToBeUsed = replaceTag;
            }
            return doc.GetElementsByTagName(tagToBeUsed);
        }
    }
}

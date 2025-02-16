using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetoMonge.Class
{
    public class XmlHandler
    {

        public List<string> ReadXml(string xmlstring)
        {
            XmlTextReader xmlReader = new XmlTextReader(xmlstring);
            List<string> list = new List<string>();
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        list.Add("<" + xmlReader.Name + ">");
                        break;
                    case XmlNodeType.Text:
                        list.Add(xmlReader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        list.Add("");
                        break;
                }
            }
            return list;

        }
    }
}

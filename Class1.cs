using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace turtle.Forms
{
    class Class1
    {
        static void loads(){
        
            String pathXmlFile = @"Config.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathXmlFile);

            

        
        }
    }
}

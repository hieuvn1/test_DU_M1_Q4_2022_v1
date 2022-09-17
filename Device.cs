using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SSH = Renci.SshNet;
namespace PreTest
{
    public class Device
    {
        public string Name { get; set; }
        public string DeviceStatus { get; set; }
        public string logdevice = "";
        SSH.SshClient server;
        SSH.SshCommand command;
        string result;
        public bool flagCheckDevice = true;
        internal void ScanXmlDocument(XmlNodeList xmlList, List<Device> listDevice)
        {
            foreach (XmlNode xmlNode in xmlList)
            {

                if (xmlNode is XmlElement)
                {
                    RecurseXmlDocument(xmlNode, listDevice);
                }
            }
        }
        private void RecurseXmlDocument(XmlNode xmlNode, List<Device> listDevice)
        {
            if (xmlNode is XmlElement)
            {
                if (xmlNode.ChildNodes.Count > 1)
                {
                    if (xmlNode.Attributes.Count > 0)
                    {
                        if (xmlNode.Attributes["name"].Value.Equals("CPU Configuration") && xmlNode.Attributes["order"].Value.Equals("2"))
                        {
                            foreach (XmlNode node in xmlNode)
                            {
                                if (node.Name == "Menu")
                                {
                                    foreach (XmlNode node1 in node)
                                    {
                                        if (node1.Name == "Text")
                                        {
                                            if (node1.InnerText.Contains("PCI-E Port Link Status(Link Did Not Train)"))
                                            {
                                                Device device = new Device();
                                                device.Name = node.Attributes["name"].Value;
                                                device.DeviceStatus = "  IS NOT CONNECTED";
                                                listDevice.Add(device);
                                                flagCheckDevice = false;
                                                break;
                                            }
                                            else
                                            {
                                                Device device = new Device();
                                                device.Name = node.Attributes["name"].Value;
                                                device.DeviceStatus = "  IS CONNECTED";
                                                listDevice.Add(device);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    foreach (XmlNode Node in xmlNode)
                    {
                        if (Node is XmlElement)
                        {
                            if (Node.ChildNodes.Count > 1)
                            {
                                RecurseXmlDocument(Node, listDevice);
                            }
                        }
                    }
                }
            }
        }
    }
}


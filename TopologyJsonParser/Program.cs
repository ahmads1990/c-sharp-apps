using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TopologyJsonParser
{

    public class Program
    {
        private JsonSerializerOptions _options;
        static LinkedList<topology> topologyList;

        public static void Main()
        {
            string filePath = @"C:\Users\magica\Desktop\c-sharp-apps\TopologyJsonParser\testJson.json";
            string json = File.ReadAllText(filePath);
            topologyList = new LinkedList<topology>();

        }
        public topology readJSON(string filePath)
        {
            string json;
            //read into string
            try
            {
                json = File.ReadAllText(@filePath);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            //parse file
            var unkownJson = JsonDocument.Parse(json);
            //create new object
            topology newTopo = new topology();
            //get id
            newTopo.topologyId = unkownJson.RootElement.GetProperty("id").ToString();
            //init components list
            newTopo.components = new LinkedList<component>();
            //get component list jarray
            var componentList = unkownJson.RootElement.GetProperty("components");
            //go throw each compontent
            foreach (var item in componentList.EnumerateArray())
            {
                //go for each component
                component newComponent = new component();
                //get id type with property
                newComponent.id = item.GetProperty("id").GetString();
                newComponent.type = item.GetProperty("type").GetString();
                //for netlist and property
                foreach (var propertyName in item.EnumerateObject())
                {
                    if (propertyName.Value.ValueKind == JsonValueKind.Object)
                    {
                        if (propertyName.Name == "netlist")
                        {
                            newComponent.netList = new Dictionary<string, string>();
                            foreach (var netListElement in propertyName.Value.EnumerateObject())
                            {
                                string key = netListElement.Name;
                                string value = netListElement.Value.ToString();
                                newComponent.netList.Add(key, value);
                            }
                        }
                        else
                        {
                            newComponent.properties = new property();
                            newComponent.properties.defaultP = float.Parse(
                                propertyName.Value.GetProperty("default").ToString());
                            newComponent.properties.max = float.Parse(
                           propertyName.Value.GetProperty("max").ToString());
                            newComponent.properties.min = float.Parse(
                           propertyName.Value.GetProperty("min").ToString());
                        }
                    }
                }
                newTopo.components.AddLast(newComponent);
            }
            //at the end add return finished topo
            return newTopo;
        }
        public bool writeJSON(int topologyID, string fileName)
        {
            //get topology id
            topology topoToBeWrited = null;
            foreach (var item in topologyList)
            {
                if (int.Parse(item.topologyId) == topologyID) { topoToBeWrited = item; }
            }
            if (topoToBeWrited == null) { return false; }
            var options = new JsonSerializerOptions(_options)
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(topoToBeWrited, options);
            File.WriteAllText(fileName, jsonString);
            return true;
        }
        LinkedList<topology> queryTopologies() { return topologyList; }
        bool deleteTopology(int topologyID)
        {
            topology topoToBeDeleted = null;
            foreach (var item in topologyList)
            {
                if (int.Parse(item.topologyId) == topologyID) { topoToBeDeleted = item; }
            }
            if (topoToBeDeleted == null) { return false; }
            topologyList.Remove(topoToBeDeleted);
            return true;
        }
        LinkedList<component> queryDevices(int topologyId)
        {
            LinkedList<component> compList = null;
            foreach (var item in topologyList)
            {
                if (int.Parse(item.topologyId) == topologyId) { compList = item.components; }
            }
            if (compList == null) { return null; }
            return compList;
        }
        Dictionary<string, string> queryDevicesWithNetlistNode(int topologyID, string netlistNodeID)
        {
            LinkedList<component> compList = null;
            Dictionary<string, string> values = null;
            LinkedList<string> devices;
            foreach (var item in topologyList)
            {
                if (int.Parse(item.topologyId) == topologyID) { compList = item.components; }
            }
            if (compList == null) { return null; }
            foreach (var comp in compList)
            {
                if (comp.id.Equals(netlistNodeID))
                {
                    values = comp.netList;
                    break;
                }
            }
            return values;
        }
    }
}

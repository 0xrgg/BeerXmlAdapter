using System.Xml.Serialization;

public class RecordSet
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }
}


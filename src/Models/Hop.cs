using System.Xml.Serialization;

public class Hop
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("ALPHA")]
    public float Alpha { get; set; }

    [XmlElement("AMOUNT")]
    public double Amount { get; set; }

    [XmlElement("USE")]
    public UseType Use { get; set; }

    [XmlElement("TIME")]
    public double Time { get; set; }

    [XmlElement("NOTES")]
    public string? Notes { get; set; }

    [XmlArray("TYPE")]
    [XmlArrayItem("Item")]
    public List<Type> Type { get; set; } = new List<Type>();

    [XmlArray("FORM")]
    [XmlArrayItem("Item")]
    public List<Form> Form { get; set; } = new List<Form>();

    [XmlElement("BETA")]
    public double? Beta { get; set; }

    [XmlElement("HSI")]
    public double? Hsi { get; set; }

    [XmlElement("ORIGIN")]
    public string? Origin { get; set; }

    [XmlElement("SUBSTITUTE")]
    public string? Substitute { get; set; }

    [XmlElement("HUMULENE")]
    public double? Humulene { get; set; }

    [XmlElement("CARYOPHYLLENE")]
    public double? Caryophyllene { get; set; }

    [XmlElement("COHUMULONE")]
    public double? Cohumulone { get; set; }

    [XmlElement("MYRCENE")]
    public double? Myrcene { get; set; }

    // Extensions

    [XmlElement("DISPLAY_AMOUNT")]
    public string DisplayAmount { get; set; }

    [XmlElement("INVENTORY")]
    public string Inventory { get; set; }

    [XmlElement("DISPLAY_TIME")]
    public string DisplayTime { get; set; }
}

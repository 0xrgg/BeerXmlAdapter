using System.Xml.Serialization;

public class Misc
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("TYPE")]
    public string Type { get; set; }

    [XmlElement("USE")]
    public string Use { get; set; }

    [XmlElement("TIME")]
    public double Time { get; set; }

    [XmlElement("AMOUNT")]
    public double Amount { get; set; }

    [XmlElement("AMOUNT_IS_WEIGHT")]
    public bool AmountIsWeight { get; set; }

    [XmlElement("USE_FOR")]
    public string? UseFor { get; set; }

    [XmlElement("NOTES")]
    public string? Notes { get; set; }

    // Extensions

    [XmlElement("DISPLAY_AMOUNT")]
    public string DisplayAmount { get; set; }

    [XmlElement("INVENTORY")]
    public string Inventory { get; set; }

    [XmlElement("DISPLAY_TIME")]
    public string DisplayTime { get; set; }
}

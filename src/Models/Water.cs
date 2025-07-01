using System.Xml.Serialization;

public class Water
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("AMOUNT")]
    public double Amount { get; set; }

    [XmlElement("CALCIUM")]
    public double Calcium { get; set; }

    [XmlElement("BICARBONATE")]
    public double Bicarbonate { get; set; }

    [XmlElement("SULFATE")]
    public double Sulfate { get; set; }

    [XmlElement("CHLORIDE")]
    public double Chloride { get; set; }

    [XmlElement("SODIUM")]
    public double Sodium { get; set; }

    [XmlElement("MAGNESIUM")]
    public double Magnesium { get; set; }

    [XmlElement("PH")]
    public double? Ph { get; set; }

    [XmlElement("NOTES")]
    public string? Notes { get; set; }

    // Extensions

    [XmlElement("DISPLAY_AMOUNT")]
    public string DisplayAmount { get; set; }
}

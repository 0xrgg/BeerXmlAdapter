using System.Xml;
using System.Xml.Serialization;

public class Fermentable
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("TYPE")]
    public string Type { get; set; }

    [XmlElement("AMOUNT")]
    public double Amount { get; set; }

    [XmlElement("YIELD")]
    public double Yield { get; set; }

    [XmlElement("COLOR")]
    public double Color { get; set; }

    [XmlElement("ADD_AFTER_BOIL")]
    public bool? AddAfterBoil { get; set; }

    [XmlElement("ORIGIN")]
    public string? Origin { get; set; }

    [XmlElement("SUPPLIER")]
    public string? Supplier { get; set; }

    [XmlElement("NOTES")]
    public string? Notes { get; set; }

    [XmlElement("COARSE_FINE_DIFF")]
    public double? CoarseFineDiff { get; set; }

    [XmlElement("MOISTURE")]
    public double? Moisture { get; set; }

    [XmlElement("DIASTATIC_POWER")]
    public double? DiastaticPower { get; set; }

    [XmlElement("PROTEIN")]
    public double? Protein { get; set; }

    [XmlElement("MAX_IN_BATCH")]
    public double? MaxInBatch { get; set; }

    [XmlElement("RECOMMEND_MASH")]
    private string _RecommendMash { get; set; }

    [XmlElement("IBU_GAL_PER_LB")]
    public double? IbuGalPerLb { get; set; }

    // Extensions

    [XmlElement("DISPLAY_AMOUNT")]
    public string DisplayAmount { get; set; }

    [XmlElement("POTENTIAL")]
    public string Potential { get; set; }

    [XmlElement("INVENTORY")]
    public string Inventory { get; set; }

    [XmlElement("DISPLAY_COLOR")]
    public string DisplayColor { get; set; }


    public bool RecommendMash { get => _RecommendMash == "TRUE"; }
}

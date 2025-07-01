using System.Xml.Serialization;

public class Mash
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("GRAIN_TEMP")]
    public double GrainTemp { get; set; }

    [XmlArray("MASH_STEPS")]
    [XmlArrayItem("MASH_STEP")]
    public List<MashStep> MashSteps { get; set; } = new List<MashStep>();

    [XmlElement("NOTES")]
    public string? Notes { get; set; }

    [XmlElement("TUN_TEMP")]
    public double? TunTemp { get; set; }

    [XmlElement("SPARGE_TEMP")]
    public double? SpargeTemp { get; set; }

    [XmlElement("PH")]
    public double? Ph { get; set; }

    [XmlElement("TUN_WEIGHT")]
    public double? TunWeight { get; set; }

    [XmlElement("TUN_SPECIFIC_HEAT")]
    public double? TunSpecificHeat { get; set; }

    [XmlElement("EQUIP_ADJUST")]
    public bool? EquipAdjust { get; set; }

    // Extensions

    [XmlElement("DISPLAY_GRAIN_TEMP")]
    public string DisplayGrainTemp { get; set; }

    [XmlElement("DISPLAY_TUN_TEMP")]
    public string DisplayTunTemp { get; set; }

    [XmlElement("DISPLAY_SPARGE_TEMP")]
    public string DisplaySpargeTemp { get; set; }

    [XmlElement("DISPLAY_TUN_WEIGHT")]
    public string DisplayTunWeight { get; set; }
}

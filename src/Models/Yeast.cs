using System.Xml.Serialization;


public class Yeast
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("TYPE")]
    public string Type { get; set; }

    [XmlElement("FORM")]
    public string Form { get; set; }

    [XmlElement("AMOUNT")]
    public double Amount { get; set; }

    [XmlElement("AMOUNT_IS_WEIGHT")]
    public bool AmountIsWeight { get; set; }

    [XmlElement("LABORATORY")]
    public string? Laboratory { get; set; }

    [XmlElement("PRODUCT_ID")]
    public string? ProductId { get; set; }

    [XmlElement("MIN_TEMPERATURE")]
    public double? MinTemperature { get; set; }

    [XmlElement("MAX_TEMPERATURE")]
    public double? MaxTemperature { get; set; }

    [XmlElement("FLOCCULATION")]
    public string? Flocculation { get; set; }

    [XmlElement("ATTENUATION")]
    public double? Attenuation { get; set; }

    [XmlElement("NOTES")]
    public string? Notes { get; set; }

    [XmlElement("BEST_FOR")]
    public string? BestFor { get; set; }

    [XmlElement("TIMES_CULTURED")]
    public int? TimesCultured { get; set; }

    [XmlElement("MAX_REUSE")]
    public int? MaxReuse { get; set; }

    [XmlElement("ADD_TO_SECONDARY")]
    public bool? AddToSecondary { get; set; }

    // Extensions

    [XmlElement("DISPLAY_AMOUNT")]
    public string DisplayAmount { get; set; }

    [XmlElement("DISP_MIN_TEMP")]
    public string DispMinTemp { get; set; }

    [XmlElement("DISP_MAX_TEMP")]
    public string DispMaxTemp { get; set; }

    [XmlElement("INVENTORY")]
    public string Inventory { get; set; }

    [XmlElement("CULTURE_DATE")]
    public string CultureDate { get; set; }
}

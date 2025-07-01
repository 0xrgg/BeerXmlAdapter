using System.Xml.Serialization;

public enum UseType
{
    [XmlEnum("Boil")]
    BOIL,
    [XmlEnum("Dry Hop")]
    DRY_HOP,
    [XmlEnum("Mash")]
    MASH,
    [XmlEnum("First Wort")]
    FIRST_WORT,
    [XmlEnum("Aroma")]
    AROMA
}


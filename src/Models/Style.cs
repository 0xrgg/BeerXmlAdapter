using System.Xml.Serialization;

public class Style
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("CATEGORY")]
    public string Category { get; set; }

    [XmlElement("CATEGORY_NUMBER")]
    public string CategoryNumber { get; set; }

    [XmlElement("STYLE_LETTER")]
    public string StyleLetter { get; set; }

    [XmlElement("STYLE_GUIDE")]
    public string StyleGuide { get; set; }

    [XmlElement("TYPE")]
    public string Type { get; set; }

    [XmlElement("OG_MIN")]
    public double OgMin { get; set; }

    [XmlElement("OG_MAX")]
    public double OgMax { get; set; }

    [XmlElement("FG_MIN")]
    public double FgMin { get; set; }

    [XmlElement("FG_MAX")]
    public double FgMax { get; set; }

    [XmlElement("IBU_MIN")]
    public double IbuMin { get; set; }

    [XmlElement("IBU_MAX")]
    public double IbuMax { get; set; }

    [XmlElement("COLOR_MIN")]
    public double ColorMin { get; set; }

    [XmlElement("COLOR_MAX")]
    public double ColorMax { get; set; }

    [XmlElement("CARB_MIN")]
    public double? CarbMin { get; set; }

    [XmlElement("CARB_MAX")]
    public double? CarbMax { get; set; }

    [XmlElement("ABV_MIN")]
    public double? AbvMin { get; set; }

    [XmlElement("ABV_MAX")]
    public double? AbvMax { get; set; }

    [XmlElement("NOTES")]
    public string? Notes { get; set; }

    [XmlElement("PROFILE")]
    public string? Profile { get; set; }

    [XmlElement("INGREDIENTS")]
    public string? Ingredients { get; set; }

    [XmlElement("EXAMPLES")]
    public string? Examples { get; set; }

    // Extensions

    [XmlElement("DISPLAY_OG_MIN")]
    public string DisplayOgMin { get; set; }

    [XmlElement("DISPLAY_OG_MAX")]
    public string DisplayOgMax { get; set; }

    [XmlElement("DISPLAY_FG_MIN")]
    public string DisplayFgMin { get; set; }

    [XmlElement("DISPLAY_FG_MAX")]
    public string DisplayFgMax { get; set; }

    [XmlElement("DISPLAY_COLOR_MIN")]
    public string DisplayColorMin { get; set; }

    [XmlElement("DISPLAY_COLOR_MAX")]
    public string DisplayColorMax { get; set; }

    [XmlElement("OG_RANGE")]
    public string OgRange { get; set; }

    [XmlElement("FG_RANGE")]
    public string FgRange { get; set; }

    [XmlElement("IBU_RANGE")]
    public string IbuRange { get; set; }

    [XmlElement("CARB_RANGE")]
    public string CarbRange { get; set; }

    [XmlElement("COLOR_RANGE")]
    public string ColorRange { get; set; }

    [XmlElement("ABV_RANGE")]
    public string AbvRange { get; set; }
}

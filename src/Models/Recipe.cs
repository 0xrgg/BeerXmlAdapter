using System.Xml.Serialization;

[Serializable, XmlRoot("RECIPE")]
public class Recipe
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("BREWER")]
    public string Brewer { get; set; }

    [XmlElement("BATCH_SIZE")]
    public double BatchSize { get; set; }

    [XmlElement("BOIL_SIZE")]
    public double BoilSize { get; set; }

    [XmlElement("BOIL_TIME")]
    public double BoilTime { get; set; }

    [XmlElement("EFFICIENCY")]
    public double Efficiency { get; set; }

    [XmlElement("TASTE_NOTES")]
    public string TasteNotes { get; set; }

    [XmlElement("RATING")]
    public int Rating { get; set; }

    [XmlElement("DATE")]
    public string Date { get; set; }

    [XmlElement("OG")]
    public double OG { get; set; }

    [XmlElement("FG")]
    public double FG { get; set; }

    [XmlElement("CARBONATION")]
    public double Carbonation { get; set; }

    [XmlElement("CARBONATION_USED")]
    public string CarbonationUsed { get; set; }

    [XmlElement("AGE")]
    public double Age { get; set; }

    [XmlElement("AGE_TEMP")]
    public double AgeTemp { get; set; }

    [XmlElement("FERMENTATION_STAGES")]
    public int FermentationStages { get; set; }

    [XmlElement("TYPE")]
    public string Type { get; set; }

    [XmlElement("STYLE")]
    public Style Style { get; set; }

    [XmlElement("EQUIPMENT")]
    public Equipment? Equipment { get; set; }

    [XmlElement("MASH")]
    public Mash? Mash { get; set; }

    [XmlArray("HOPS")]
    [XmlArrayItem("HOP")]
    public List<Hop> Hops { get; set; }

    [XmlArray("FERMENTABLES")]
    [XmlArrayItem("FERMENTABLE")]
    public List<Fermentable> Fermentables { get; set; }

    [XmlArray("YEASTS")]
    [XmlArrayItem("YEAST")]
    public List<Yeast> Yeasts { get; set; }

    [XmlArray("MISCS")]
    [XmlArrayItem("MISC")]
    public List<Misc> Miscs { get; set; }

    [XmlArray("WATERS")]
    [XmlArrayItem("WATER")]
    public List<Water> Waters { get; set; }

    // Extensions

    [XmlElement("EST_OG")]
    public string EstOg { get; set; }  // e.g. "1.048 sg"

    [XmlElement("EST_FG")]
    public string EstFg { get; set; }  // e.g. "1.015 sg"

    [XmlElement("EST_COLOR")]
    public string EstColor { get; set; }  // e.g. "20 SRM"

    [XmlElement("IBU")]
    public float? Ibu { get; set; }  // e.g. 35.5

    [XmlElement("IBU_METHOD")]
    public string IbuMethod { get; set; }  // "Rager", "Tinseth", "Garetz"

    [XmlElement("EST_ABV")]
    public float? EstAbv { get; set; }  // e.g. 5.2 (%)

    [XmlElement("ABV")]
    public float? Abv { get; set; }  // e.g. 5.0 (%)

    [XmlElement("ACTUAL_EFFICIENCY")]
    public float? ActualEfficiency { get; set; }  // e.g. 75.0 (%)

    [XmlElement("CALORIES")]
    public string Calories { get; set; }  // e.g. "180 Cal/pint"

    [XmlElement("DISPLAY_BATCH_SIZE")]
    public string DisplayBatchSize { get; set; }  // e.g. "5.0 gal"

    [XmlElement("DISPLAY_BOIL_SIZE")]
    public string DisplayBoilSize { get; set; }  // e.g. "6.3 gal"

    [XmlElement("DISPLAY_OG")]
    public string DisplayOg { get; set; }  // e.g. "6.4 plato"

    [XmlElement("DISPLAY_FG")]
    public string DisplayFg { get; set; }  // e.g. "1.035 sg"

    [XmlElement("DISPLAY_PRIMARY_TEMP")]
    public string DisplayPrimaryTemp { get; set; }  // e.g. "64 F"

    [XmlElement("DISPLAY_SECONDARY_TEMP")]
    public string DisplaySecondaryTemp { get; set; }  // e.g. "56 F"

    [XmlElement("DISPLAY_TERTIARY_TEMP")]
    public string DisplayTertiaryTemp { get; set; }  // e.g. "20 C"

    [XmlElement("DISPLAY_AGE_TEMP")]
    public string DisplayAgeTemp { get; set; }  // e.g. "55 F"

    [XmlElement("DISPLAY_CARB_TEMP")]
    public string DisplayCarbTemp { get; set; }  // e.g. "40 F"
}


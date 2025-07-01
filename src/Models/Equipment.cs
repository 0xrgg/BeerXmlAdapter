using System.Xml.Serialization;

public class Equipment
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("BOIL_SIZE")]
    public double BoilSize { get; set; }

    [XmlElement("BATCH_SIZE")]
    public double BatchSize { get; set; }

    [XmlElement("TUN_VOLUME")]
    public double? TunVolume { get; set; }

    [XmlElement("TUN_WEIGHT")]
    public double? TunWeight { get; set; }

    [XmlElement("TUN_SPECIFIC_HEAT")]
    public double? TunSpecificHeat { get; set; }

    [XmlElement("TOP_UP_WATER")]
    public double? TopUpWater { get; set; }

    [XmlElement("TRUB_CHILLER_LOSS")]
    public double? TrubChillerLoss { get; set; }

    [XmlElement("EVAP_RATE")]
    public double? EvapRate { get; set; }

    [XmlElement("BOIL_TIME")]
    public double? BoilTime { get; set; }

    [XmlElement("CALC_BOIL_VOLUME")]
    public bool? CalcBoilVolume { get; set; }

    [XmlElement("LAUTER_DEADSPACE")]
    public double? LauterDeadspace { get; set; }

    [XmlElement("TOP_UP_KETTLE")]
    public double? TopUpKettle { get; set; }

    [XmlElement("HOP_UTILIZATION")]
    public double? HopUtilization { get; set; }

    [XmlElement("NOTES")]
    public string? Notes { get; set; }


    // Extensions

    [XmlElement("DISPLAY_BOIL_SIZE")]
    public string DisplayBoilSize { get; set; }

    [XmlElement("DISPLAY_BATCH_SIZE")]
    public string DisplayBatchSize { get; set; }

    [XmlElement("DISPLAY_TUN_VOLUME")]
    public string DisplayTunVolume { get; set; }

    [XmlElement("DISPLAY_TUN_WEIGHT")]
    public string DisplayTunWeight { get; set; }

    [XmlElement("DISPLAY_TOP_UP_WATER")]
    public string DisplayTopUpWater { get; set; }

    [XmlElement("DISPLAY_TRUB_CHILLER_LOSS")]
    public string DisplayTrubChillerLoss { get; set; }

    [XmlElement("DISPLAY_LAUTER_DEADSPACE")]
    public string DisplayLauterDeadspace { get; set; }

    [XmlElement("DISPLAY_TOP_UP_KETTLE")]
    public string DisplayTopUpKettle { get; set; }
}

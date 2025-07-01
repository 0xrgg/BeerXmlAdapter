using System.Xml.Serialization;

public class MashStep
{
    [XmlElement("NAME")]
    public string Name { get; set; }

    [XmlElement("VERSION")]
    public int Version { get; set; }

    [XmlElement("TYPE")]
    public string Type { get; set; }

    [XmlElement("INFUSE_AMOUNT")]
    public double? InfuseAmount { get; set; }

    [XmlElement("STEP_TEMP")]
    public double StepTemp { get; set; }

    [XmlElement("STEP_TIME")]
    public double StepTime { get; set; }

    [XmlElement("RAMP_TIME")]
    public int? RampTime { get; set; }

    [XmlElement("END_TEMP")]
    public double? EndTemp { get; set; }

    // Extensions

    [XmlElement("DESCRIPTION")]
    public string Description { get; set; }

    [XmlElement("WATER_GRAIN_RATIO")]
    public string WaterGrainRatio { get; set; }

    [XmlElement("DECOCTION_AMT")]
    public string DecoctionAmt { get; set; }

    [XmlElement("INFUSE_TEMP")]
    public string InfuseTemp { get; set; }

    [XmlElement("DISPLAY_STEP_TEMP")]
    public string DisplayStepTemp { get; set; }

    [XmlElement("DISPLAY_INFUSE_AMT")]
    public string DisplayInfuseAmt { get; set; }
}

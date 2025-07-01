using System.Xml.Serialization;


[Serializable, XmlRoot("RECIPES")]
public class BeerXmlFile
{
    [XmlElement("RECIPE")]
    //[XmlArray("RECIPES")]
    //[XmlArrayItem("RECIPE")]
    public Recipe Recipes { get; set; } // = new List<Recipe>();
}

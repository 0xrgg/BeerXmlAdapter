using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace BeerXml.Adapter;

public static class BeerXmlAdapter
{
    /// <summary>
    /// Pass in a string value to return the parsed recipe object.
    /// </summary>
    /// <param name="xmlRecipe"></param>
    /// <returns></returns>
    /// <exception cref="BeerXmlDeserializationException"></exception>
    public static BeerXmlFile DeserializeXmlRecipe(string xmlRecipe)
    {
        var recipeBytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(xmlRecipe);
        var stream = new MemoryStream(recipeBytes);

        return Deserialize(stream);
    }

    /// <summary>
    /// Takes a file name, loads the contents and deserializes to recipe object.
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static BeerXmlFile DeserializeXmlRecipeFile(string fileName)
    {
        var file = File.OpenRead(fileName);

        return Deserialize(file);
    }

    /// <summary>
    /// Async implementation of DeserializeXmlRecipeFile.
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async static Task<BeerXmlFile> DeserializeXmlRecipeFileAsync(string fileName, CancellationToken cancellationToken)
    {
        using (var file = File.Open(fileName, FileMode.Open))
        {
            var buffer = new byte[file.Length];
            await file.ReadExactlyAsync(buffer, cancellationToken);
            var stream = new MemoryStream(buffer);
            return Deserialize(stream);
        }
    }

    /// <summary>
    /// Core method used to parse the XML to object.
    /// </summary>
    /// <param name="stream"></param>
    /// <returns></returns>
    /// <exception cref="BeerXmlDeserializationException"></exception>
    private static BeerXmlFile Deserialize(Stream stream)
    {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BeerXmlFile));

            BeerXmlFile recipe = (BeerXmlFile)serializer.Deserialize(stream)!;

            return recipe;
        }
        catch (Exception e)
        {
            throw new BeerXmlDeserializationException() { ErrorMessage = $"{e.Message} - {e.InnerException}" };
        }
    }

    /// <summary>
    /// Pass in the recipe object to return JSON string representation.
    /// </summary>
    /// <param name="recipe"></param>
    /// <returns></returns>
    public static string SerializeToJson(BeerXmlFile recipe)
    {
        var serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        return JsonSerializer.Serialize(recipe, serializeOptions);
    }
}

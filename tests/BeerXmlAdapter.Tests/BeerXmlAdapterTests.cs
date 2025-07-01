using FluentAssertions;
using Xunit;

namespace BeerXml.Adapter.Tests
{
    public class BeerXmlAdapterTests
    {
        [Fact]
        public void GIVEN_Deserialization_WHEN_Deserialize_THEN_DoesNotThrow()
        {
            var func = () => BeerXmlAdapter.DeserializeXmlRecipe(GetTestXmlRecipe());

            func.Should().NotThrow();
        }

        [Fact]
        public void GIVEN_Deserialization_WHEN_Called_THEN_Deserialize_And_Parse_To_JSON()
        {
            var recipe = BeerXmlAdapter.DeserializeXmlRecipe(GetTestXmlRecipe());
            var json = BeerXmlAdapter.SerializeToJson(recipe);

            recipe.Should().NotBeNull();
            json.Should().NotBeNull();
        }

        [Fact]
        public void GIVEN_File_Deserialization_WHEN_Called_THEN_Deserialize_And_Parse_To_JSON()
        {
            var recipe = BeerXmlAdapter.DeserializeXmlRecipeFile("TestRecipe.xml");
            var json = BeerXmlAdapter.SerializeToJson(recipe);

            recipe.Should().NotBeNull();
            json.Should().NotBeNull();
        }

        [Fact]
        public async Task GIVEN_Async_File_Deserialization_WHEN_Deserialized_THEN_Parse_To_JSON()
        {
            // Uses a separate file to the other test to prevent locking issues 
            var recipe = await BeerXmlAdapter.DeserializeXmlRecipeFileAsync("TestRecipeAsyncTest.xml", CancellationToken.None);
            var json = BeerXmlAdapter.SerializeToJson(recipe);

            recipe.Should().NotBeNull();
            json.Should().NotBeNull();
        }

        [Fact]
        public void GIVEN_Recipe_With_Extensions_WHEN_Deserialized_THEN_Parse_To_JSON()
        {
            var recipe = BeerXmlAdapter.DeserializeXmlRecipe(GetTestXmlRecipeWithExtensions());
            var json = BeerXmlAdapter.SerializeToJson(recipe);

            recipe.Should().NotBeNull();
            json.Should().NotBeNull();
        }

        public string GetTestXmlRecipeWithExtensions() =>
            @"<?xml version=""1.0"" encoding=""ISO-8859-1""?>
                <RECIPES> 
                  <RECIPE> 
                    <NAME>Dry Stout</NAME> 
                    <VERSION>1</VERSION> 
                    <TYPE>All Grain</TYPE> 
                    <BREWER>Brad Smith</BREWER> 
                    <BATCH_SIZE>18.93</BATCH_SIZE> 
                    <DISPLAY_BATCH_SIZE>5.0 gal</DISPLAY_BATCH_SIZE>
                    <BOIL_SIZE>20.82</BOIL_SIZE> 
                    <DISPLAY_BOIL_SIZE>6.3 gal</DISPLAY_BOIL_SIZE>
                    <BOIL_TIME>60.0</BOIL_TIME> 
                    <EFFICIENCY>72.0</EFFICIENCY> 
                    <TASTE_NOTES>Nice dry Irish stout with a warm body but low starting gravity much like the famous drafts.</TASTE_NOTES> 
                    <RATING>41</RATING> 
                    <DATE>3 Jan 04</DATE> 
                    <OG>1.036</OG> 
                    <DISPLAY_OG>1.036 sg</DISPLAY_OG>
                    <FG>1.012</FG> 
                    <DISPLAY_FG>1.012 sg</DISPLAY_FG>
                    <CARBONATION>2.1</CARBONATION> 
                    <CARBONATION_USED>Kegged</CARBONATION_USED> 
                    <DISPLAY_CARB_TEMP>40 F</DISPLAY_CARB_TEMP>
                    <AGE>24.0</AGE> 
                    <AGE_TEMP>17.0</AGE_TEMP> 
                    <DISPLAY_AGE_TEMP>62.6 F</DISPLAY_AGE_TEMP>
                    <FERMENTATION_STAGES>2</FERMENTATION_STAGES> 

                    <STYLE> 
                      <NAME>Dry Stout</NAME> 
                      <CATEGORY>Stout</CATEGORY> 
                      <CATEGORY_NUMBER>16</CATEGORY_NUMBER> 
                      <STYLE_LETTER>A</STYLE_LETTER> 
                      <STYLE_GUIDE>BJCP</STYLE_GUIDE> 
                      <VERSION>1</VERSION> 
                      <TYPE>Ale</TYPE> 
                      <OG_MIN>1.035</OG_MIN> 
                      <OG_MAX>1.050</OG_MAX> 
                      <DISPLAY_OG_MIN>1.035 sg</DISPLAY_OG_MIN>
                      <DISPLAY_OG_MAX>1.050 sg</DISPLAY_OG_MAX>
                      <FG_MIN>1.007</FG_MIN> 
                      <FG_MAX>1.011</FG_MAX> 
                      <DISPLAY_FG_MIN>1.007 sg</DISPLAY_FG_MIN>
                      <DISPLAY_FG_MAX>1.011 sg</DISPLAY_FG_MAX>
                      <IBU_MIN>30.0</IBU_MIN> 
                      <IBU_MAX>50.0</IBU_MAX> 
                      <COLOR_MIN>35.0</COLOR_MIN> 
                      <COLOR_MAX>200.0</COLOR_MAX> 
                      <ABV_MIN>3.2</ABV_MIN> 
                      <ABV_MAX>5.5</ABV_MAX> 
                      <CARB_MIN>1.6</CARB_MIN> 
                      <CARB_MAX>2.1</CARB_MAX> 
                      <OG_RANGE>1.035–1.050 sg</OG_RANGE>
                      <FG_RANGE>1.007–1.011 sg</FG_RANGE>
                      <IBU_RANGE>30–50 IBU</IBU_RANGE>
                      <COLOR_RANGE>35–200 SRM</COLOR_RANGE>
                      <CARB_RANGE>1.6–2.1 vols</CARB_RANGE>
                      <ABV_RANGE>3.2–5.5%</ABV_RANGE>
                      <NOTES>Famous Irish Stout. Dry, roasted, almost coffee like flavor...</NOTES> 
                    </STYLE> 

                    <HOPS> 
                      <HOP> 
                        <NAME>Goldings, East Kent</NAME> 
                        <VERSION>1</VERSION> 
                        <ALPHA>5.0</ALPHA> 
                        <AMOUNT>0.0638</AMOUNT> 
                        <DISPLAY_AMOUNT>63.8 g</DISPLAY_AMOUNT>
                        <USE>Boil</USE> 
                        <TIME>60.0</TIME> 
                        <DISPLAY_TIME>60 min</DISPLAY_TIME>
                        <NOTES>Great all purpose UK hop for ales, stouts, porters</NOTES> 
                      </HOP> 
                    </HOPS> 

                    <FERMENTABLES> 
                      <FERMENTABLE> 
                        <NAME>Pale Malt (2 row) UK</NAME> 
                        <VERSION>1</VERSION> 
                        <AMOUNT>2.27</AMOUNT> 
                        <DISPLAY_AMOUNT>5.0 lb</DISPLAY_AMOUNT>
                        <POTENTIAL>1.036</POTENTIAL>
                        <TYPE>Grain</TYPE> 
                        <YIELD>78.0</YIELD> 
                        <COLOR>3.0</COLOR> 
                        <DISPLAY_COLOR>3 L</DISPLAY_COLOR>
                        <ORIGIN>United Kingdom</ORIGIN> 
                        <SUPPLIER>Fussybrewer Malting</SUPPLIER> 
                        <NOTES>All purpose base malt for English styles</NOTES> 
                        <COARSE_FINE_DIFF>1.5</COARSE_FINE_DIFF> 
                        <MOISTURE>4.0</MOISTURE> 
                        <DIASTATIC_POWER>45.0</DIASTATIC_POWER> 
                        <PROTEIN>10.2</PROTEIN> 
                        <MAX_IN_BATCH>100.0</MAX_IN_BATCH> 
                      </FERMENTABLE> 

                      <FERMENTABLE> 
                        <NAME>Barley, Flaked</NAME> 
                        <VERSION>1</VERSION> 
                        <AMOUNT>0.91</AMOUNT> 
                        <DISPLAY_AMOUNT>2.0 lb</DISPLAY_AMOUNT>
                        <POTENTIAL>1.034</POTENTIAL>
                        <TYPE>Grain</TYPE> 
                        <YIELD>70.0</YIELD> 
                        <COLOR>2.0</COLOR> 
                        <DISPLAY_COLOR>2 L</DISPLAY_COLOR>
                        <ORIGIN>United Kingdom</ORIGIN> 
                        <SUPPLIER>Fussybrewer Malting</SUPPLIER> 
                        <NOTES>Adds body to porters and stouts, must be mashed</NOTES> 
                        <COARSE_FINE_DIFF>1.5</COARSE_FINE_DIFF> 
                        <MOISTURE>9.0</MOISTURE> 
                        <DIASTATIC_POWER>0.0</DIASTATIC_POWER> 
                        <PROTEIN>13.2</PROTEIN> 
                        <MAX_IN_BATCH>20.0</MAX_IN_BATCH> 
                        <RECOMMEND_MASH>TRUE</RECOMMEND_MASH> 
                      </FERMENTABLE> 

                      <FERMENTABLE> 
                        <NAME>Black Barley</NAME> 
                        <VERSION>1</VERSION> 
                        <AMOUNT>0.45</AMOUNT> 
                        <DISPLAY_AMOUNT>1.0 lb</DISPLAY_AMOUNT>
                        <POTENTIAL>1.028</POTENTIAL>
                        <TYPE>Grain</TYPE> 
                        <YIELD>78.0</YIELD> 
                        <COLOR>500.0</COLOR> 
                        <DISPLAY_COLOR>500 L</DISPLAY_COLOR>
                        <ORIGIN>United Kingdom</ORIGIN> 
                        <SUPPLIER>Fussybrewer Malting</SUPPLIER> 
                        <NOTES>Unmalted roasted barley for stouts, porters</NOTES> 
                        <COARSE_FINE_DIFF>1.5</COARSE_FINE_DIFF> 
                        <MOISTURE>5.0</MOISTURE> 
                        <DIASTATIC_POWER>0.0</DIASTATIC_POWER> 
                        <PROTEIN>13.2</PROTEIN> 
                        <MAX_IN_BATCH>10.0</MAX_IN_BATCH> 
                      </FERMENTABLE> 
                    </FERMENTABLES> 

                    <MISCS> 
                      <MISC> 
                        <NAME>Irish Moss</NAME> 
                        <VERSION>1</VERSION> 
                        <TYPE>Fining</TYPE> 
                        <USE>Boil</USE> 
                        <TIME>15.0</TIME> 
                        <DISPLAY_TIME>15 min</DISPLAY_TIME>
                        <AMOUNT>0.010</AMOUNT> 
                        <DISPLAY_AMOUNT>10 g</DISPLAY_AMOUNT>
                        <NOTES>Used as a clarifying agent during the last few minutes of the boil</NOTES> 
                      </MISC> 
                    </MISCS> 

                    <WATERS> 
                      <WATER> 
                        <NAME>Burton on Trent, UK</NAME> 
                        <VERSION>1</VERSION> 
                        <AMOUNT>20.0</AMOUNT> 
                        <DISPLAY_AMOUNT>5.3 gal</DISPLAY_AMOUNT>
                        <CALCIUM>295.0</CALCIUM> 
                        <MAGNESIUM>45.0</MAGNESIUM> 
                        <SODIUM>55.0</SODIUM> 
                        <SULFATE>725.0</SULFATE> 
                        <CHLORIDE>25.0</CHLORIDE> 
                        <BICARBONATE>300.0</BICARBONATE> 
                        <PH>8.0</PH> 
                        <NOTES>Use for distinctive pale ales strongly hopped...</NOTES> 
                      </WATER> 
                    </WATERS> 

                    <YEASTS> 
                      <YEAST> 
                        <NAME>Irish Ale</NAME> 
                        <TYPE>Ale</TYPE> 
                        <VERSION>1</VERSION> 
                        <FORM>Liquid</FORM> 
                        <AMOUNT>0.250</AMOUNT> 
                        <DISPLAY_AMOUNT>250 ml</DISPLAY_AMOUNT>
                        <LABORATORY>Wyeast Labs</LABORATORY> 
                        <PRODUCT_ID>1084</PRODUCT_ID> 
                        <MIN_TEMPERATURE>16.7</MIN_TEMPERATURE> 
                        <MAX_TEMPERATURE>22.2</MAX_TEMPERATURE> 
                        <DISP_MIN_TEMP>62 F</DISP_MIN_TEMP>
                        <DISP_MAX_TEMP>72 F</DISP_MAX_TEMP>
                        <ATTENUATION>73.0</ATTENUATION> 
                        <NOTES>Dry, fruity flavor characteristic of stouts...</NOTES> 
                        <BEST_FOR>Irish Dry Stouts</BEST_FOR> 
                        <FLOCCULATION>Medium</FLOCCULATION> 
                      </YEAST> 
                    </YEASTS> 

                    <MASH> 
                      <NAME>Single Step Infusion, 68 C</NAME> 
                      <VERSION>1</VERSION> 
                      <GRAIN_TEMP>22.0</GRAIN_TEMP> 
                      <DISPLAY_GRAIN_TEMP>72 F</DISPLAY_GRAIN_TEMP>
                      <MASH_STEPS> 
                        <MASH_STEP> 
                          <NAME>Conversion Step, 68C </NAME> 
                          <VERSION>1</VERSION> 
                          <TYPE>Infusion</TYPE> 
                          <STEP_TEMP>68.0</STEP_TEMP> 
                          <DISPLAY_STEP_TEMP>154.4 F</DISPLAY_STEP_TEMP>
                          <STEP_TIME>60.0</STEP_TIME> 
                          <DISPLAY_STEP_TIME>60 min</DISPLAY_STEP_TIME>
                          <INFUSE_AMOUNT>10.0</INFUSE_AMOUNT> 
                          <DISPLAY_INFUSE_AMT>2.6 gal</DISPLAY_INFUSE_AMT>
                        </MASH_STEP> 
                      </MASH_STEPS> 
                    </MASH> 

                  </RECIPE> 
                </RECIPES>";

        public string GetTestXmlRecipe() => 
            @"<?xml version=""1.0"" encoding=""ISO-8859-1""?>
                <RECIPES> 
                  <RECIPE> 
                    <NAME>Dry Stout</NAME> 
                    <VERSION>1</VERSION> 
                    <TYPE>All Grain</TYPE> 
                    <BREWER>Brad Smith</BREWER> 
                    <BATCH_SIZE>18.93</BATCH_SIZE> 
                    <BOIL_SIZE>20.82</BOIL_SIZE> 
                    <BOIL_TIME>60.0</BOIL_TIME> 
                    <EFFICIENCY>72.0</EFFICIENCY> 
                    <TASTE_NOTES>Nice dry Irish stout with a warm body but low starting gravity much like the famous drafts.</TASTE_NOTES> 
                    <RATING>41</RATING> 
                    <DATE>3 Jan 04</DATE> 
                    <OG>1.036</OG> 
                    <FG>1.012</FG> 
                    <CARBONATION>2.1</CARBONATION> 
                    <CARBONATION_USED>Kegged</CARBONATION_USED> 
                    <AGE>24.0</AGE> 
                    <AGE_TEMP>17.0</AGE_TEMP> 
                    <FERMENTATION_STAGES>2</FERMENTATION_STAGES> 
                    <STYLE> 
                      <NAME>Dry Stout</NAME> 
                      <CATEGORY>Stout</CATEGORY> 
                      <CATEGORY_NUMBER>16</CATEGORY_NUMBER> 
                      <STYLE_LETTER>A</STYLE_LETTER> 
                      <STYLE_GUIDE>BJCP</STYLE_GUIDE> 
                      <VERSION>1</VERSION> 
                      <TYPE>Ale</TYPE> 
                      <OG_MIN>1.035</OG_MIN> 
                      <OG_MAX>1.050</OG_MAX> 
                      <FG_MIN>1.007</FG_MIN> 
                      <FG_MAX>1.011</FG_MAX> 
                      <IBU_MIN>30.0</IBU_MIN> 
                      <IBU_MAX>50.0</IBU_MAX> 
                      <COLOR_MIN>35.0</COLOR_MIN> 
                      <COLOR_MAX>200.0</COLOR_MAX> 
                      <ABV_MIN>3.2</ABV_MIN> 
                      <ABV_MAX>5.5</ABV_MAX> 
                      <CARB_MIN>1.6</CARB_MIN> 
                      <CARB_MAX>2.1</CARB_MAX> 
                      <NOTES>Famous Irish Stout.  Dry, roasted, almost coffee like flavor.  Often soured with pasteurized sour beer.  Full body perception due to flaked barley, though starting gravity may be low.  Dry roasted flavor.</NOTES> 
                    </STYLE> 
                    <HOPS> 
                      <HOP> 
                        <NAME>Goldings, East Kent</NAME> 
                        <VERSION>1</VERSION> 
                        <ALPHA>5.0</ALPHA> 
                        <AMOUNT>0.0638</AMOUNT> 
                        <USE>Boil</USE> 
                        <TIME>60.0</TIME> 
                        <NOTES>Great all purpose UK hop for ales, stouts, porters</NOTES> 
                      </HOP> 
                    </HOPS> 
                    <FERMENTABLES> 
                      <FERMENTABLE> 
                        <NAME>Pale Malt (2 row) UK</NAME> 
                        <VERSION>1</VERSION> 
                        <AMOUNT>2.27</AMOUNT> 
                        <TYPE>Grain</TYPE> 
                        <YIELD>78.0</YIELD> 
                        <COLOR>3.0</COLOR> 
                        <ORIGIN>United Kingdom</ORIGIN> 
                        <SUPPLIER>Fussybrewer Malting</SUPPLIER> 
                        <NOTES>All purpose base malt for English styles</NOTES> 
                        <COARSE_FINE_DIFF>1.5</COARSE_FINE_DIFF> 
                        <MOISTURE>4.0</MOISTURE> 
                        <DIASTATIC_POWER>45.0</DIASTATIC_POWER> 
                        <PROTEIN>10.2</PROTEIN> 
                        <MAX_IN_BATCH>100.0</MAX_IN_BATCH> 
                      </FERMENTABLE> 
                      <FERMENTABLE> 
                        <NAME>Barley, Flaked</NAME> 
                        <VERSION>1</VERSION> 
                        <AMOUNT>0.91</AMOUNT> 
                        <TYPE>Grain</TYPE> 
                        <YIELD>70.0</YIELD> 
                        <COLOR>2.0</COLOR> 
                        <ORIGIN>United Kingdom</ORIGIN> 
                        <SUPPLIER>Fussybrewer Malting</SUPPLIER> 
                        <NOTES>Adds body to porters and stouts, must be mashed</NOTES> 
                        <COARSE_FINE_DIFF>1.5</COARSE_FINE_DIFF> 
                        <MOISTURE>9.0</MOISTURE> 
                        <DIASTATIC_POWER>0.0</DIASTATIC_POWER> 
                        <PROTEIN>13.2</PROTEIN> 
                        <MAX_IN_BATCH>20.0</MAX_IN_BATCH> 
                        <RECOMMEND_MASH>TRUE</RECOMMEND_MASH> 
                      </FERMENTABLE> 
                      <FERMENTABLE> 
                        <NAME>Black Barley</NAME> 
                        <VERSION>1</VERSION> 
                        <AMOUNT>0.45</AMOUNT> 
                        <TYPE>Grain</TYPE> 
                        <YIELD>78.0</YIELD> 
                        <COLOR>500.0</COLOR> 
                        <ORIGIN>United Kingdom</ORIGIN> 
                        <SUPPLIER>Fussybrewer Malting</SUPPLIER> 
                        <NOTES>Unmalted roasted barley for stouts, porters</NOTES> 
                        <COARSE_FINE_DIFF>1.5</COARSE_FINE_DIFF> 
                        <MOISTURE>5.0</MOISTURE> 
                        <DIASTATIC_POWER>0.0</DIASTATIC_POWER> 
                        <PROTEIN>13.2</PROTEIN> 
                        <MAX_IN_BATCH>10.0</MAX_IN_BATCH> 
                      </FERMENTABLE> 
                    </FERMENTABLES> 
                    <MISCS> 
                      <MISC> 
                        <NAME>Irish Moss</NAME> 
                        <VERSION>1</VERSION> 
                        <TYPE>Fining</TYPE> 
                        <USE>Boil</USE> 
                        <TIME>15.0</TIME> 
                        <AMOUNT>0.010</AMOUNT> 
                        <NOTES>Used as a clarifying agent during the last few minutes of the boil</NOTES> 
                      </MISC> 
                    </MISCS> 
                    <WATERS> 
                      <WATER> 
                        <NAME>Burton on Trent, UK</NAME> 
                        <VERSION>1</VERSION> 
                        <AMOUNT>20.0</AMOUNT> 
                        <CALCIUM>295.0</CALCIUM> 
                        <MAGNESIUM>45.0</MAGNESIUM> 
                        <SODIUM>55.0</SODIUM> 
                        <SULFATE>725.0</SULFATE> 
                        <CHLORIDE>25.0</CHLORIDE> 
                        <BICARBONATE>300.0</BICARBONATE> 
                        <PH>8.0</PH> 
                        <NOTES> Use for distinctive pale ales strongly hopped.  Very hard water accentuates the hops flavor. Example: Bass Ale</NOTES> 
                      </WATER> 
                    </WATERS> 
                    <YEASTS> 
                      <YEAST> 
                        <NAME>Irish Ale</NAME> 
                        <TYPE>Ale</TYPE> 
                        <VERSION>1</VERSION> 
                        <FORM>Liquid</FORM> 
                        <AMOUNT>0.250</AMOUNT> 
                        <LABORATORY>Wyeast Labs</LABORATORY> 
                        <PRODUCT_ID>1084</PRODUCT_ID> 
                        <MIN_TEMPERATURE>16.7</MIN_TEMPERATURE> 
                        <MAX_TEMPERATURE>22.2</MAX_TEMPERATURE> 
                        <ATTENUATION>73.0</ATTENUATION> 
                        <NOTES>Dry, fruity flavor characteristic of stouts.  Full bodied, dry, clean flavor.</NOTES> 
                        <BEST_FOR>Irish Dry Stouts</BEST_FOR> 
                        <FLOCCULATION>Medium</FLOCCULATION> 
                      </YEAST> 
                    </YEASTS> 
                    <MASH> 
                      <NAME>Single Step Infusion, 68 C</NAME> 
                      <VERSION>1</VERSION> 
                      <GRAIN_TEMP>22.0</GRAIN_TEMP> 
                      <MASH_STEPS> 
                        <MASH_STEP> 
                          <NAME>Conversion Step, 68C </NAME> 
                          <VERSION>1</VERSION> 
                          <TYPE>Infusion</TYPE> 
                          <STEP_TEMP>68.0</STEP_TEMP> 
                          <STEP_TIME>60.0</STEP_TIME> 
                          <INFUSE_AMOUNT>10.0</INFUSE_AMOUNT> 
                        </MASH_STEP> 
                      </MASH_STEPS> 
                    </MASH> 
                  </RECIPE> 
                </RECIPES>";
    }
}

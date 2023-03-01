using System.Text;
using BrewCode.Math;

namespace BrewCode.Hops;

public enum HopPurpose
{
    Bittering,
    Aroma,
    DualPurpose
}
public record Hop
{
    public string VarietyName { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public string[] Keywords { get; set; } = new string[0];
    public string[] Substitutes { get; set; } = new string[0];
    public string[] StyleGuide { get; set; } = new string[0];
    public HopPurpose Purpose { get; set; } = HopPurpose.DualPurpose;
    public string OriginCountry { get; set; } = String.Empty;
    public NumberRange<float> AlphaAcid { get; set; }
    public NumberRange<float> BetaAcid { get; set; }
    public NumberRange<float> CoHumuloneComposition { get; set; }
    public NumberRange<float> MyreceneOil { get; set; }
    public NumberRange<float> HumuleneOil { get; set; }
    public NumberRange<float> CaryophylleneOil { get; set; }
    public NumberRange<float> FarneseneOil { get; set; }
    public string OilComposition { get; set; } = String.Empty;


    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(VarietyName + $" [{OriginCountry}]");
        builder.AppendLine("=====================================");
        builder.AppendLine($"Purpose: {Purpose}");
        builder.AppendLine(Description);
        builder.AppendLine();
        builder.AppendLine($"Keywords: {Keywords}");
        builder.AppendLine($"Possible Substitutions: {Substitutes}");
        builder.AppendLine(" === Acid Info ===");
        builder.AppendLine($"Alpha Acid: {AlphaAcid}%");
        builder.AppendLine($"Beta Acid: {BetaAcid}%");
        builder.AppendLine($"Co-Humulone Composition: {CoHumuloneComposition}%");
        builder.AppendLine(" === Oil Info ===");
        builder.AppendLine($"Total Oil Composition: {OilComposition}");
        builder.AppendLine($"Myrcene Oil: {MyreceneOil}%");
        builder.AppendLine($"Humulene Oil: {HumuleneOil}%");
        builder.AppendLine($"Caryophyllene Oil: {CaryophylleneOil}%");
        builder.AppendLine($"Farnesene Oil: {FarneseneOil}%")

        return builder.ToString();
    }
}
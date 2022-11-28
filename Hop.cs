using System.Text;

namespace BrewCode;

public enum HopPurpose
{
    Bittering,
    Aroma,
    DualPurpose
}
public record Hop
{
    public string VarietyName { get; set; } = String.Empty;
    public string[] Keywords { get; set; } = new string[0];
    public string[] Substitutes { get; set; } = new string[0];
    public string[] StyleGuide { get; set; } = new string[0];
    public HopPurpose Purpose { get; set; } = HopPurpose.DualPurpose;
    public float AlphaAcidLow { get; set; }
    public float AlphaAcidHigh { get; set; }
    public string OriginCountry { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public float MyreceneAcidLow { get; set; }
    public float MyreceneAcidHigh { get; set; }
    public float HumuleneAcidLow { get; set; }
    public float HumuleneAcidHigh { get; set; }
    public float CaryophylleneAcidLow { get; set; }
    public float CaryophylleneAcidHigh { get; set; }
    public float FarneseneAcidHigh { get; set; }
    public float FarneseneAcidLow { get; set; }
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

        //TODO add acid/oil infos

        return builder.ToString();
    }
}
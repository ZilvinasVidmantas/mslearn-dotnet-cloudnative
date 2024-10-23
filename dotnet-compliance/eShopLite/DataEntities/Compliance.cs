using Microsoft.Extensions.Compliance.Classification;
using Microsoft.Extensions.Compliance.Redaction;

public static class DataClassifications
{
    // End user identifieable information
    public static DataClassification EUIIDataClassification { get; } = new DataClassification("EUIIDataTaxonomy", "EUIIData");
    // End user pseudonymous information EUPI
    public static DataClassification EUPDataClassification { get; } = new DataClassification("EUPDataTaxonomy", "EUPData");
}

public class EUIIDataAttribute: DataClassificationAttribute
{
    public EUIIDataAttribute(): base(DataClassifications.EUIIDataClassification) {}
}

public class EUPDataAttribute: DataClassificationAttribute
{
    public EUPDataAttribute(): base(DataClassifications.EUPDataClassification) {}
}


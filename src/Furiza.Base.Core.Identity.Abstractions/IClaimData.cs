namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IClaimData
    {
        string Type { get; set; }
        string Value { get; set; }
    }
}
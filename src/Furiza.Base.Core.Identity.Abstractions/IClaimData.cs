using System;

namespace Furiza.Base.Core.Identity.Abstractions
{
    public interface IClaimData
    {
        string Type { get; set; }
        string Value { get; set; }
        DateTime? CreationDate { get; set; }
        string CreationUser { get; set; }
    }
}
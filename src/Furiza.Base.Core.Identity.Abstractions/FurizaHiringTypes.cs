namespace Furiza.Base.Core.Identity.Abstractions
{
    public struct FurizaHiringTypes
    {
        /// <summary>
        /// Establishes the user as an in-house employee.
        /// </summary>
        public const string InHouse = "in_house_employee";

        /// <summary>
        /// Establishes the user as an outsourced employee, which implies in a more restricted access to the resources of the system.
        /// </summary>
        public const string Outsourced = "outsourced_employee";
    }
}
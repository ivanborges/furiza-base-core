namespace Furiza.Base.Core.Identity.Abstractions
{
    public struct FurizaUserBonds
    {
        /// <summary>
        /// Establishes the user as an own employee.
        /// </summary>
        public const string Own = "own_employee";

        /// <summary>
        /// Establishes the user as an outsourced employee, which implies in a more restricted access to the resources of the system.
        /// </summary>
        public const string Outsourced = "outsourced_employee";
    }
}
namespace Furiza.Base.Core.Identity.Abstractions
{
    public struct FurizaClaimNames
    {
        /// <summary>
        /// Company to which the user is linked.
        /// </summary>
        public const string Company = "company";

        /// <summary>
        /// Department to which the user is linked.
        /// </summary>
        public const string Department = "department";

        /// <summary>
        /// When the user has been created.
        /// </summary>
        public const string CreationDate = "creation_date";

        /// <summary>
        /// Who has created the user.
        /// </summary>
        public const string CreationUser = "creation_user";

        /// <summary>
        /// Identifies the user as a system user.
        /// </summary>
        public const string SystemUser = "system_user";
    }
}
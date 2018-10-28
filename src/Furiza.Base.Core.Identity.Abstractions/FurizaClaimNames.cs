namespace Furiza.Base.Core.Identity.Abstractions
{
    public struct FurizaClaimNames
    {
        /// <summary>
        /// Company to which the user is linked.
        /// </summary>
        public const string Company = "company";

        /// <summary>
        /// Additional company of the group to which the user is linked.
        /// </summary>
        public const string SideCompany = "side_company";

        /// <summary>
        /// Department to which the user is linked.
        /// </summary>
        public const string Department = "department";

        /// <summary>
        /// Additional department to which the user is linked.
        /// </summary>
        public const string SideDepartment = "side_department";

        /// <summary>
        /// Type of hiring to which the employee is linked to company.
        /// </summary>
        public const string HiringType = "hiring_type";

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
namespace Furiza.Base.Core.Identity.Abstractions
{
    public struct FurizaMasterRoles
    {
        /// <summary>
        /// Master of master roles. Allow global access to any client regardless of the resource.
        /// </summary>
        public const string Superuser = "superuser";

        /// <summary>
        /// Can do everything in a client.
        /// </summary>
        public const string Administrator = "administrator";

        /// <summary>
        /// Can do approvals in a workflow in a client.
        /// </summary>
        public const string Approver = "approver";

        /// <summary>
        /// Can manage resources in a client.
        /// </summary>
        public const string Editor = "editor";

        /// <summary>
        /// Can only view resources in a client.
        /// </summary>
        public const string Viewer = "viewer";

        /// <summary>
        /// Can review edited resources.
        /// </summary>
        public const string Reviewer = "Reviewer";
    }
}
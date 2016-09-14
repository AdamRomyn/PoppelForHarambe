namespace AIKE.BusinessLayer
{
    public class Role
    {
        public enum RoleType
        {
            Admin,Customer,NoRole
        }

        public RoleType RoleValue { get; set; }
    }
}
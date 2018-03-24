using SQLite.Net.Attributes;

namespace MrelsApp.Models
{
    public class UserModel
    {
        [PrimaryKey]
        public int UserId { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string ImagePath { get; set; }

        public int? UserTypeId { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(ImagePath))
                {
                    return "noimage";
                }

                return string.Format("http://landsapi1.azurewebsites.net/{0}", ImagePath.Substring(1));
            }
        }

        public string FullName => string.Format("{0} {1}", this.FirstName, this.LastName);

        public override int GetHashCode()
        {
            return this.UserId;
        }
    }
}

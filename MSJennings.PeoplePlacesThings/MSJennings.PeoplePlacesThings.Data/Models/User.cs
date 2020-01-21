namespace MSJennings.PeoplePlacesThings.Data.Models
{
    public class User
    {
        #region Public Properties

        public string AuthToken { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public int Id { get; set; }
        public byte[] PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        #endregion Public Properties
    }
}
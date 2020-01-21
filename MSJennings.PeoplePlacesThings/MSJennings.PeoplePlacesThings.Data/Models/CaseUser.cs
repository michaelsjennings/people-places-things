namespace MSJennings.PeoplePlacesThings.Data.Models
{
    public class CaseUser
    {
        #region Public Properties

        public virtual Case Case { get; set; }
        public int CaseId { get; set; }
        public int Id { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }

        #endregion Public Properties
    }
}
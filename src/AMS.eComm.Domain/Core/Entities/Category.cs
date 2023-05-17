namespace AMS.eComm.Domain.Core.Entities
{
    public class Category
    {
        #region CONSTRUCTORS
        /// <summary>
        ///CONSTRUCTORS
        /// <Author>Freitas, Lucas</Author>
        /// </summary>

        public Category(Guid id, string description) 
        {
            Id = id;
            Description = description;
        }
        
        #endregion
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
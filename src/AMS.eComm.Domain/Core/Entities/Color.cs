namespace AMS.eComm.Domain.Core.Entities
{
    public class Color
    {
        #region CONSTRUCTORS
        /// <summary>
        ///CONSTRUCTORS
        /// <Author>Freitas, Lucas</Author>
        /// </summary>

        public Color(Guid id, string description) 
        {
            Id = id;
            Description = description;
        }

        #endregion
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
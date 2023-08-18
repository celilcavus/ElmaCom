namespace ElmaCom.Entity.Entites
{
    public class BaseCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public bool IsActive { get; set; }

        public BaseCategory()
        {
            IsActive = false;
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
        }
    }

}

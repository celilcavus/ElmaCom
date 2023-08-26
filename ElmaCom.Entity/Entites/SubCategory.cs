namespace ElmaCom.Entity.Entites
{
    public class SubCategory
    {
        public int Id { get; set; }
        public int BaseCategoryId { get; set; }
        public string SubCategoryName { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public bool IsActive { get; set; }

        public BaseCategory BaseCategory { get; set; }

        public SubCategory()
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            IsActive = false;
        }
    }
}

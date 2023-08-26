using ElmaCom.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaCom.BusinessLayer.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private IBaseCategoryRepository _baseCategory;
        private ISubCategoryRepository _subCategory;

        public RepositoryManager(IBaseCategoryRepository baseCategory, ISubCategoryRepository subCategory)
        {
            _baseCategory = baseCategory;
            _subCategory = subCategory;
        }

        public ISubCategoryRepository SubCategoryRepository => _subCategory;

        public IBaseCategoryRepository BaseCategory()
        {
            return _baseCategory;
        }
    }
}

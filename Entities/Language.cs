using Infrastructures.EntityAbstraction;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Entities
{
    public class Language : EntityBaseWithId
    {
        public string Name { get; set; }
        public string About { get; set; }

        public string SmallDescription { get; set; }
        public byte[] Logo { get; set; }

        public bool IsDeleted { get; set; }


        public Language()
        {
            SpecificCategories = new HashSet<SpecificCategory>();
        }

        #region Connections

        #region SpecificCategory

        /// <summary>
        /// Connection of category with language
        /// </summary>
        public ICollection<SpecificCategory> SpecificCategories { get; set; }

        #endregion SpecificCategory


        #endregion Connections
    }
}

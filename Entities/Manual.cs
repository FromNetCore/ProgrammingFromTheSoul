using Infrastructures.EntityAbstraction;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Entities
{
    public class Manual : EntityBaseWithId
    {
        public string Title { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public Manual()
        {
            Chapters = new HashSet<Chapter>();

        }

        #region Connections

        #region SpecificCategory

        public Guid SpecificCategoryId { get; set; }
        public SpecificCategory SpecificCategory { get; set; }

        #endregion SpecificCategory

        #region Chapter

        public ICollection<Chapter> Chapters { get; set; }
        #endregion Chapter

        #endregion Connections
    }
}

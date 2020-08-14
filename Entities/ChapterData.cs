using Infrastructures.EntityAbstraction;
using System;
using System.Collections.Generic;

namespace Entities
{
    public class ChapterData : EntityBaseWithId
    {
        public string Information { get; set; }
        public string CodeExample { get; set; }

        public ChapterData()
        {
            DbFiles = new HashSet<DbFile>();
        }

        #region Connections

        #region Chapter

        public Guid ChapterId { get; set; }
        public Chapter Chapter { get; set; }

        #endregion Chapter

        #region Files

        public ICollection<DbFile> DbFiles { get; set; }

        #endregion Files

        #endregion Connections
    }
}

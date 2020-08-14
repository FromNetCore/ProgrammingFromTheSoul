using Infrastructures.EntityAbstraction;
using System;

namespace Entities
{
    public class DbFile : EntityBaseWithId
    {
        public string Path { get; set; }
        public bool IsDeleted { get; set; }

        #region Connections

        public ChapterData ChapterData { get; set; }
        public Guid ChapterDataId { get; set; }

        #endregion Connections

    }
}

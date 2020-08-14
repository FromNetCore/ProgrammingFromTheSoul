using Infrastructures.EntityAbstraction;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Entities
{
    public class Chapter : EntityBaseWithId
    {
        public int IdentityNumber { get; set; }
        public int PageNumber { get; set; }
        public string Title { get; set; }
        public DateTime LastUpdate { get; set; }

        public Chapter()
        {
            ChapterDatas = new HashSet<ChapterData>();
        }

        #region Connections

        #region Manual

        public Guid ManualId { get; set; }
        public Manual Manual { get; set; }

        #endregion Manual

        #region ChapterData

        public ICollection<ChapterData> ChapterDatas { get; set; }

        #endregion ChapterData

        #endregion Connections
    }
}

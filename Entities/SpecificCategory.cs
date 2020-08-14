using Infrastructures.EntityAbstraction;
using System;
using System.Collections.Generic;

namespace Entities
{
    public class SpecificCategory : EntityBaseWithId
    {
        public string Title { get; set; }
        public int Stars { get; set; }


        public SpecificCategory()
        {
            Manuals = new HashSet<Manual>();
        }

        #region Connections

        #region Language

        /// <summary>
        /// Connection id of category with language
        /// </summary>
        public Guid LanguageId { get; set; }

        /// <summary>
        /// Connection of category with language
        /// </summary>
        public Language Language { get; set; }

        #endregion Language

        #region Manual

        public ICollection<Manual> Manuals { get; set; }
        #endregion Manual

        #endregion Connections

    }
}

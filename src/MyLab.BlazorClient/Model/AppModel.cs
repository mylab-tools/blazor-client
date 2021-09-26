using System.Collections.Generic;

namespace MyLab.BlazorClient.Model
{
    /// <summary>
    /// Contains Application level properties
    /// </summary>
    public class AppModel
    {
        /// <summary>
        /// Application title
        /// </summary>
        public string Title { get; set; }

        public AppSection[] Sections { get; set; }
    }

    /// <summary>
    /// Contains application section properties
    /// </summary>
    public class AppSection
    {
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Style icon identifier
        /// </summary>
        public string IconId { get; set; }

        /// <summary>
        /// relative reference
        /// </summary>
        public string Ref { get; set; }
    }
}

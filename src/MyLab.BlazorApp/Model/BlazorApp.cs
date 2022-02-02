namespace MyLab.BlazorApp.Model
{
    /// <summary>
    /// Contains the App parameters
    /// </summary>
    public class BlazorApp
    {
        /// <summary>
        /// Main application title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Logo image url
        /// </summary>
        public string LogoUrl{ get; set; }


        /// <summary>
        /// Contains app root sections
        /// </summary>
        public AppSectionGroup[] SectionsGroups { get; set; }
    }
}

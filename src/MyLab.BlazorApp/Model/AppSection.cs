namespace MyLab.BlazorApp.Model
{
    /// <summary>
    /// Contains application section parameters
    /// </summary>
    public class AppSection
    {
        /// <summary>
        /// Defines section title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// FontAwesome class name
        /// </summary>
        public string FaClass { get; set; }

        /// <summary>
        /// Section URL
        /// </summary>
        public string Url { get; set; }
    }
}

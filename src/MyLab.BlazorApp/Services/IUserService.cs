namespace MyLab.BlazorApp.Services
{
    /// <summary>
    /// Provides information about current user
    /// </summary>
    public interface IUserService
    {
        UserInfo ProvideCurrentUser();
    }

    /// <summary>
    /// Contains user properties
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// Full name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Subtitles
        /// </summary>
        public string[] Subtitles { get; set; }

        /// <summary>
        /// Gauges
        /// </summary>
        public UserGauge[] Gauges { get; set; }

        /// <summary>
        /// User pic url
        /// </summary>
        public string UserPicUrl { get; set; }
    }

    /// <summary>
    /// User gauge
    /// </summary>
    public class UserGauge
    {
        /// <summary>
        /// Display title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Font Awesome class
        /// </summary>
        public string FaClass { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Addition link URL
        /// </summary>
        public string AdditionLinkUrl { get; set; }
        /// <summary>
        /// Addition link title
        /// </summary>
        public string AdditionLinkTitle { get; set; }
    }
}

using System.Runtime.CompilerServices;

namespace MyLab.BlazorApp.Model;

/// <summary>
/// Main layout CSS classes
/// </summary>
public class AppCssMap
{
    private readonly IDictionary<string, string> _overrideClasses;

    public AppCssMap CssMap { get; set; } = new AppCssMap();

    /// <summary>
    /// Provides css class name
    /// </summary>
    public string this [string cssClass] =>
        _overrideClasses.TryGetValue(cssClass, out var overrideClass)
            ? overrideClass
            : cssClass;

    /// <summary>
    /// Initializes a new instance of <see cref="AppCssMap"/>
    /// </summary>
    public AppCssMap()
    {
        _overrideClasses = new Dictionary<string, string>();
    }

    /// <summary>
    /// Initializes a new instance of <see cref="AppCssMap"/>
    /// </summary>
    public AppCssMap(IDictionary<string, string> overrideClasses)
    {
        _overrideClasses = new Dictionary<string, string>(overrideClasses);
    }
}
namespace MyLab.BlazorApp.Model;

/// <summary>
/// Contains section group details
/// </summary>
public class AppSectionGroup
{
    /// <summary>
    /// Group title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Group sections
    /// </summary>
    public AppSection[] Sections { get; set; }
}
/*
 * File:         GlobalConstants.cs
 * Date created: 2/15/25
 * Purpose:      Defines constant values that get referenced throughout the application
 */

namespace BookTracker;

public static class GlobalConstants
{
    public static readonly string AppName = "BookTracker";
    public static readonly double AppVersion = 1.0;
    public static string DeveloperContact { get; set; }  = "vincent@vtallen.com";
}
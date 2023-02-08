namespace CA.Infrastructure.DataContext;

public class DbSettings
{
    public const string SectionName = "ConnectionStrings";

    public string SqlServer { get; set; } = null!;
}
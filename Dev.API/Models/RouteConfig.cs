public class RouteConfig
{
    public List<RouteItem> Routes { get; set; }
}

public class RouteItem
{
    public string Path { get; set; }

    public string Method { get; set; }
}

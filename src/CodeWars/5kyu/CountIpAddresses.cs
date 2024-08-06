namespace CodeWars._5kyu;

public static class CountIpAddresses
{
    public static long IpsBetween(string start, string end)
    {
        return IpToLong(end) - IpToLong(start);
    }

    private static long IpToLong(string ip)
    {
        return ip.Split('.')
            .Select(octet => Convert.ToInt32(octet))
            .Aggregate(0L, (result, octet) => (result << 8) + octet);
    }
}
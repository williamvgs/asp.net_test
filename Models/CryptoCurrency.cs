public class Quote
{
    public double price { get; set; }
    public long volume_24h { get; set; }
    public double volume_change_24h { get; set; }
    public double percent_change_1h { get; set; }
    public double percent_change_24h { get; set; }
    public double percent_change_7d { get; set; }
    public double market_cap { get; set; }
    public int market_cap_dominance { get; set; }
    public double fully_diluted_market_cap { get; set; }
    public DateTime last_updated { get; set; }
}

public class Data
{
    public int id { get; set; }
    public string name { get; set; }
    public string symbol { get; set; }
    public string slug { get; set; }
    public int cmc_rank { get; set; }
    public int num_market_pairs { get; set; }
    public long circulating_supply { get; set; }
    public long total_supply { get; set; }
    public long max_supply { get; set; }
    public bool infinite_supply { get; set; }
    public DateTime last_updated { get; set; }
    public DateTime date_added { get; set; }
    public List<string> tags { get; set; }
    public object platform { get; set; }
    public object self_reported_circulating_supply { get; set; }
    public object self_reported_market_cap { get; set; }
    public Quote quote { get; set; }
}
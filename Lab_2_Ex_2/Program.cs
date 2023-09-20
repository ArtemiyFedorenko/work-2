class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ToUSD(double amount)
    {
        return amount / usd;
    }

    public double ToEUR(double amount)
    {
        return amount / eur;
    }

    public double ToPLN(double amount)
    {
        return amount / pln;
    }

    internal double FromUSD(int v)
    {
        throw new NotImplementedException();
    }

    internal double FromEUR(int v)
    {
        throw new NotImplementedException();
    }

    internal double FromPLN(int v)
    {
        throw new NotImplementedException();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(28.5, 30.3, 4.5);

        double usd = converter.ToUSD(1000);
        Console.WriteLine("1000 гривень = {0} доларів США", usd);

        double eur = converter.ToEUR(1000);
        Console.WriteLine("1000 гривень = {0} євро", eur);

        double pln = converter.ToPLN(1000);
        Console.WriteLine("1000 гривень = {0} злотих", pln);
    }
}
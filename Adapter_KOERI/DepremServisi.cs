namespace Adapter_KOERI
{
    public class DepremServisi
    {
        private readonly HttpClient httpClient;

        public DepremServisi(IHttpClientFactory factory)
        {
            httpClient = factory.CreateClient();
        }

        public async Task<IEnumerable<DepremModel>> DepremleriGetirAsync()
        {
            string url = "http://www.koeri.boun.edu.tr/scripts/sondepremler.asp";
            string html = await httpClient.GetStringAsync(url);

            var depremler = new List<DepremModel>();

            return depremler;
        }
    }
}

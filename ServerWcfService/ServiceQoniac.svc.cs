using QoniacBussinesLayer;

namespace ServerWcfService
{
  
    public class ServiceQoniac : IServiceQoniac
    {
        public string GetCurrencyToWords(string currency)
        {
            QoniacTask task = new QoniacTask();
            return string.Format(task.CurrencyToWords(currency));
        }
    }
}

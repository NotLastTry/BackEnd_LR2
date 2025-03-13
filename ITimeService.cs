namespace BackEnd_Нагорнов_А.В._ЛР2
{
    public interface ITimeService
    {
        string GetTime();
    }
    // время в формате hh::mm
    class ShortTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToShortTimeString();
    }
    // время в формате hh:mm:ss
    class LongTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();
    }
}

namespace MikePhil.Charting.Util
{
    public partial class EntryXComparator
    {
        public unsafe int Compare(Java.Lang.Object p0, Java.Lang.Object p1)
        {
            return Compare(p0 as MikePhil.Charting.Data.Entry, p1 as MikePhil.Charting.Data.Entry);
        }
    }
}
namespace MikePhil.Charting.Buffer
{
    public partial class BarBuffer
    {
        public override void Feed(Java.Lang.Object p0)
        {
            Feed(p0 as global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet);
        }
    }
}
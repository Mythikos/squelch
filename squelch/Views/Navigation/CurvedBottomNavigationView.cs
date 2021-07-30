using Android.Content;
using Android.Graphics;
using Android.Util;
using AndroidX.Core.Content;
using Google.Android.Material.BottomNavigation;

namespace Squelch.Views.Navigation
{
    internal class CurvedBottomNavigationView : BottomNavigationView
    {
        private Path _path;
        private Paint _paint;
        private const int CURVE_CIRCLE_RADIUS = 140 / 2;
        private int _navigationBarWidth;
        private int _navigationBarHeight;

        // The coordinates of the first curve
        private Point _firstCurveStartPoint = new Point();
        private Point _firstCurveEndPoint = new Point();
        private Point _firstCurveControlPoint1 = new Point();
        private Point _firstCurveControlPoint2 = new Point();

        // The coordinates of the second curve
        private Point _secondCurveStartPoint = new Point();
        private Point _secondCurveEndPoint = new Point();
        private Point _secondCurveControlPoint1 = new Point();
        private Point _secondCurveControlPoint2 = new Point();


        public CurvedBottomNavigationView(Context context) : base(context)
        {
            this.Initialize(context);
        }

        public CurvedBottomNavigationView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            this.Initialize(context);
        }

        public CurvedBottomNavigationView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            this.Initialize(context);
        }

        private void Initialize(Context context)
        {
            this._path = new Path();
            this._paint = new Paint();
            this._paint.SetStyle(Paint.Style.FillAndStroke);
            this._paint.Color = new Color(ContextCompat.GetColor(context, Resource.Color.colorPrimary));
            this.SetBackgroundColor(Color.Transparent);
        }

        protected override void OnLayout(bool changed, int left, int top, int right, int bottom)
        {
            base.OnLayout(changed, left, top, right, bottom);
        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            canvas.DrawPath(this._path, this._paint);
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(w, h, oldw, oldh);

            this._navigationBarWidth = this.Width;
            this._navigationBarHeight = this.Height;

            this._firstCurveStartPoint.Set((this._navigationBarWidth / 2) - (CURVE_CIRCLE_RADIUS * 2) - (CURVE_CIRCLE_RADIUS / 3), 0);
            this._firstCurveEndPoint.Set(this._navigationBarWidth / 2, CURVE_CIRCLE_RADIUS + (CURVE_CIRCLE_RADIUS / 4));

            this._secondCurveStartPoint = this._firstCurveEndPoint;
            this._secondCurveEndPoint.Set((this._navigationBarWidth / 2) + (CURVE_CIRCLE_RADIUS * 2) + (CURVE_CIRCLE_RADIUS / 3), 0);

            this._firstCurveControlPoint1.Set(this._firstCurveStartPoint.X + CURVE_CIRCLE_RADIUS + (CURVE_CIRCLE_RADIUS / 4), this._firstCurveStartPoint.Y);
            this._firstCurveControlPoint2.Set(this._firstCurveEndPoint.X - (CURVE_CIRCLE_RADIUS * 2) + CURVE_CIRCLE_RADIUS, this._firstCurveEndPoint.Y);

            this._secondCurveControlPoint1.Set(this._secondCurveStartPoint.X + (CURVE_CIRCLE_RADIUS * 2) - CURVE_CIRCLE_RADIUS, this._secondCurveStartPoint.Y);
            this._secondCurveControlPoint2.Set(this._secondCurveEndPoint.X - (CURVE_CIRCLE_RADIUS + (CURVE_CIRCLE_RADIUS / 4)), this._secondCurveEndPoint.Y);

            this._path.Reset();
            this._path.MoveTo(0, 0);
            this._path.LineTo(this._firstCurveStartPoint.X, this._firstCurveStartPoint.Y);
            this._path.CubicTo(this._firstCurveControlPoint1.X, this._firstCurveControlPoint1.Y, this._firstCurveControlPoint2.X, this._firstCurveControlPoint2.Y, this._firstCurveEndPoint.X, this._firstCurveEndPoint.Y);
            this._path.CubicTo(this._secondCurveControlPoint1.X, this._secondCurveControlPoint1.Y, this._secondCurveControlPoint2.X, this._secondCurveControlPoint2.Y, this._secondCurveEndPoint.X, this._secondCurveEndPoint.Y);
            this._path.LineTo(this._navigationBarWidth, 0);
            this._path.LineTo(this._navigationBarWidth, this._navigationBarHeight);
            this._path.LineTo(0, this._navigationBarHeight);
            this._path.Close();
        }
    }
}
namespace FindArea
{
    public class Counter
    {
        double FindGeometryArea(double R)
        {
            double Area = Math.PI * Math.Pow(R, 2);
            return Area;
        }
        double FindGeometryArea(double A, double B, double C, out string TypeOfTriangle)
        {
            double P = (A + B + C) / 2;
            double Area = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            double[] Sides = new double[] {A, B, C};
            double MaxLength = Sides.Max();
            double Length1 = double.NaN;
            double Length2 = double.NaN;
            bool FindLength1 = false;
            bool FindLength2 = false;
            for (int i = 0; i < 3; i++)
            {
                if (Sides[i] != MaxLength)
                {
                    if (!FindLength1) { Length1 = Sides[i]; FindLength1 = true; }
                    if (FindLength1 && !FindLength2) { Length2 = Sides[i]; FindLength2 = true; }
                }
            }
            if (Math.Pow(MaxLength,2) == Math.Pow(Length1, 2) + Math.Pow(Length2, 2))
            {
                TypeOfTriangle = "Right triangle";
            }
            else
            {
                TypeOfTriangle = "Not Right triangle";
            }
            return Area;
        }
    }
}
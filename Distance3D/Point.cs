public class Point
{   
    public double x, y, z;
    public Point(double x = 0, double y = 0, double z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public double Distance(Point point) => Math.Sqrt(Math.Pow((this.x - point.x), 2) 
                                                   + Math.Pow((this.y - point.y), 2) 
                                                   + Math.Pow((this.z - point.z), 2));
    
}
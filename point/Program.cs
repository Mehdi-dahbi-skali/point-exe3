class Point
{
    int x, y,D;
    Point(int X , int Y)
    {
        x = X;
        y = Y;
        D = x - y;
        if (D < 0)
        {
            D = D * -1;
        }
        
    }
    public void setX(int X)
    {
        x = X;
    }
    public void setY(int Y)
    {
        y = Y;
    }
    public int getX()
    {
        return x;
    }
    public int getY()
    {
        return y;
    }
    public int getD()
    {
        return D;
    }
    public void setD(int d)
    {
        if (d < 0)
        {
            d = d * -1;
            D = d;
        }
    }
    public bool Egale(Point obj)
    {
        int d = obj.getD();
        if(d == D)
        {
            return true;
        }
        return false;
        
    }
    public bool Linéarité(Point obj1,Point obj2)
    {
        if((obj1.getX() == obj2.getX() && obj1.getX() == x) || (obj1.getY() == obj2.getY() && obj1.getY() == y))
        {
            return true;
        }

        return false;
    }

}

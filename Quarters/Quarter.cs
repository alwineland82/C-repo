class Quarter
{
    public int x;
    public int y;

    public string quarterNumber = "Space";
    public Quarter(int x, int y)
    {
        this.x = x;
        this.y = y;
        if(this.x > 0 && this.y > 0) quarterNumber = "One";
        if(this.x > 0 && this.y < 0) quarterNumber = "Two";
        if(this.x < 0 && this.y < 0) quarterNumber = "Three";
        if(this.x < 0 && this.y > 0) quarterNumber = "Four";
    }
}
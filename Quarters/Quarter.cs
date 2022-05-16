class Quarter
{
    public string range = "Defoult";

    public int quarterNumber = 0;
    public Quarter(int quarterNumber)
    {
        if(quarterNumber == 1) range = "axis x > 0 & axis y > 0";
        if(quarterNumber == 2) range = "axis x > 0 & axis y < 0";
        if(quarterNumber == 3) range = "axis x < 0 & axis y < 0";
        if(quarterNumber == 4) range = "axis x < 0 & axis y > 0";
    }
}
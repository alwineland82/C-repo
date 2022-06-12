int SumElement(int m, int n)
{
    int sum = m;
    if(m == n) return(sum);
    m++;
    return(sum + SumElement(m,n));
}

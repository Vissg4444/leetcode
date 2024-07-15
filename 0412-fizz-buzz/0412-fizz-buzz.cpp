class Solution {
public:

vector<string> fizzBuzz(int n)
{
   vector<string> out(n);
   for ( int i = 1; i <= n; i++ )
   {
        if ( i % 3 == 0 and i % 5 == 0 )
            out[i - 1] = "FizzBuzz";
        else if (i % 3 == 0)
            out[i - 1] = "Fizz";
        else if (i % 5 == 0)
            out[i - 1] = "Buzz";
        else
         out[i - 1] = to_string(i);
   }
   return out;
}
};
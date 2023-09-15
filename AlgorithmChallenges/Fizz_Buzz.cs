public class FizzBuzzBeginnerSolution{
    public IList<string> FizzBuzz(int n){
        IList<string> returnList = new IList<string>();
        for(int i=1; i<n; i++){
        
           if ((i%3 == 0) && (i%5 != 0)){
            FizzBuzz.Add("Fizz");
           }
           else if ((i%3 != 0) && (i%5 == 0)){
            FizzBuzz.Add("Buzz");
           }
           else if ((i%3 == 0) && (i%5 == 0)){
            FizzBuzz.Add("FizzBuzz");
           }
           else{
            FizzBuzz.Add(i.toString());
           }
            Console.WriteLine(FizzBuzz);
           return FizzBuzz;
        }

}
}
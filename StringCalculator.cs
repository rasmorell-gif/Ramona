using System;


namespace Ramona_New_Proyect
{
    public class StringCalculator
    {
                 
         public int Add (string numbers)
        {
          if (numbers == "")
          return 0;
     

           if (numbers.Length>1 && numbers.Contains(","))
            { 
            var replaceN = numbers.Replace("\n", ",");                
            var separatedNumbers = replaceN.Split(",");

            int result = 0;

            for (int i = 0; i < separatedNumbers.Length ; i++)
            {
                 var number = Convert.ToInt32(separatedNumbers[i]);
                          if (number<0)
                          throw new InvalidOperationException("negative not allowed");
                          
                 result = number + result;
                 
            }

            return result;
                          
                    
            }

            if (numbers.Length>1 && numbers.Contains("//"))
            { 

            char delimiter = numbers[2]; 
            string delimiteTs = delimiter.ToString();   
            var replaceline = numbers.Replace("//", delimiteTs).Replace("\n", delimiteTs);                
            var separatedNumbers = replaceline.Split(delimiter);

            int resultOutline = 0;

            for (int i = 0; i < separatedNumbers.Length ; i++)
            {
                if (separatedNumbers[i]== "")
                    {
                      } else {

                          var number = Convert.ToInt32(separatedNumbers[i]);
                          if (number<0)
                          throw new InvalidOperationException("negative not allowed");
                   
                 resultOutline = number +resultOutline;
                      }
            }

            return resultOutline;

            }

            var n = Convert.ToInt32(numbers);
                          if (n<0)
                          throw new InvalidOperationException("negative not allowed");
                   
        return n;


        }
        
    }

   

}

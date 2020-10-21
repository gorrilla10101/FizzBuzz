# FizzBuzz
This is a modular FizzBuzz implementation with three configurable components.

## IFizzBuzzNumberComparator
By implementing IFizzBuzzNumberComparator you can change the way that the comparison occurs. The ModulusFizzBuzzComparator is a comparator that returns true if the result of a 
modulus operation is true. 

## IFizzBuzzBuilder
The IFizzBuzzBuilder is responsible for getting the actual results of the fizz buzz operations. The FizzBuzzBuilder implementation takes a list of Comparators 
and iterates the results for either a single number or a list of numbers.

## IFizzBuzzWriter 
The IFizzBuzzWriter controls where the output will be wrote to. The FizzBuzzWrtierString implementation writes it to a TextWriter. 

// Create 3 Functions that take in two floats ( a and b ) and return a float :

// - Sum: returns the sum of a and b

// - Prod: returns the product of a and b

// - Div: Returns a / b but if b is 0 it prints an error and returns nothing.

float a ;
float b;
 void float sum(a,b){
     return a+b;
 }
  void float prod(a,b){
     return a*b;
 } 
 void float div(a,b){
     if( b == 0){
         print("error");
         return 0;
     }else
     {
     return a/b;
     }
 }
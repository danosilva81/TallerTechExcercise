# TallerTechExcercise	
This is a console application to show a function called SumReverse. 

It was did it as a test exercise by [Software Engineer Daniel Silva Jiménez](https://www.linkedin.com/in/daniel-silva-jim%C3%A9nez-12871653)

## Function SumReverse

You are given two arbitrarily large numbers, stored one digit at a time in an array.
The first must be added to the second, and the second must be reversed before addition.

The goal is to calculate the sum of those two sets of values.

IMPORTANT NOTE:
- The input can be any length (i.e: it can be 20+ digits long).
- num1 and num2 can be different lengths.

Sample Inputs:
num1 = 123456
num2 = 123456

Sample Output:
Result: 777777

## Unit Testing

In the "TallerTechExceicise.Tests" test project there is a theory unit tests to test some cases of the SumReverse function.


## DATABASE Excercise

**Excercise:**
You have three different tables
A Customer Table with FirstName, LastName, Age, Occupation, MartialStatus, PersonID

An Orders Table with OrderID, PersonID, DateCreated, MethodofPurchase

An Orders Details table with OrderID, OrderDetailID, ProductNumber, ProductID, ProductOrigin

Please return a result of the customers who ordered product ID = 1112222333 and return
FirstName and LastName as full name, age, orderid, datecreated, MethodOfPurchase as Purchase Method, ProductNumber and ProductOrigin

**SOLUTION:**

<pre>
SELECT 
    cust.FirstName  + '' + cust.LastName as FullName,
    cust.Age,
    ord.OrderID,
    ord.DateCreated,
    ord.MethodofPurchase as 'Purchase Method',
    ordDet.ProductNumber,
    ordDet.ProductOrigin
FROM 
    Customer cust INNER JOIN Orders ord ON cust.PersonID = ord.PersonID INNER JOIN OrdersDetails ordDet ON ord.OrderID = ordDet.OrderID
WHERE 
    ordDet.ProductID = 1112222333
</pre>

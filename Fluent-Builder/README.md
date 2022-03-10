# Fluent Builder Pattern
It’s very common to have complex objects in our solutions. Objects that have multiple
fields and each field is difficult to build. Who is familiar with this type of object? 
Everyone, I guess. Sometimes we have gigantic constructors to create an object.

```
public class Order
{
    public Buyer Buyer { get; set; }
    public Seller Seller { get; set; }
    public Product Product { get; set; }
    public double Price { get; set; }
    (...)
    public Order(Buyer buyer, Seller seller, 
                 Product product, double price, (...))
    {
            Buyer = buyer;
            Seller = seller;
            Product = product;
            Price = price;
            (...)
    }
}
```

Each field has multiple fields and some of them could have nested objects. Good luck to 
create a new instance of this manually.

## Why is a builder the solution?
This pattern tells us to extract the object construction code out of its own class 
and put it in a separate object which we call a builder. This is the class responsible 
to create an instance of a specific object. Increase the readability and the simplicity 
of your code. It is the one who knows how to create that object with all the rules attended.

## The most important advantages are
1. More maintainable code
2. More readable code
3. Reduce errors during the creation of an object

But be careful, I don’t advise you to use this pattern for all types of objects. 
A basic object doesn’t need so much effort to build it. You must check the advantages 
that you will get when applying this pattern. We want that you get time, not wasting it 
creating builder classes for all of your objects.

## Conclusion
One of the most important things to keep in mind when you are thinking to use the builder pattern is 
to understand its advantages. As I explained earlier you gain quality in your code for some scenarios 
where you design some objects that are complex to build. This pattern is a good option when you have an 
object which has a constructor with more than a few parameters and when those parameters are objects with 
nested classes. A constructor that has multiple optional parameters is also a good scenario to use this pattern.
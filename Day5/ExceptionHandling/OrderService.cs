class OrderService
{
    public void PlaceOrder(int quantity, bool paymentServiceDown)
    {
        if (quantity <= 0)
            throw new ValidationException("Quantity must be greater than zero");

        if (quantity > 100)
            throw new BusinessRuleException("Quantity cannot exceed 100");

        if (paymentServiceDown)
            throw new ExternalServiceException("Payment gateway is unavailable");

        Console.WriteLine("Order placed successfully");
    }
}

using System;

public class Payment
{
    private int _orderId;
    private int _amountPaid;
    private DateTime _paymentDate;
    private string _transactionId;
    private bool _isPaid;

    public Payment(int orderId, int amountPaid, DateTime paymentDate, string transactionId)
    {
        _orderId = orderId;
        _amountPaid = amountPaid;
        _paymentDate = paymentDate;
        _transactionId = transactionId;
        _isPaid = false;
    }

    public void MarkAsPaid()
    {
        _isPaid = true;
    }
    public string GetDisplayString()
    {
        string paidStatus = _isPaid ? "Paid" : "Not Paid";
        return $"Order ID: {_orderId}\nAmount Paid: ${_amountPaid}\nDate: {_paymentDate.ToShortDateString()}\nTransaction ID: {_transactionId}\nStatus: {paidStatus}";
    }
}
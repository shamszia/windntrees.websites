function DashboardReport(data) {
    var instance = this;
    instance.Products = ko.observable(data.products);
    instance.Sales = ko.observable(data.sales);
    instance.Discount = ko.observable(data.discount);
    instance.ReceivedPayment = ko.observable(data.receivedPayment);
    instance.DuePayment = ko.observable(data.duePayment);
}
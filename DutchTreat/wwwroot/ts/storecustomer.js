var StoreCustomer = /** @class */ (function () {
    function StoreCustomer(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.visits = 0;
    }
    StoreCustomer.prototype.showName = function () {
        alert("Happy shopping " + this.firstName + " " + this.lastName + ". You can view products here but to place an oder you'll need to use the Angular version of the shop - this is an MVC example.");
    };
    Object.defineProperty(StoreCustomer.prototype, "name", {
        get: function () {
            return this.ourName;
        },
        set: function (val) {
            this.ourName;
        },
        enumerable: false,
        configurable: true
    });
    return StoreCustomer;
}());

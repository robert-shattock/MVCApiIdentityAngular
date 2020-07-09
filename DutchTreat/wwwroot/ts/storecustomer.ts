class StoreCustomer {

    constructor(private firstName: string, private lastName: string) {
    }

    public visits: number = 0;
    private ourName: string;

    public showName() {
        alert("Happy shopping " + this.firstName + " " + this.lastName + ". You can view products here but to place an oder you'll need to use the Angular version of the shop - this is an MVC example.");
    }

    set name(val:string) {
        this.ourName
    }

    get name(): string {
        return this.ourName;
    }
}
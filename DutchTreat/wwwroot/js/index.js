$(document).ready(function () {

    console.log("hello pluralsight");

    //NOTE: I would use let instead of var but gulp is complaining (I suspect because of targetted js version but I can't see where
    //to change what version I'm targetting)
    var theForm = $("#theForm");
    theForm.hide();

    //let button = document.getElementById("buyButton");
    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying item");
        theForm.hidden = false;
    });

    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("you clicked on " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    });


});
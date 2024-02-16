//DeliveryCheckbox
const allDeliveryCheckbox = document.querySelectorAll(
  ".checkout-form-delivery--checkbox"
);
const order_value = document.getElementById("order-value");
let lastActiveDeliveryCheckbox;
allDeliveryCheckbox[0].onclick = function () {
  activeDeliveryCheckboxFunction(0);
  order_value.innerText = "118 821 ₽";
};
allDeliveryCheckbox[1].onclick = function () {
  activeDeliveryCheckboxFunction(1);
  order_value.innerText = "118 640 ₽";
};
allDeliveryCheckbox[2].onclick = function () {
  activeDeliveryCheckboxFunction(2);
  order_value.innerText = "118 000 ₽";
};
var activeDeliveryCheckboxFunction = function (index) {
  if (lastActiveDeliveryCheckbox != null) {
    lastActiveDeliveryCheckbox.classList.remove("is-active");
  }
  allDeliveryCheckbox[index].classList.add("is-active");
  lastActiveDeliveryCheckbox = allDeliveryCheckbox[index];
};
//Payment method
const allPayCheckbox = document.querySelectorAll(
  ".checkout-form-pay--checkbox"
);
const payment_value = document.getElementById("payment-value");
let lastActivePayCheckbox = allPayCheckbox[0];
allPayCheckbox[0].onclick = function () {
  activePayCheckboxFunction(0);
  payment_value.innerText = "Картой онлайн";
};
allPayCheckbox[1].onclick = function () {
  activePayCheckboxFunction(1);
  payment_value.innerText = "В кредит *";
};
allPayCheckbox[2].onclick = function () {
  activePayCheckboxFunction(2);
  payment_value.innerText = "В рассрочку *";
};
var activePayCheckboxFunction = function (index) {
  lastActivePayCheckbox.classList.remove("is-active");
  allPayCheckbox[index].classList.add("is-active");
  lastActivePayCheckbox = allPayCheckbox[index];
};

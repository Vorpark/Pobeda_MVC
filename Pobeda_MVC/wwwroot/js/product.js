const button_pay = document.getElementById("button-pay");
let button_pay_text = document.getElementById("button-pay-text");
button_pay.onclick = function () {
  if (button_pay_text.innerText == "Купить") {
    button_pay_text.innerText = "В корзине";
  } else {
    window.location.href = "../html/cart.html";
  }
};

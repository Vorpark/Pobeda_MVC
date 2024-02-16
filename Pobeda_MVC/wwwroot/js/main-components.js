//Navbar sticky
window.addEventListener("scroll", function () {
  var navbar = document.getElementById("navbar");
  var windowOuterWidth = window.outerWidth;
  if (windowOuterWidth - 14 > 767) {
    navbar.classList.toggle("sticky", window.scrollY > 0);
  }
});
//Catalog_button
const catalog_button = document.getElementById("navbarButton");
const mobileCatalogTopButton = document.getElementById(
  "mobileCatalogTopButton"
);
const mobileCatalogDownButton = document.getElementById(
  "mobileCatalogDownButton"
);
mobileCatalogTopButton.onclick = function () {
  openCatalog();
};
mobileCatalogDownButton.onclick = function () {
  openCatalog();
};
catalog_button.onclick = function () {
  openCatalog();
};
function openCatalog() {
  let navbar_catalog = document.getElementById("navbarCatalog");
  if (!navbar_catalog.classList.contains("is-active")) {
    navbar_catalog.classList.add("is-active");
    scrollWindow();
  } else {
    navbar_catalog.classList.remove("is-active");
  }
}
async function scrollWindow() {
  window.scrollTo(0, 0);
}
const catalog_overlay = document.getElementById("navbar-catalog-overlay");
catalog_overlay.onclick = function () {
  let navbar_catalog = document.getElementById("navbarCatalog");
  navbar_catalog.classList.remove("is-active");
};
//Catalog-categories
const allMenuItem = document.querySelectorAll(".menu-item");
let lastActiveItem = allMenuItem[0];
const allCategories = document.querySelectorAll(".navbar-catalog-categories");
let lastActiveCategory = allCategories[0];
allMenuItem[0].onmouseover = function () {
  activeMenuFunction("0");
};
allMenuItem[1].onmouseover = function () {
  activeMenuFunction("1");
};
allMenuItem[2].onmouseover = function () {
  activeMenuFunction("2");
};
allMenuItem[3].onmouseover = function () {
  activeMenuFunction("3");
};
allMenuItem[4].onmouseover = function () {
  activeMenuFunction("4");
};
allMenuItem[5].onmouseover = function () {
  activeMenuFunction("5");
};
allMenuItem[6].onmouseover = function () {
  activeMenuFunction("6");
};
allMenuItem[7].onmouseover = function () {
  activeMenuFunction("7");
};
allMenuItem[8].onmouseover = function () {
  activeMenuFunction("8");
};
allMenuItem[9].onmouseover = function () {
  activeMenuFunction("9");
};
allMenuItem[10].onmouseover = function () {
  activeMenuFunction("10");
};
allMenuItem[11].onmouseover = function () {
  activeMenuFunction("11");
};

var activeMenuFunction = function (index) {
  lastActiveItem.classList.remove("is-active");
  lastActiveCategory.classList.remove("is-active");
  allMenuItem[index].classList.add("is-active");
  allCategories[index].classList.add("is-active");
  lastActiveItem = allMenuItem[index];
  lastActiveCategory = allCategories[index];
};

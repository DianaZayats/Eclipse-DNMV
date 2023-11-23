const btnChange = document.querySelector(".btn-change");
btnChange.addEventListener("click", (e) => {
  window.location.href = "settings.html";
});

const btnCreate = document.querySelector(".btn-create");
btnCreate.addEventListener("click", function (e) {
  window.location.href = "create.html";
});
const btnDelete = document.querySelector(".btn-delete");
btnDelete.addEventListener("click", function (e) {
  window.location.href = "delete.html";
});

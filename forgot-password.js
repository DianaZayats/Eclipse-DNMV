const showPasswordButtons = document.querySelectorAll(".showPassword");

showPasswordButtons.forEach((btn) => {
  if (btn) {
    btn.addEventListener("click", () => {
      const passwordInput = document.querySelector(`#${btn.dataset.for}`);

      if (passwordInput.type === "password") {
        passwordInput.type = "text";
        btn.innerHTML = '<i class="far fa-eye"></i>';
      } else {
        passwordInput.type = "password";
        btn.innerHTML = '<i class="far fa-eye-slash"></i>';
      }
    });
  }
});

const passwordResettingFrom = document.getElementById("ForgotPasswordForm");
if (passwordResettingFrom) {
  passwordResettingFrom.addEventListener("submit", (e) => {
    e.preventDefault();
    window.location.href = "login.html";
  });
}

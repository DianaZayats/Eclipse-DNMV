const passwordInput = document.getElementById("password");
const togglePassword = document.getElementById("togglePassword");
const loginButton = document.querySelector(".btn");

const signupLink = document.querySelector(".signup a");
togglePassword.addEventListener("click", () => {
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
        togglePassword.innerHTML = '<i class="far fa-eye"></i>';
    } else {
        passwordInput.type = "password";
        togglePassword.innerHTML = '<i class="far fa-eye-slash"></i>';
    }
});

const loginForm = document.getElementById("login-form");
if (loginForm) {
    loginForm.addEventListener("submit", (e) => {
        e.preventDefault();
        window.location.href = "personalinfo.html";
    });
}
const passwordInput = document.getElementById('password');
const togglePassword = document.getElementById('togglePassword');

togglePassword.addEventListener('click', () => {
    if(passwordInput.type === 'password') {
        passwordInput.type = 'text';
        togglePassword.innerHTML = '<i class="far fa-eye"></i>';
    } else {
        passwordInput.type = 'password';
        togglePassword.innerHTML = '<i class="far fa-eye-slash"></i>';
    }
});
var loginButton = document.getElementsByClassName("btn");
if (loginButton) {
  loginButton.addEventListener("click", function (e) {
    window.location.href = "./LogIn.html";
  });
}

var loginButton = document.getElementsByClassName("signup");
if (loginButton) {
  loginButton.addEventListener("click", function (e) {
    window.location.href = "./signup.html";
  });
}

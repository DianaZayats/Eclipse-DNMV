const passwordInput = document.getElementById('password');
const togglePassword = document.getElementById('togglePassword');
const loginButton = document.querySelector('.btn'); 

const signupLink = document.querySelector('.signup a'); 
togglePassword.addEventListener('click', () => {
    if(passwordInput.type === 'password') {
        passwordInput.type = 'text';
        togglePassword.innerHTML = '<i class="far fa-eye"></i>';
    } else {
        passwordInput.type = 'password';
        togglePassword.innerHTML = '<i class="far fa-eye-slash"></i>';
    }
});

  const loginForm = document.querySelector('.btn');
  if (loginForm) {
    loginForm.addEventListener('click', (e) => {
      e.preventDefault();
      window.location.href = 'personalinfo.html';
    });
  }
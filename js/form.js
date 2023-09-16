function heroSaveEmail() {
    saveEmail('subscription-form', 'email', 'subscribeBtn', 'error-message', 'success-message', 'save-error-message', 'success-section');
}

function footerSaveEmail() {
    saveEmail('subscription-form', 'email', 'subscribeBtn', 'error-message', 'success-message', 'save-error-message', 'success-section');
}

function saveEmail(subForm, emailInp, btn, errorMsg, successMsg, saveErrorMsg, successDiv) {
    const emailInput = document.getElementById(emailInp);
    const errorMessage = document.getElementById(errorMsg);
    const successMessage = document.getElementById(successMsg);
    const saveErrorMessage = document.getElementById(saveErrorMsg);
    const subscribeBtn = document.getElementById(btn);
    const form = document.getElementById(subForm);
    const successSection = document.getElementById(successDiv);

    // Regular expression for email validation
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    const email = emailInput.value;

    if (!email.match(emailRegex)) {
        errorMessage.style.display = 'block';
        setTimeout(function () {
            errorMessage.style.display = 'none';
        }, 6000);
    } else {
        // Simulate a POST request to a certain URL
        // Replace 'your-api-url' with your actual API endpoint
        fetch('https://your-api-url', {
            method: 'POST',
            body: JSON.stringify({ email: email }),
            headers: {
                'Content-Type': 'application/json',
            },
        })
        .then((response) => {
            if (response.ok) {
                // Subscription successful
                errorMessage.style.display = 'none';
                successMessage.style.display = 'block';
                emailInput.style.display = 'none';
                subscribeBtn.style.display = 'none';
                subscribeBtn.style.display = 'none';
                form.display = 'none';
                successSection.style.display = 'block';
            } else {
                // Error saving email
                errorMessage.style.display = 'none';
                saveErrorMessage.style.display = 'block';
                setTimeout(function () {
                    saveErrorMessage.style.display = 'none';
                }, 6000);
            }
        })
        .catch((error) => {
            console.error(error);
            errorMessage.style.display = 'none';
            saveErrorMessage.style.display = 'block';
            setTimeout(function () {
                saveErrorMessage.style.display = 'none';
            }, 6000);
        });
    }
}
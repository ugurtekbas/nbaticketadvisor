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

    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    const email = emailInput.value;

    if (!email.match(emailRegex)) {
        errorMessage.style.display = 'block';
        setTimeout(function () {
            errorMessage.style.display = 'none';
        }, 6000);
    } else {
        fetch('https://emailoctopus.com/api/1.6/lists/cbc61a2c-5096-11ee-bb2e-45b6af230df4/contacts', {
            method: 'POST',
            body: { email_address: email, api_key:'18d8dd1d-5cec-4c2a-8c82-f28b8a1a13fc' },
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
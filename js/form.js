function heroSaveEmail() {
    saveEmail('subscription-form', 'email', 'subscribeBtn', 'error-message', 'save-error-message', 'success-section');
    gtag('event','Hero subscription button click', { 'event_category': 'Button click', 'event_label': 'Hero signup', 'value': 1 });
}

function footerSaveEmail() {
    saveEmail('bottom-subscription-form', 'bottom-email', 'bottom-subscribeBtn', 'bottom-error-message', 'bottom-save-error-message', 'bottom-success-section');
    gtag('event','Footer subscription button click', { 'event_category': 'Button click', 'event_label': 'Footer signup', 'value': 1 });
}

function aboutSaveEmail() {
    saveEmail('about-subscription-form', 'about-email', 'about-subscribeBtn', 'about-error-message',  'about-save-error-message', 'about-success-section');
    gtag('event','About subscription button click', { 'event_category': 'Button click', 'event_label': 'About signup', 'value': 1 });
}

function onTwitterClick() {
    gtag('event', 'Twitter account link click', { 'event_category': 'Link click', 'event_label': 'Twitter', 'value': 1 });
}

function saveEmail(subForm, emailInp, btn, errorMsg, saveErrorMsg, successDiv) {
    const emailInput = document.getElementById(emailInp);
    const errorMessage = document.getElementById(errorMsg);
    const saveErrorMessage = document.getElementById(saveErrorMsg);
    const subscribeBtn = document.getElementById(btn);
    const form = document.getElementById(subForm);
    const successSection = document.getElementById(successDiv);

    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    const email = emailInput.value;
    const data = {
        "records": [
            {
              "fields": {
                "Email": email,
              }
            }
        ]
    }
    if (!email.match(emailRegex)) {
        errorMessage.style.display = 'block';
        setTimeout(function () {
            errorMessage.style.display = 'none';
        }, 6000);
    } else {
        fetch(
            'https://api.airtable.com/v0/appTlqT0QXLdRnYW2/tblZeSvuzSNgK30t5',
            {
                method: 'POST',
                body: JSON.stringify(data),
                headers: {
                    'Authorization': 'Bearer ' + 'patstdFbhCs56N6L7.d4388703f2604e46ffde8a9a988de583f83ae57a9bfc25b75b0bc2feb1ca8e00',
                    'Content-Type': 'application/json',
                },
        })
        .then((response) => {
            if (response.ok) {
                // Subscription successful
                errorMessage.style.display = 'none';
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
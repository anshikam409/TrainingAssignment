for (let i = 0; i <= 15; i++) {
    const outputDiv = document.getElementById('output');
    const message = document.createElement('p');

    if (i === 0) {
        message.textContent = `${i} is even`;
    } else if (i % 2 === 0) {
        message.textContent = `${i} is even`;
    } else {
        message.textContent = `${i} is odd`;
    }

    outputDiv.appendChild(message);
}
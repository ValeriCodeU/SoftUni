function extractText() {
    
    let textItems = document.getElementById('items');
    let textArea = document.getElementById('result');

    textArea.textContent = textItems.textContent;
}
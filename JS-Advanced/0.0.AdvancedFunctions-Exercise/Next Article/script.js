function getArticleGenerator(articles) {
    let array = articles;

    return function showNext() {

        if (array.length > 0) {
            let articleElement = document.createElement('article');
            let divElement = document.querySelector('#content');

            articleElement.textContent = array.shift();
            divElement.appendChild(articleElement);
        }
    }
}

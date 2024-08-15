// Ürünleri ve makaleleri fetch etme ve gösterme
document.addEventListener('DOMContentLoaded', () => {
    const productContainer = document.getElementById('products');
    const articleContainer = document.getElementById('articles');
    const errorMessage = document.getElementById('error-message');

    // Ürünleri fetch etme
    fetch('api/products')
        .then(response => {
            if (!response.ok) {
                throw new Error(`HTTP error! Status: ${response.status}`);
            }
            return response.json();
        })
        .then(products => {
            if (products.length > 0) {
                products.forEach(product => {
                    const productDiv = document.createElement('div');
                    productDiv.className = 'item';
                    productDiv.innerHTML = `
                        <img src="${product.imageUrl}" alt="${product.name}">
                        <h3>${product.name}</h3>
                        <p>Price: ${product.price}</p>
                        <p>Stock: ${product.stock}</p>
                        <p>${product.description}</p>
                    `;
                    productContainer.appendChild(productDiv);
                });
            } else {
                productContainer.innerHTML = '<p>No products available.</p>';
            }
        })
        .catch(error => {
            console.error('Error fetching products:', error);
            errorMessage.textContent = 'Error fetching products. Please try again later.';
        });

    // Makaleleri fetch etme
    fetch('api/articles')
        .then(response => {
            if (!response.ok) {
                throw new Error(`HTTP error! Status: ${response.status}`);
            }
            return response.json();
        })
        .then(articles => {
            if (articles.length > 0) {
                articles.forEach(article => {
                    const articleDiv = document.createElement('div');
                    articleDiv.className = 'item';
                    articleDiv.innerHTML = `
                        <img src="${article.imageUrl}" alt="${article.title}">
                        <h3>${article.title}</h3>
                        <p>${article.description}</p>
                    `;
                    articleContainer.appendChild(articleDiv);
                });
            } else {
                articleContainer.innerHTML = '<p>No articles available.</p>';
            }
        })
        .catch(error => {
            console.error('Error fetching articles:', error);
            errorMessage.textContent = 'Error fetching articles. Please try again later.';
        });
});

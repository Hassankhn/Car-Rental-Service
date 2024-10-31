document.addEventListener('DOMContentLoaded', function () {
    // Product class
    class Product {
        constructor(title, price, imageUrl) {
            this.title = title;
            this.price = price;
            this.imageUrl = imageUrl;
        }
    }

    // Function to create a card element
    function createCard(product) {
        const cardContainer = document.getElementById('cardContainer');

        // Create card elements
        const card = document.createElement('div');
        card.classList.add('card');

        const cardImage = document.createElement('img');
        cardImage.src = product.imageUrl || 'https://picsum.photos/300/200?random=1'; // Placeholder image URL

        const cardDetails = document.createElement('div');
        cardDetails.classList.add('card-details');

        const cardTitle = document.createElement('h2');
        cardTitle.textContent = product.title || 'Product Title';

        const cardPrice = document.createElement('p');
        cardPrice.classList.add('price');
        cardPrice.textContent = product.price || '$99.99';

        const buyNowButton = document.createElement('button');
        buyNowButton.classList.add('buy-now');
        buyNowButton.textContent = 'Buy Now';

        // Append elements to the card
        cardDetails.appendChild(cardTitle);
        cardDetails.appendChild(cardPrice);
        cardDetails.appendChild(buyNowButton);

        card.appendChild(cardImage);
        card.appendChild(cardDetails);

        // Append the card to the card container
        cardContainer.appendChild(card);
    }

    // Example: Add multiple sample cards using the Product class
    const products = [
        new Product('Car Battery', 'PKR8000', 'Images/battery.png'),
        new Product('Break Leather', 'PKR3500', 'Images/breakleather.png'),
        new Product('Clutch Plate', 'PKR1500', 'Images/clutch-plates.png'),
        new Product('Muffler', 'PKR4500', 'Images/muffler.webp'),
        new Product('Piston', 'PKR6500', 'Images/piston.webp'),
        new Product('Rims', 'PKR12000 ', 'Images/rims.png'),
        new Product('Wiper Blades', 'PKR1500', 'Images/wiperblades.jpg'),
        new Product('Air Filter', 'PKR500 ', 'Images/airfilter.png'),
        new Product('Door Handles', 'PKR2000', 'Images/doorhandles.webp'),
        new Product('Drum Bush', 'PKR1800', 'Images/drumbush.png'),
        new Product('Horn', 'PKR1500', 'Images/horn.webp'),
        new Product('Seat', 'PKR12000', 'Images/seat.png'),
        new Product('Head Lights', 'PKR9000', 'Images/headlights.png'),
        new Product('Mats', 'PKR1800', 'Images/matt.png'),
        new Product('Steering', 'PKR4000', 'Images/steering.pngImages/speakers.png'),
        new Product('Speakers', 'PKR12000', 'Images/steering.png'),
        new Product('Side Mirrors', 'PKR1800', 'Images/sidemirror.avif'),
    
        // Add more products as needed
    ];

    products.forEach(product => {
        createCard(product);
    });
});

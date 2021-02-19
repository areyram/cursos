function discountPrices(prices, discount) {
    const discounted = [];

    for (let i = 0; i < prices.length; i++) {
        const discountedPrice = prices[i] * (1 - discount);
        const finalPrice = Math.round(discountedPrice * 100) / 100;
        discounted.push(finalPrice)
    }

    console.log(i) // 3
    console.log(discountedPrice) // 150
    console.log(finalPrice) // 150

    return discounted
}

discountPrices([100, 120, 150], [0.15])
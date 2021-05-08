function suma(a, b) {
    return a + b;
}

function resta(a, b) {
    return a - b;
}

const f = resta;
console.log(f(123, 234));

const g = function (a, b) {
    return a * b;
};
console.log(g(3, 5));

console.log((function (a, b) {
    return a * b;
})(3, 5));
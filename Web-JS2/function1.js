// console.log(suma(123, 234));

// function suma(a, b) {
//     return a + b;
// }

// function suma(a, b, c) {
//     return a + b + c;
// }

console.log(suma(123, 234));

/**
 * Obtiene la suma de "N" númers
 * @param {number[]} a Arreglo de números a sumar
 * @returns {number}
 */
function suma(a) {
    let s = 0;
    for (let i = 0; i < a.length; i++)
        s += a[i]; 
    return s;
}

console.log(suma([123, 234]));

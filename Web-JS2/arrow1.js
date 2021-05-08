const a = [1, 5, 9, 3, 7, 4, 2, 6, 8];
a.sort();
console.log(a);

a.sort((a, b) => {
    return b - a;
});
console.log(a);

a.sort((a, b) => b - a);
console.log(a);

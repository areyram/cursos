function Descending(a, b) {
    return b - a;
}

const a = [1, 5, 9, 3, 7, 4, 2, 6, 8];
a.sort();
console.log(a);
a.sort(Descending);
console.log(a);

const comp = function (a, b) {
    return a.id - b.id;
};
const ao = [{ id: 1 }, { id: 5 }, { id: 3 }, { id: 2 }];
ao.sort(comp);
console.log(ao);

ao.sort(function (a, b) {
    return b.id - a.id;
});
console.log(ao);

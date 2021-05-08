const arr100a = [];
for (let i = 0; i < 100; i++)
    arr100a.push(i + 1);
console.log(arr100a);

const arr100b = new Array(100);
for (let i = 0; i < arr100b.length; i++) {
    arr100b[i] = i + 1;
}
console.log(arr100b);

const arr100c = new Array(100).fill().map((o, i) => i + 1);
console.log(arr100c);

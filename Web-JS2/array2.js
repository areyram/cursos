const arr0 = [1, 5, 9, 7, 6, 8, 4, 2];
const plusone = arr0.map(o => o + 1);
console.log(plusone);
const ascode = arr0.map(o => "N" + o);
console.log(ascode);

const arr1 = [1, 3, 5, 7];
const arr2 = [2, 4, 6, 8];
const arr3 = [...arr1, ...arr2];
console.log(arr3);

const parms = [1983, 5];
const date = new Date(...parms, 1);
console.log(date);

const arr = [1, 5, 9, 7, 6, 8, 4, 2];
let max = Math.max(arr);
console.log(max);
max = Math.max(...arr);
console.log(max);

const dup = [1, 2, 3, 6, 5, 4, 7, 8, 9, 6, 3, 2, 1, 4, 7, 5];
const set = new Set(dup);
console.log(set);
const uniq = Array.from(set);
console.log(uniq);
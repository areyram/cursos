const arr = [1, 3, 4, 7, "boop", 11, 18, 29];

const nums = arr.filter(o => typeof o === "number");
console.log(nums);

const str = arr.find(o => typeof o !== "number");
console.log(str);

console.log(nums.map(o => o + 1));
console.log(nums.map((o, i) => [i, o]));
console.log(nums.map(o => ({ v: o })));

const sum = nums.reduce((a, b) => a + b);
console.log(sum);

const all = arr
    .filter(o => typeof o === "number")
    .map(o => o ** 2)
    .reduce((a, b) => a + b);
console.log(all);

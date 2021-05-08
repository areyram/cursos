let arr1 = [1];
let x;
x = arr1.push(3);
console.log(x, arr1);
x = arr1.push(7);
console.log(x, arr1);
x = arr1.pop();
console.log(x, arr1);
x = arr1.pop();
console.log(x, arr1);

arr1 = [1];
x = arr1.push(3);
console.log(x, arr1);
x = arr1.push(7);
console.log(x, arr1);
x = arr1.shift();
console.log(x, arr1);
x = arr1.shift();
console.log(x, arr1);

const arr2 = Array.from("Hello, world!");
console.log(arr2);
const o = { a: 123, b: "Hello" };
const p = Object.assign({ c: new Date(), d: 4.5 }, o);
console.log(o, p);
const obj = {
    ID: 123,
    Name: "Alejandro",
    DOB: new Date(1972, 3, 18)
};

console.log(Object.keys(obj));
console.log(Object.values(obj));
console.log(Object.entries(obj));   // -> Key-value pairs
console.log(Object.fromEntries([
    ["ID", 234],
    ["Name", "Aaron"],
    ["DOB", new Date(2015, 1, 21)]
]));


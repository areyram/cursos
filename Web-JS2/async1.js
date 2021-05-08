function sleep(interval) {
    return new Promise((resolve, reject) => {
        setTimeout(() => resolve(interval), interval);
    });
};

sleep(1000);
console.log("1");
sleep(2000);
console.log("2");
sleep(3000);
console.log("3");
sleep(4000);
console.log("4");
console.log("Done");
